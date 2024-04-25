using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Prod_Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Prod_CodigoBarras { get; set; }

        public string Prod_Barras { get; set; }

        [Required]
        [StringLength(255)]
        public string Prod_Nombre { get; set; }

        public string Prod_Descripcion { get; set; }

        [Required]
        public Categoria oProd_Categoria_Id { get; set; }

        public int? Prod_Itbis { get; set; }

        [Required]
        public DateTime Prod_Fecha { get; set; }
    }
}
