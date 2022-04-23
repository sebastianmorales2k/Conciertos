using System.ComponentModel.DataAnnotations;

namespace Conciertos1.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "El campo {} debe tener máximo {1} catacteres")]
        public string Description { get; set; }
    }
}
