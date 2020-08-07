using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Libera_base
{
    public class Cliente
    {

        public int ClienteID { get; set; }
        public string Nome { get; set; }

        public DataTable PreencheComboBox()
        {

            Conexao con = new Conexao();
            con.Conecta();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.CommandText = "Select cli_id, cli_razaosocial from Clientes order by cli_id";
            comm.Connection = Conexao.Conn;
            DataTable dt = new DataTable();
            NpgsqlDataReader dr = comm.ExecuteReader();
            dt.Load(dr);
            Conexao.Desconecta();
            return dt;
        }

        public Boolean ExecutaComando(string sql)
        {
            try
            {
                Conexao con = new Conexao();
                con.Conecta();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.CommandText = sql;
                comm.Connection = Conexao.Conn;
                comm.ExecuteReader();
                Conexao.Desconecta();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public int ExecutaContaLinha(string sql)
        {
            int linhas = 0;
            try
            {
                Conexao con = new Conexao();
                con.Conecta();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.CommandText = sql;
                comm.Connection = Conexao.Conn;
                NpgsqlDataReader data = comm.ExecuteReader();
                while (data.Read())
                {
                    linhas = data.GetInt32(0);
                }

                Conexao.Desconecta();
                return linhas;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return linhas;
            }
        }


    }

}
