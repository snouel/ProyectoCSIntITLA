
namespace DBBoletoBus.Domain.Core
{
    public abstract class AuditableEntity
    {
        public DateTime FechaCreacion { get; set; }
        public string CreacionUsuario { get; set; }
        public string? ModUsuario { get; set; }
     
    }
}
