using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{

    [Table("Compras")]
    public class Compra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Com_Id { get; set; }

        [Required]
        public Usuario oCom_Usuario_Id { get; set; }

        [Required]
        public Proveedor oCom_Proveedor_Id { get; set; }

        [StringLength(15)]
        public string Com_Comprobante { get; set; }

        public int? Com_MontoTotal { get; set; }

        [Required]
        public DateTime Com_Fecha { get; set; }

        [Required]
        [StringLength(1)]
        public string Com_Estatus { get; set; }
    }
}
