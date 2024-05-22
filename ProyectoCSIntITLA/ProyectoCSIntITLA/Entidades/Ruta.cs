
namespace DBBoletoBus.Domain.Entidades
{
    public sealed class Ruta
    {
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaCreacion { get; set; }

        public ICollection<Viaje> Viajes { get; set; }
    }
}
