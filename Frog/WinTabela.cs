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
using static System.Windows.Forms.MonthCalendar;

namespace Frog
{
    public partial class WinTabela : Form
    {
        string _nomeTabela = string.Empty;
        string _type = string.Empty;

        OracleConnection _conn;

        public WinTabela(OracleConnection conn, string nomeTabela)
        {
            InitializeComponent();
            _nomeTabela = nomeTabela;
            _conn = conn;
        }

        private void WinTabela_Load(object sender, EventArgs e)
        {
            var query = $@" select column_id, 
                                   column_name, 
                                   Case data_type
                                     When 'NUMBER' Then data_type || '(' || data_precision || Case when data_scale > 0 then ',' || data_scale else '' end ||')'
                                     When 'VARCHAR2' Then data_type || '(' || data_length ||')'
                                     When 'CHAR' Then data_type || '(' || data_length ||')'
                                    else data_type
                                   end as data_type, 
                                   nullable 
                              from USER_TAB_COLUMNS
                             where table_name = '{_nomeTabela.ToUpper().Trim()}' 
                             order by column_id  "; 

            var qtdeLinhas = _conn.RecuperarQuantidadeRegistrosDaQuery(query);

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

            dgTabela.LimparGrid();
            dgTabela.AdicionarColunaCabecalho(colunas);
            dgTabela.AdicionarLinhasNaGrid(qtdeLinhas);
            dgTabela.AdicionarDadosNaGrid(reader);
        }
    }
}
