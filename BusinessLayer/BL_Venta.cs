using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Venta
    {
        private DL_Venta objdl_Venta = new DL_Venta();

        public bool GenerarVenta(Venta venta, List<DetalleVenta> detalleVenta)
        {
            return objdl_Venta.GenerarVenta(venta, detalleVenta);
        }
    }
}
