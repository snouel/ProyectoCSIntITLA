using BoletoBus.Domain.Entities;

namespace BoletoBus.Api.Model.AsientoModel.AsientoModel
{
    public class AsientoUpdateModel
    {
        public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }

        public DateTime? FechaModificacion { get; set; }
        public string? ModUsuario { get; set; }

        public Asiento ConvertToEntityAsiento()
        {
            return new Asiento
            {
                IdAsiento = this.IdAsiento,
                IdBus = this.IdBus,
                NumeroPiso = this.NumeroPiso,
                NumeroAsiento = this.NumeroAsiento,
                FechaModificacion = this.FechaModificacion,
                ModUsuario = this.ModUsuario
            };
        }

    }
}
