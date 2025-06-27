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
        }

        private void WinPackage_Load(object sender, EventArgs e)
        {
            if (_type == "PACKAGE" || _type == "PACKAGE BODY")
                btnSpecBody.Enabled = true;
            else
                btnSpecBody.Enabled = false;

            CarregarSource();
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
    }
}
