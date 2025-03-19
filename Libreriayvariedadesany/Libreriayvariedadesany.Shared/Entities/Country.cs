using System.ComponentModel.DataAnnotations;

namespace Libreriayvariedadesany.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} carácter.")]
        public string Name { get; set; } = null!;
    }
}
