using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("Permisos")]
    public class Permiso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Per_Id { get; set; }
        public Rol oRol_Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Per_Nombre { get; set; }
        [Required]
        [StringLength(1)]
        public string Per_Estatus { get; set; }
    }
}
