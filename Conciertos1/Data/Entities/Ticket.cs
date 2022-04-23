using System.ComponentModel.DataAnnotations;

namespace Conciertos1.Data.Entities
{
    public class Ticket
    {

        public int Id { get; set; }
        public bool WasUsed { get; set; }

        [MaxLength(20)]
        public string Document { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {} debe tener máximo {1} catacteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio}")]
        public string Name { get; set; }
        public Entrance Entrance { get; set; }
        public DateTime Date { get; set; }

    }
}
