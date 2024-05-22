
namespace DBBoletoBus.Domain.Core
{
    public abstract class Person : AuditableEntity
    {
        public string? Nombres {  get; set; }
        public string? Apellidos { get; set; }
        public int IdUsuario { get; set; }

    }
}
