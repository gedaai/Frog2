using Frog.Utilitarios;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frog
{
    public partial class WinObjetos : Form
    {
        string _nomeObjeto = string.Empty;
        string _type = string.Empty;
        OracleConnection _conn;

        public WinObjetos(OracleConnection conn, string nomeObjeto, string type)
        {
            InitializeComponent();
            _nomeObjeto = nomeObjeto;
            _conn = conn;
            _type = type;

            dataGridErros.Dock = DockStyle.Fill;
            tabControl1.Dock = DockStyle.Fill;
            rtSource.Dock = DockStyle.Fill;
        }

        private void WinPackage_Load(object sender, EventArgs e)
        {
            if (_type == "PACKAGE" || _type == "PACKAGE BODY")
                btnSpecBody.Enabled = true;
            else
                btnSpecBody.Enabled = false;

            CarregarSource();
            CarregarErros();
        }

        private void btnSpecBody_Click(object sender, EventArgs e)
        {
            if (_type == "PACKAGE")
                _type = "PACKAGE BODY";
            else
                _type = "PACKAGE";

            CarregarSource();
        }

        public void CarregarSource()
        {
            var source = UtilBanco.RecuperarSourceObjeto(_nomeObjeto, _type);

            rtSource.Text = source;

            rtSource.ColorirSQL();
        }

        private void WinObjetos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

                e.SuppressKeyPress = true;
            }
        }

        public void CarregarErros()
        {
            var query = $@" select sequence, line, position, text, attribute from USER_ERRORS where NAME = '{_nomeObjeto}'  ";

            var qtdeLinhas = UtilBanco.RecuperarQuantidadeRegistrosDaQuery(query);

            if (qtdeLinhas <= 0) return;

            var reader = UtilBanco.RecuperarColunasCabecalhoDaGrid(query);

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

            dataGridErros.LimparGrid();
            dataGridErros.AdicionarColunaCabecalho(colunas);            
            dataGridErros.AdicionarLinhasNaGrid(qtdeLinhas);
            dataGridErros.AdicionarDadosNaGrid(reader);
        }
    }
}
