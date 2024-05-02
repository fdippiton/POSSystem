using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("Ventas")]
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ven_Id { get; set; }

        [Required]
        public Cliente Ven_Cliente_Id { get; set; }

        [Required]
        public int Ven_Usuario_Id { get; set; }

        [Required]
        public DateTime Ven_Fecha { get; set; }

        [Required]
        public decimal Ven_TotalItbis { get; set; }

        [Required]
        public decimal Ven_MontoTotal { get; set; }

        [Required]
        [StringLength(1)]
        public string Ven_Estatus { get; set; }
    }
}
