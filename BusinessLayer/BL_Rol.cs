using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Rol
    {
        private DL_Rol objdl_Rol = new DL_Rol();

        public List<Rol> Listar()
        {
            return objdl_Rol.ListarRoles();
        }
    }
}
