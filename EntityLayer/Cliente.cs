using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cli_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Cli_Nombres { get; set; }

        [Required]
        [StringLength(255)]
        public string Cli_Apellidos { get; set; }

        public int? Cli_Telefono { get; set; } // Consider using string if you need to include characters like "+", "-", or spaces.

        [StringLength(255)]
        public string Cli_Email { get; set; }

        [StringLength(255)]
        public string Cli_Direccion { get; set; }

        [Required]
        [StringLength(1)]
        public string Cli_Estatus { get; set; }
    }
}
