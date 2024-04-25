using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Permiso
    {
        private DL_Permiso objdl_Permiso = new DL_Permiso();

        public List<Permiso> Listar(int idUsuario)
        {
            return objdl_Permiso.ListarPermisos(idUsuario);
        }
    }
}
