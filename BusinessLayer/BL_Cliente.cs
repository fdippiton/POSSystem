using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Cliente
    {
        private DL_Cliente objdl_Cliente = new DL_Cliente();

        public List<Cliente> ListarClientes()
        {
            return objdl_Cliente.ListarClientes();
        }


    }
}
