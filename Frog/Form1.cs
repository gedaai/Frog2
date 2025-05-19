using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace Frog
{
    public partial class Form1 : Form
    {
        OracleConnection _conn = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            var stringConexao = txtConexaoBanco.Text;


            _conn = new OracleConnection(stringConexao);

            _conn.Open();
            _conn.Close();

            btnExecutar.Enabled = true;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var primeiroRegistro = true;
            var linha = 0;

            if (_conn == null)
            {
                //throw new Exception("Não conectado");
                return;
            }

            try
            {
                _conn.Open();
            }
            catch (Exception)
            {
                return;
            }            

            txtGrid.Rows.Clear();
            txtGrid.Columns.Clear();

            var consulta = txtArea.Text;
            var query = consulta;

            var queryQuantidade = "select count(*) from ( " + query + ")";
            var command = new OracleCommand(queryQuantidade, _conn);
            var reader = command.ExecuteReader();
            reader.Read();
            var qtdeLinhas = Convert.ToInt32(reader.GetValue(0));

            var queryCabeçalho = "select * from ( " + query + ") where rownum = 1";
            command = new OracleCommand(queryCabeçalho, _conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Montagem das colunas de cabeçalho
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    txtGrid.Columns.Add("Coluna_" + i, reader.GetName(i));
                }
                break;
            }

            txtGrid.Rows.Add(qtdeLinhas - 1);

            command = new OracleCommand(query, _conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    txtGrid.Rows[linha].Cells[i].Value = reader.GetValue(i);
                }

                linha++;
            }

            _conn.Close();
        }

        private void txtArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                btnExecutar_Click(sender, e);

                // Evita que o som de "ding" aconteça ao pressionar F9
                e.SuppressKeyPress = true;
            }
        }
    }
}
