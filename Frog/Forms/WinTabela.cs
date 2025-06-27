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

            panel1.Dock = DockStyle.Fill;
            tabControlPrincipal.Dock = DockStyle.Fill;
            splitContainerTriggers.Dock = DockStyle.Fill;
            dataGridTriggers.Dock = DockStyle.Fill;
            txtTriggerSource.Dock = DockStyle.Fill;
            dgTabela.Dock = DockStyle.Fill;

            TamanhoTela();
        }

        private void WinTabela_Load(object sender, EventArgs e)
        {
            CarregarDadosColunas();
            CarregarDadosTriggers();
        }

        private void CarregarDadosColunas()
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

            dgTabela.LimparGrid();
            dgTabela.AdicionarColunaCabecalho(colunas);
            dgTabela.AdicionarLinhasNaGrid(qtdeLinhas);
            dgTabela.AdicionarDadosNaGrid(reader);
        }

        private void CarregarDadosTriggers()
        {
            var query = $@" select trigger_name as Name, trigger_type as type, status as enabled, triggering_event as event
                              from user_triggers
                            where table_name = '{_nomeTabela.ToUpper().Trim()}' ";

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
                    
                    var cellWidth = 100;
                    if (colunas[i].HeaderText == "NAME")
                    {
                        cellWidth = 225;
                    }
                    else if (colunas[i].HeaderText == "TYPE")
                    {
                        cellWidth = 130;
                    }
                    else if (colunas[i].HeaderText == "EVENT")
                    {
                        cellWidth = 180;
                    }
                    colunas[i].Width = cellWidth;
                }
                break;
            }
            var command = new OracleCommand(query, _conn);
            reader = command.ExecuteReader();

            dataGridTriggers.LimparGrid();
            dataGridTriggers.AdicionarColunaCabecalho(colunas);
            dataGridTriggers.AdicionarLinhasNaGrid(qtdeLinhas);
            dataGridTriggers.AdicionarDadosNaGrid(reader);
        }

        private void TamanhoTela()
        {
            int windowWidth = this.ClientSize.Width;
            int windowHeight = this.ClientSize.Height;

            panel1.Width = (int)(windowWidth - 22);
            panel1.Height = (int)(windowHeight - 90);
        }

        private void WinTabela_Resize(object sender, EventArgs e)
        {
            TamanhoTela();
        }

        private void WinTabela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

                e.SuppressKeyPress = true;
            }
        }

        private void dataGridTriggers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridTriggers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridTriggers.SelectedRows[0];
                string valor = selectedRow.Cells[0].Value.ToString();

                var source = UtilBanco.RecuperarSourceObjeto(valor, "TRIGGER");

                txtTriggerSource.Text = source;
            }            
        }
    }
}
