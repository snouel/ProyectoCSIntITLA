
using DBBoletoBus.Domain.Entities;

namespace DBBoletoBus.Domain.Models
{
    public class AsietoModel
    {
        public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public Bus Bus { get; set; }
        public ICollection<ReservaDetalle> ReservaDetalles { get; set; }
    }
}
