using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frog.Utilitarios
{
    public class UtilGrid
    {
        public void LimparGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();
        }

        public void AdicionarColunaCabecalho(DataGridView dataGrid, DataGridViewColumn[] colunas)
        {
            dataGrid.Columns.AddRange(colunas);
        }

        public void AdicionarLinhasNaGrid(DataGridView dataGrid, int qtdeLinhas)
        {
            if (qtdeLinhas > 1)
                dataGrid.Rows.Add(qtdeLinhas - 1);
        }

        public void AdicionarDadosNaGrid(DataGridView dataGrid, OracleDataReader reader)
        {
            var linha = 0;

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dataGrid.Rows[linha].Cells[i].Value = reader.GetValue(i);
                }

                linha++;
            }
        }
    }
}
