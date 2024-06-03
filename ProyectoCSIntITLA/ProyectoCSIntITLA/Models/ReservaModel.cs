
namespace DBBoletoBus.Domain.Models
{
    public class ReservaModel
    {
        public int IdReserva { get; set; }
        public int IdViaje { get; set; }
        public int IdPasajero { get; set; }
        public int AsientosReservados { get; set; }
        public decimal MontoTotal { get; set; }
        public Viaje Viaje { get; set; }
        public Usuario Pasajero { get; set; }
        public ICollection<ReservaDetalleModel> ReservaDetalles { get; set; }
    }
}
