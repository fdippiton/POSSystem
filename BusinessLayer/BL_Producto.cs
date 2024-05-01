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

        public List<Producto> ListarProductos(string estatus)
        {
            return objdl_Producto.ListarProductos(estatus);
        }

        public bool CrearProducto(Producto producto)
        {
            return objdl_Producto.CrearProducto(producto);
        }

        public bool EditarProducto(Producto producto)
        {
            return objdl_Producto.EditarProducto(producto);
        }

        public bool EliminarProducto(string productoCod)
        {
            return objdl_Producto.EliminarProducto(productoCod);
        }

        public bool InactivarProducto(Producto producto)
        {
            return objdl_Producto.InactivarProducto(producto);
        }

        public bool VaciarRegistros()
        {
            return objdl_Producto.VaciarRegistros();
        }

        public Producto BuscarProducto(string codigoBarras)
        {
            return objdl_Producto.BuscarProducto(codigoBarras);
        }
    }
}
