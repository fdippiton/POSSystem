using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Categoria
    {
        private DL_Categoria objdl_Categoria = new DL_Categoria();

        public List<Categoria> ListarCategorias()
        {
            return objdl_Categoria.ListarCategorias();
        }

        public bool CrearCategoria(Categoria categoria)
        {
            return objdl_Categoria.CrearCategoria(categoria);
        }

        public bool EditarCategoria(Categoria categoria)
        {
            return objdl_Categoria.EditarCategoria(categoria);
        }

        public bool EliminarCategoria(int categoriaId)
        {
            return objdl_Categoria.EliminarCategoria(categoriaId);
        }
    }
}
