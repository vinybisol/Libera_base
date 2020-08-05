﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Libera_base
{
    public class Conexao
    {
        public static NpgsqlConnection Conn { get; set; }
        public static object dbPort { get; set; }
        public static object dbHost { get;  set; }
        public static object dbUser { get;  set; }
        public static object dbPassword { get;  set; }
        public static object dbBanco { get;  set; }


        
        //casa

        private string strConexao = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    dbHost, dbPort, dbUser,
                    dbPassword, dbBanco);

        string strConexao1 = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};",
                    dbHost, dbPort, dbUser,
                    dbPassword, dbBanco);

        
        public void Conecta()
        {
            Conn = new NpgsqlConnection(strConexao1);
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
