namespace BoletoBus.Domain.Core
{
    public abstract class AuditableEntity
    {
        protected AuditableEntity()
        {
            FechaCreacion = DateTime.Now;
            Eliminado = false;
        }

        public string CreacionUsuario { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string? ModUsuario { get; set; }

        public string? UserEliminado { get; set; }

        public DateTime? FechaEliminacion { get; set; }

        public bool Eliminado { get; set; }

    }
}
