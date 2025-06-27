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
    public static class UtilBanco
    {
        public static OracleConnection _conn = null;

        public static void AbrirConexaoComBancoDeDados()
        {
            FecharConexaoComBancoDeDados();

            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
                _conn.AutoCommit = false;
            }
        }

        public static void FecharConexaoComBancoDeDados()
        {
            if (_conn == null)
                return;

            if (_conn.State != ConnectionState.Closed)
            {
                _conn.Close();
            }
        }

        public static void Commit()
        {
            _conn.Commit();
        }

        public static void Rollback()
        {
            _conn.Rollback();
        }

        public static int RecuperarQuantidadeRegistrosDaQuery(string query)
        {
            var queryQuantidade = $"select count(*) from ( {query} )";

            var command = new OracleCommand(queryQuantidade, _conn);
            var reader = command.ExecuteReader();

            reader.Read();

            return Convert.ToInt32(reader.GetValue(0));
        }

        public static OracleDataReader RecuperarColunasCabecalhoDaGrid(string query)
        {
            var queryQuantidade = $"select * from ( {query} ) where rownum = 1";

            var command = new OracleCommand(queryQuantidade, _conn);
            return command.ExecuteReader();
        }

        public static void IdentificaTipoObjeto(string nome)
        {
            var query = $@"SELECT object_type
                            FROM user_objects
                           where object_name = '{nome.ToUpper().Trim()}'";

            var command = new OracleCommand(query, _conn);
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
                var window = new WinTabela(_conn, nome.ToUpper().Trim());
                window.Show();
            }
            else
            {
                var window = new WinObjetos(_conn, nome.ToUpper().Trim(), tipo.ToUpper().Trim());
                window.Show();
            }            
        }

        public static string RecuperarSourceObjeto(string nome, string tipo)
        {
            var query = string.Empty;

            if (tipo == "VIEW")
                query = $@"select text
                             from user_views
                            where view_name = '{nome.ToUpper().Trim()}'";
            else
                query = $@"select text
                             from user_SOURCE 
                            where name = '{nome.ToUpper().Trim()}'
                              and type = '{tipo.ToUpper().Trim()}'";

            var command = new OracleCommand(query, _conn);
            var reader = command.ExecuteReader();

            StringBuilder codigo = new StringBuilder();
            while (reader.Read())
            {
                codigo.Append(reader.GetString(0));
            }

            return codigo.ToString();
        }
    }
}
