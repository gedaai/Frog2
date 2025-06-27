using Frog.Classes;
using Frog.Componentes;
using Frog.Utilitarios;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Frog
{
    public partial class Form1 : Form
    {
        OracleConnection _conn = null;
        private IConfiguration _configuration;
        private List<ConexoesBanco> conexoes = new List<ConexoesBanco>();

        public Form1()
        {
            InitializeComponent();

            var barraMenu = new ComponenteBarraMenus();

            panelMenu.Controls.Add(barraMenu);
            barraMenu.Show();

            TamanhoTela();
            CarregarConexoes();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Desconectar")
            {
                _conn.FecharConexaoComBancoDeDados();
                _conn = null;
                lblStatus.Text = "Não conectado";
                btnConectar.Text = "Conectar";
                txtConexaoBanco.Enabled = true;
                return;
            }

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
            btnConectar.Text = "Desconectar";
            txtConexaoBanco.Enabled = false;

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

        private void CarregarConexoes()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();

            var connectionStrings = _configuration.GetSection("ConnectionStrings").GetChildren();

            foreach (var conn in connectionStrings)
            {
                var con = new ConexoesBanco
                {
                    Chave = conn.Key,
                    Conteudo = conn.Value
                };

                conexoes.Add(con);

                comboConexoes.Items.Add(conn.Key);
            }

            comboConexoes.SelectedItem = conexoes[0].Chave;
        }

        private void comboConexoes_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedValue = comboConexoes.SelectedItem.ToString();

            txtConexaoBanco.Text = conexoes.Where(x => x.Chave == selectedValue).FirstOrDefault().Conteudo;
        }
    }
}
