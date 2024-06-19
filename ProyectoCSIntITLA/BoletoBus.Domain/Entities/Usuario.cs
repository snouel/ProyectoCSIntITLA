
using BoletoBus.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace BoletoBus.Domain.Entities
{
    public class Usuario : Person
    {
        [Key]
        public string TipoUsuario { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}
