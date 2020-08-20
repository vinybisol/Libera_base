using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Libera_base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao.dbHost = textBox1.Text.ToString();
            Conexao.dbUser = textBox2.Text.ToString();
            Conexao.dbPassword = textBox3.Text.ToString();
            Conexao.dbBanco = textBox4.Text.ToString();
            Conexao.dbPort = textBox5.Text.ToString();

            Cliente cli1 = new Cliente();


            var data = cli1.PreencheComboBox();
            dataGridView1.DataSource = data;
            dataGridView1.Columns[1].Visible = true;


            dataGridView1.Columns[1].HeaderText = "Cliente";

          
        }


        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (checkAbastecidas.Checked == true)
            {
                MessageBox.Show("Abastecidas!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Conexao.dbHost = textBox1.Text.ToString();
            Conexao.dbUser = textBox2.Text.ToString();
            Conexao.dbPassword = textBox3.Text.ToString();
            Conexao.dbBanco = textBox4.Text.ToString();
            Conexao.dbPort = textBox5.Text.ToString();


            Exclusao ex = new Exclusao();
            ex.data = "2020-01-01";
            ex.ExclusaoNotasEmitidas();


        }
    }
}
