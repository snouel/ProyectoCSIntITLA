
namespace DBBoletoBus.Domain.Entidades
{
    public sealed class ReservaDetalle
    {
        public int IdReservaDetalle { get; set; }
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Reserva Reserva { get; set; }
        public Asiento Asiento { get; set; }
    }
}
