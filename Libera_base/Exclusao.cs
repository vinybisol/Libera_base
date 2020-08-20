using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libera_base
{
    public class Exclusao
    {
        public string data { get; set; }
        int linhas = 1;
        int idExcluir = 0;
        Cliente Log = new Cliente();
        Conexao con = new Conexao();

        public Boolean ExclusaoNotasEmitidas()
        { 
            Cliente cli = new Cliente();
            Form1 form = new Form1();
            form.progressBar.Maximum = 0;
            data = form.maskedData.Text;
            while (linhas >= 0 )
            {
                //Contas as linhas na data definida
                linhas = cli.ExecutaContaLinha("select count(nte_id) from notafiscalemitida where nte_emissao = '" + data + "';");

                //Define o maximo de linhas para barra de progresso
                form.progressBar.Maximum = linhas; 
                //Define o Id para ser excluído
                idExcluir = cli.ExecutaContaLinha("select min(nte_id) from notafiscalemitida where nte_emissao = '" + data + "';");

                //Deleta a Linha
                cli.ExecutaComando("delete from notafiscalemitida where nte_id = " + idExcluir + ";");


                //Valida Numero de linhas
                if (linhas == 0) { 
                    con.Desconecta(); 
                    break; 
                };
                //Valida barra de progresso
                if(form.progressBar.Value == form.progressBar.Maximum){ 
                    con.Desconecta(); 
                    break; 
                } else { form.progressBar.Value++; }
                //Valida botao cancelamento
                if(form.cancelamento == true) { 
                    con.Desconecta(); 
                    break;  }
                
            }

            return true;
        }
    }
}
