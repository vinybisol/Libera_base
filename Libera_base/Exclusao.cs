using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libera_base
{
    class Exclusao
    {
        public Boolean ExclusaoNotasEmitidas()
        {
            Cliente cli = new Cliente();
            cli.ExecutaComando("delete from notafiscalemitida where nte_id = 1;");
            bool deuCerto = true;
            return deuCerto;
        }
    }
}
