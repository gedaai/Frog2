using Frog.Utilitarios;
using Oracle.ManagedDataAccess.Client;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frog.Componentes
{
    public partial class ComponenteAba : UserControl
    {
        OracleConnection _conn;

        public ComponenteAba(OracleConnection conn)
        {
            InitializeComponent();
            _conn = conn;

            splitContainer1.Dock = DockStyle.Fill;
            txtArea.Dock = DockStyle.Fill;
            tabResultados.Dock = DockStyle.Fill;    
            tabPageDados.Dock = DockStyle.Fill;
            tabPageResultados.Dock = DockStyle.Fill;
            txtGrid.Dock = DockStyle.Fill;
            txtLog.Dock = DockStyle.Fill;
        }

        private void txtArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9 || e.KeyCode == Keys.F5)
            {
                Executar();

                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F4)
            {
                var nome = txtArea.RecuperarPalavraDoCursor();
                _conn.IdentificaTipoObjeto(nome);

                e.SuppressKeyPress = true;
            }
        }

        private void Executar()
        {
            var consulta = txtArea.RecuperarBlocoTextoDoCursor();

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

        public void ExecutarConsulta(string comando)
        {
            try
            {
                var query = comando;

                var qtdeLinhas = _conn.RecuperarQuantidadeRegistrosDaQuery(query);

                if (qtdeLinhas <= 0)
                {
                    txtGrid.LimparGrid();
                    return;
                }

                var reader = _conn.RecuperarColunasCabecalhoDaGrid(query);

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

                if (tabResultados.SelectedIndex != 0)
                    tabResultados.SelectTab(0);

                txtGrid.LimparGrid();
                txtGrid.AdicionarColunaCabecalho(colunas);
                txtGrid.AdicionarLinhasNaGrid(qtdeLinhas);
                txtGrid.AdicionarDadosNaGrid(reader);

                //lblConsultaQtde.Text = $"Quantidade de registros {qtdeLinhas}.";
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

        private void RegistrarLog(string texto)
        {
            if (!string.IsNullOrEmpty(txtLog.Text))
            {
                txtLog.Text += Environment.NewLine;
            }
            
            if (tabResultados.SelectedIndex != 1)
                tabResultados.SelectTab(1);

            txtLog.Text += DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "      " + texto + ".";
        }
    }
}
