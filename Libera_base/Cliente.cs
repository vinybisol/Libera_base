using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace Libera_base
{
    public class Cliente
    {

            public int ClienteID { get; set; }
            public string Nome { get; set; }

            public DataTable PreencheComboBox()
            {

            Conexao.Conecta();

                NpgsqlCommand comm = new NpgsqlCommand();
                comm.CommandText = "Select cli_id, cli_razaosocial from Clientes order by cli_id";
                comm.Connection = Conexao.Conn;
                DataTable dt = new DataTable();
                NpgsqlDataReader dr = comm.ExecuteReader();
                dt.Load(dr);
                Conexao.Desconecta();
                return dt;
            }

    }
    
}
