using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("Descuentos")]
    public class Descuento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Des_Id { get; set; }

        [Required]
        public Producto oDes_Producto_Id { get; set; }

        [Required]
        public int Des_Porcentaje_Descuento { get; set; }

        [Required]
        public DateTime Des_FechaInicio { get; set; }

        [Required]
        public DateTime Des_FechaFin { get; set; }

        [Required]
        [StringLength(1)]
        public string Des_Estatus { get; set; }
    }
}
