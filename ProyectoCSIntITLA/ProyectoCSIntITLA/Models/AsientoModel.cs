
using DBBoletoBus.Domain.Entities;

namespace DBBoletoBus.Domain.Models
{
    public class AsientoModel
    {
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public BusModel Bus { get; set; }
        public ICollection<ReservaDetalleModel> ReservaDetalles { get; set; }
    }
}
