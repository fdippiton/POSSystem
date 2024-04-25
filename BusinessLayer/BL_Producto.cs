using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Producto
    {
        private DL_Producto objdl_Producto = new DL_Producto();

        public List<Producto> ListarProductos()
        {
            return objdl_Producto.ListarProductos();
        }

        public bool CrearProducto(Producto producto)
        {
            return objdl_Producto.CrearProducto(producto);
        }

        public bool EditarProducto(Producto producto)
        {
            return objdl_Producto.EditarProducto(producto);
        }

        public bool EliminarProducto(int productoId)
        {
            return objdl_Producto.EliminarProducto(productoId);
        }
    }
}
