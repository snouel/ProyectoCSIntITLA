
using DBBoletoBus.Domain.Core;

namespace DBBoletoBus.Domain.Entities
{
    public sealed class Usuario : Person
    {
     
        public string TipoUsuario { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}
