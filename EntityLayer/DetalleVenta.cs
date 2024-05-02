using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("DetallesVenta")]
    public class DetalleVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetV_Id { get; set; }

        [Required]
        public Venta DetV_Venta_Id { get; set; }

        [Required]
        public Producto DetV_Producto_CodigoBarras { get; set; }

        [Required]
        public int DetV_Cantidad { get; set; }

        [Required]
        public decimal DetV_Subtotal { get; set; }

        [Required]
        public decimal DetV_Itbis { get; set; }

        [Required]
        public decimal DetV_Total { get; set; }

        [Required]
        [StringLength(1)]
        public string DetV_Estatus { get; set; }
    }
}
