using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libera_base
{
    public class Exclusao
    {
        public string data { get; set; }
        int linhas = 0;
        public Boolean ExclusaoNotasEmitidas()
        {
            Cliente cli = new Cliente();
            linhas = cli.ExecutaContaLinha("select count(nte_id) from notafiscalemitida where nte_emissao = '" + data + "'");
            while (linhas >= 0)
            {
                cli.ExecutaComando("delete from notafiscalemitida where nte_id = 1;");
                linhas = cli.ExecutaContaLinha("select count(nte_id) from notafiscalemitida where nte_emissao = '" + data + "'");
                MessageBox.Show(linhas.ToString());
                if (linhas == 0) { break; };
            }

            return true;
        }
    }
}
