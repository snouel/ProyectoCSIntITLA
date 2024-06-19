
using BoletoBus.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace BoletoBus.Domain.Entities
{
    public sealed class Ruta : AuditableEntity
    {
        [Key]
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }

        public ICollection<Viaje> Viajes { get; set; }
    }
}
