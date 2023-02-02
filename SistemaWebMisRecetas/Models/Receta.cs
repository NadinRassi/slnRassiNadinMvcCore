using SistemaWebMisRecetas.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebMisRecetas.Models
{
    [Table("Receta")]
    public class Receta
    {

        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Titulo { get; set; }

        [Required]
        [CategoriaDesayuno]
        [Column(TypeName = "varchar(50)")]
        public string Categoria { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Autor { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        [EdadMayorA18]
        [Required]
        public int Edad { get; set; }

        [Required]
        [RegularExpression(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$")]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

    }
}
