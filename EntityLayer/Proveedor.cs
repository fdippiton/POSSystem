using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("Proveedores")]
    public class Proveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Prov_Id { get; set; }
        [MaxLength(255)]
        public string Prov_RazonSocial { get; set; }
        [Required]
        [MaxLength(255)]
        public string Prov_Nombre { get; set; }
        [MaxLength(255)]
        public string Prov_Correo { get; set; }
        [MaxLength(15)]
        public string Prov_Telefono { get; set; }
        [Required]
        public DateTime Prov_FechaCreacion { get; set; }
        [Required]
        [MaxLength(1)]
        public string Prov_Estatus { get; set; }
    }
}
