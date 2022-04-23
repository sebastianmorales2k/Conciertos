using System.ComponentModel.DataAnnotations;

namespace Conciertos1.Data.Entities
{
    public class Entrance
    {
        [Required(ErrorMessage ="el campo {0} es obligatorio")]
        [Display(Name = "# de Ticket")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} catacteres")]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
