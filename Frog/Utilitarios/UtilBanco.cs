using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frog.Utilitarios
{
    public class UtilBanco
    {
        public void AbrirConexaoComBancoDeDados(OracleConnection conn)
        {
            FecharConexaoComBancoDeDados(conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void FecharConexaoComBancoDeDados(OracleConnection conn)
        {
            if (conn == null)
                return;

            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public int RecuperarQuantidadeRegistrosDaQuery(OracleConnection conn, string query)
        {
            var queryQuantidade = $"select count(*) from ( {query} )";

            var command = new OracleCommand(queryQuantidade, conn);
            var reader = command.ExecuteReader();

            reader.Read();

            return Convert.ToInt32(reader.GetValue(0));
        }

        public OracleDataReader RecuperarColunasCabecalhoDaGrid(OracleConnection conn, string query)
        {
            var queryQuantidade = $"select * from ( {query} ) where rownum = 1";

            var command = new OracleCommand(queryQuantidade, conn);
            return command.ExecuteReader();
        }

        public void IdentificaTipoObjeto(OracleConnection conn, string nome)
        {
            AbrirConexaoComBancoDeDados(conn);

            var query = $@"SELECT object_type
                            FROM user_objects
                           where object_name = '{nome.ToUpper().Trim()}'";

            var command = new OracleCommand(query, conn);
            var reader = command.ExecuteReader();

            reader.Read();
            var tipo = string.Empty;

            try
            {
                var valor = reader.GetValue(0);
                tipo = valor.ToString();
            }
            catch (Exception)
            {
                return;
            }

            if (tipo.ToUpper().Trim().Equals("TABLE"))
            {
                var window = new WinTabela(conn, nome.ToUpper().Trim());
                window.Show();
            }
            else
            {
                var window = new WinObjetos(conn, nome.ToUpper().Trim(), tipo.ToUpper().Trim());
                window.Show();
            }            

            FecharConexaoComBancoDeDados(conn);
        }

        public string RecuperarSourceObjeto(OracleConnection conn, string nome, string tipo)
        {
            AbrirConexaoComBancoDeDados(conn);

            var query = $@"select text
                             from user_SOURCE 
                            where name = '{nome.ToUpper().Trim()}'
                              and type = '{tipo.ToUpper().Trim()}'";

            var command = new OracleCommand(query, conn);
            var reader = command.ExecuteReader();

            StringBuilder codigo = new StringBuilder();
            while (reader.Read())
            {
                codigo.Append(reader.GetString(0));
            }

            FecharConexaoComBancoDeDados(conn);

            return codigo.ToString();
        }
    }
}
