using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class DetalleCompra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetC_Id { get; set; }

        [Required]
        public Compra oDetC_Compra_Id { get; set; }

        [Required]
        public Producto oDetC_Producto_Id { get; set; }

        [Required]
        public int DetC_CantidadInicial { get; set; }

        [Required]
        public int DetC_CantidadActual { get; set; }

        [Required]
        public int DetC_PrecioCompraUnidad { get; set; }

        [Required]
        public int DetC_PrecioVentaUnidad { get; set; }

        [Required]
        public int DetC_ValorInventarioInicial { get; set; }

        [Required]
        public int DetC_ValorInventarioActual { get; set; }
    }
}
