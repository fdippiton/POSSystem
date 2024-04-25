using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Usu_Id { get; set; }
        public Rol oRol_Id { get; set; }
        // [Required]
        [StringLength(10)]
        public string Usu_Documento { get; set; }
        // [Required]
        [StringLength(255)]
        public string Usu_NombreCompleto { get; set; }
        // [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Usu_Correo { get; set; }
        // [Required]
        [StringLength(15)]
        public string Usu_Contrasena { get; set; }

        // [Required]
        public DateTime Usu_FechaCreacion { get; set; }

        // [Required]
        [StringLength(1)]
        public string Usu_Estatus { get; set; }

    }
}
