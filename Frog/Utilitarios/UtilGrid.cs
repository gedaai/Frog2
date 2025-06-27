using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frog.Utilitarios
{
    public static class UtilGrid
    {
        public static void LimparGrid(this DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();
        }

        public static void AdicionarColunaCabecalho(this DataGridView dataGrid, DataGridViewColumn[] colunas)
        {
            dataGrid.Columns.AddRange(colunas);
        }

        public static void AdicionarLinhasNaGrid(this DataGridView dataGrid, int qtdeLinhas)
        {
            if (qtdeLinhas > 1)
                dataGrid.Rows.Add(qtdeLinhas - 1);
        }

        public static void AdicionarDadosNaGrid(this DataGridView dataGrid, OracleDataReader reader)
        {
            var linha = 0;

            dataGrid.SuspendLayout();
            dataGrid.Visible = false;
                        
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetName(i).ToUpper().Trim() == "SIMBOLO")
                    {
                        continue;
                    }

                    try
                    {
                        dataGrid.Rows[linha].Cells[i].Value = reader.GetValue(i);
                    }
                    catch (Exception)
                    {
                        dataGrid.Rows[linha].Cells[i].Value = "";
                    }                    
                }

                linha++;
            }

            dataGrid.Visible = true;
            dataGrid.ResumeLayout();
        }
    }
}
