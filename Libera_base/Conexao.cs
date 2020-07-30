using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.SqlClient;
using System.Data;


namespace Libera_base
{
    public class Conexao
    {
        public string dbHost = "localhost";
        public string dbPorta = "5432";
        public string dbUsuario = "postgres";
        public string dbSenha = "181271";
        public string dbBase = "dbposto";

        private static string strConexao = "Server=localhost;Port=5432;User Id=postgres;Password=181271;Database=dbapanhador;";
        public static NpgsqlConnection Conn { get; set; }
        public static void Conecta()
        {
            Conn = new NpgsqlConnection(strConexao);
            Conn.Open();

        }


        public static void Desconecta()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

    }
}
