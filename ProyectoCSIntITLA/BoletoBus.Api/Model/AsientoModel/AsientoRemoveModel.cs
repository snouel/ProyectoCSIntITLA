using BoletoBus.Domain.Entities;

namespace BoletoBus.Api.Model.AsientoModel.AsientoModel
{
    public class AsientoRemoveModel
    {
        public int IdAsiento { get; set; }

        public string? UserEliminado { get; set; }

        public DateTime? FechaEliminacion { get; set; }

        public bool Eliminado { get; set; }

        public Asiento ConvertToEntityAsiento()
        {
            return new Asiento
            {
               IdAsiento = this.IdAsiento,
               UserEliminado = this.UserEliminado,
               FechaEliminacion = this.FechaEliminacion,
               Eliminado = this.Eliminado
            };
        }
    }
}
