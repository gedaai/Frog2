using Frog.Componentes;
using Frog.Utilitarios;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Frog
{
    public partial class Form1 : Form
    {
        OracleConnection _conn = null;

        public Form1()
        {
            InitializeComponent();

            var barraMenu = new ComponenteBarraMenus();

            panelMenu.Controls.Add(barraMenu);
            barraMenu.Show();

            TamanhoTela();

            
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
                _conn.AbrirConexaoComBancoDeDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar conexão com o banco. {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Não conectado";
                btnExecutar.Enabled = false;
                return;
            }

            lblStatus.Text = "Conectado";

            var formComTabs = new ComponenteTab(_conn);
            formComTabs.Dock = DockStyle.Fill;

            panel1.Controls.Add(formComTabs);
            formComTabs.Show();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            /*_conn.Commit();
            RegistrarLog("Commit");*/
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            /*_conn.Rollback();
            RegistrarLog("Rollback");*/
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            TamanhoTela();
        }

        private void TamanhoTela()
        {
            int windowWidth = this.ClientSize.Width;
            int windowHeight = this.ClientSize.Height;

            panel1.Width = (int)(windowWidth - 22);
            panel1.Height = (int)(windowHeight - 90);
        }
    }
}
