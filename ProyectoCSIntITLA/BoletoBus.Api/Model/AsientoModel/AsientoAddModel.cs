using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Models;

namespace BoletoBus.Api.Model.AsientoModel.AsientoModel
{
    public class AsientoAddModel
    {
        public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
        public string CreacionUsuario { get; set; }

        public DateTime FechaCreacion { get; set; }

        public Asiento ConvertToEntityAsiento()
        {
            return new Asiento
            {
                IdAsiento = this.IdAsiento,
                IdBus = this.IdBus,
                NumeroPiso = this.NumeroPiso,
                NumeroAsiento = this.NumeroAsiento,
                FechaCreacion = DateTime.Now,
                CreacionUsuario = this.CreacionUsuario
            };
        }
    }
}
