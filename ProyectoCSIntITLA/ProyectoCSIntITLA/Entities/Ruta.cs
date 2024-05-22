
using DBBoletoBus.Domain.Core;

namespace DBBoletoBus.Domain.Entities
{
    public sealed class Ruta : AuditableEntity
    {
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }

        public ICollection<Viaje> Viajes { get; set; }
    }
}
