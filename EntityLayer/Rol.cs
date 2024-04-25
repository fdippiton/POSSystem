using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    [Table("Roles")]
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Rol_Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Rol_Descripcion { get; set; }
        [Required]
        [StringLength(1)]
        public string Rol_Estatus { get; set; }
    }
}
