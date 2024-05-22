
using DBBoletoBus.Domain.Core;

namespace DBBoletoBus.Domain.Entities
{
    public sealed class Usuario : Person
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}
