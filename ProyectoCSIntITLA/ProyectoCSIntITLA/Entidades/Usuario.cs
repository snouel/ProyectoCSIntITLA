
using DBBoletoBus.Domain.Core;

namespace DBBoletoBus.Domain.Entidades
{
    public sealed class Usuario : Person
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }

        public ICollection<Reserva> Reservas { get; set; }
    }
}
