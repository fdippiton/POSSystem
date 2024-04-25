using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Usuario
    {
        private DL_Usuario objdl_Usuario = new DL_Usuario();

        public List<Usuario> Listar()
        {
            return objdl_Usuario.ListarUsuarios();
        }

        public bool AgregarUsuario(Usuario usuario)
        {
            return objdl_Usuario.CrearUsuario(usuario);
        }

        public bool EditarUsuario(Usuario usuario)
        {
            return objdl_Usuario.EditarUsuario(usuario);
        }


        public bool EliminarUsuario(int usuarioId)
        {
            return objdl_Usuario.EliminarUsuario(usuarioId);
        }

        public bool VerificarDocumentoExistente(string documento)
        {
            return objdl_Usuario.VerificarDocumentoExistente(documento);
        }
    }
}
