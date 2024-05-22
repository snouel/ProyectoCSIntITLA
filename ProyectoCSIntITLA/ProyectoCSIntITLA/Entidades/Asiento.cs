
namespace DBBoletoBus.Domain.Entidades
{
    public sealed class Asiento
    {
        public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Bus Bus { get; set; }
        public ICollection<ReservaDetalle> ReservaDetalles { get; set; }

    }
}
