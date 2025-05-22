using Frog.Utilitarios;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Frog
{
    public partial class Form1 : Form
    {
        OracleConnection _conn = null;
        UtilBanco _utilBanco;
        UtilString _utilString;
        UtilGrid _utilGrid;

        public Form1()
        {
            InitializeComponent();
            _utilGrid = new UtilGrid();
            _utilString = new UtilString();
            _utilBanco = new UtilBanco();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            var stringConexao = txtConexaoBanco.Text;

            if (String.IsNullOrEmpty(stringConexao))
            {
                MessageBox.Show("String de conexão não informada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _conn = new OracleConnection(stringConexao);

            try
            {
                _utilBanco.AbrirConexaoComBancoDeDados(_conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar conexão com o banco. {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Não conectado";
                btnExecutar.Enabled = false;
                return;
            }

            lblStatus.Text = "Conectado";
            btnExecutar.Enabled = true;
            txtArea.Enabled = true;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var consulta = _utilString.RecuperarBlocoTextoDoCursor(txtArea);

            if (String.IsNullOrEmpty(consulta)) return;

            if (_conn == null)
            {
                MessageBox.Show("Não conectado ao banco de dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (consulta.ToUpper().Trim().StartsWith("SELECT"))
            {
                ExecutarConsulta(consulta);
            }
            else
            {
                ExecutarComando(consulta);
            }
        }

        private void txtArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                btnExecutar_Click(sender, e);

                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnExecutar_Click(sender, e);

                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F4)
            {
                var nome = _utilString.RecuperarPalavraDoCursor(txtArea);
                _utilBanco.IdentificaTipoObjeto(_conn, nome);

                e.SuppressKeyPress = true;
            }
        }

        public void ExecutarConsulta(string comando)
        {
            try
            {
                var query = comando;

                var qtdeLinhas = _utilBanco.RecuperarQuantidadeRegistrosDaQuery(_conn, query);

                if (qtdeLinhas <= 0)
                {
                    _utilGrid.LimparGrid(txtGrid);
                    return;
                }

                var reader = _utilBanco.RecuperarColunasCabecalhoDaGrid(_conn, query);

                var colunas = new DataGridViewColumn[reader.FieldCount];
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        colunas[i] = new DataGridViewTextBoxColumn();
                        colunas[i].HeaderText = reader.GetName(i);
                    }
                    break;
                }
                var command = new OracleCommand(query, _conn);
                reader = command.ExecuteReader();

                if(tabResultados.SelectedIndex != 0)
                    tabResultados.SelectTab(0);

                _utilGrid.LimparGrid(txtGrid);
                _utilGrid.AdicionarColunaCabecalho(txtGrid, colunas);
                _utilGrid.AdicionarLinhasNaGrid(txtGrid, qtdeLinhas);
                _utilGrid.AdicionarDadosNaGrid(txtGrid, reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExecutarComando(string comando)
        {
            try
            {
                var command = new OracleCommand(comando, _conn);
                var exec = command.ExecuteReader();

                var linhasAfetadas = exec.RecordsAffected;
                var texto = string.Empty;

                if (tabResultados.SelectedIndex != 1)
                    tabResultados.SelectTab(1);

                if (linhasAfetadas > 0)
                {
                    texto = "Linhas afetadas: " + linhasAfetadas;
                }
                else
                {
                    texto = "Procedimento realizado com sucesso";
                }

                RegistrarLog(texto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            _utilBanco.Commit(_conn);
            RegistrarLog("Commit");
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            _utilBanco.Rollback(_conn);
            RegistrarLog("Rollback");
        }

        private void RegistrarLog(string texto)
        {
            if (!string.IsNullOrEmpty(txtLog.Text))
            {
                txtLog.Text += Environment.NewLine;
            }

            txtLog.Text += DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "      " + texto + ".";
        }
    }
}
