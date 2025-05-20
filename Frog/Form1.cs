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
            _utilBanco = new UtilBanco();

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

            _utilBanco.FecharConexaoComBancoDeDados(_conn);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            _utilGrid = new UtilGrid();
            _utilString = new UtilString();
            _utilBanco = new UtilBanco();

            var consulta = _utilString.RecuperarBlocoTextoDoCursor(txtArea);

            if (String.IsNullOrEmpty(consulta)) return;

            if (_conn == null)
            {
                MessageBox.Show("Não conectado ao banco de dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _utilBanco.AbrirConexaoComBancoDeDados(_conn);
            }
            catch (Exception)
            {
                return;
            }

            var query = consulta;

            var qtdeLinhas = _utilBanco.RecuperarQuantidadeRegistrosDaQuery(_conn, query);

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

            _utilGrid.LimparGrid(txtGrid);
            _utilGrid.AdicionarColunaCabecalho(txtGrid, colunas);
            _utilGrid.AdicionarLinhasNaGrid(txtGrid, qtdeLinhas);
            _utilGrid.AdicionarDadosNaGrid(txtGrid, reader);

            _utilBanco.FecharConexaoComBancoDeDados(_conn);
        }

        private void txtArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                btnExecutar_Click(sender, e);

                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F4)
            {
                _utilString = new UtilString();
                _utilBanco = new UtilBanco();

                var nome = _utilString.RecuperarPalavraDoCursor(txtArea);
                _utilBanco.IdentificaTipoObjeto(_conn, nome);

                e.SuppressKeyPress = true;
            }
        }

    }
}
