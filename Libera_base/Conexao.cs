using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Libera_base
{
    class Conexao
    {
        public string dbHost = "localhost";
        public string dbPorta = "5432";
        public string dbUsuario = "postgres";
        public string dbSenha = "181271";
        public string dbBase = "dbposto";

        public object conexao(string sql)
        {
            string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    dbHost, dbPorta, dbUsuario,
                    dbSenha, dbBase);
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            NpgsqlCommand retorno = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader retPronto = retorno.ExecuteReader();
            //conn.Close();
            return retPronto;
        }

    }
}
