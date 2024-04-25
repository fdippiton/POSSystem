using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cat_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Cat_Nombre { get; set; }

        [Required]
        [StringLength(1)]
        public string Cat_Estatus { get; set; }
    }
}
