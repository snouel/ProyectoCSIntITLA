
using BoletoBus.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace BoletoBus.Domain.Entities
{
    public sealed class ReservaDetalle : AuditableEntity
    {
        [Key]
        public int IdReservaDetalle { get; set; }
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; }

        public Reserva Reserva { get; set; }
        public Asiento Asiento { get; set; }
    }
}
