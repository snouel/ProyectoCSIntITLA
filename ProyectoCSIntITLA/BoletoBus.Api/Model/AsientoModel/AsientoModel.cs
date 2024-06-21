using BoletoBus.Api.Model.BusModel;
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Models;

namespace BoletoBus.Api.Model.AsientoModel
{
    public class AsientoApiModel
    {
        public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
       
        public Asiento ConvertToEntityAsiento()
        {
            return new Asiento
            {
                IdAsiento = this.IdAsiento,
                IdBus = this.IdBus,
                NumeroPiso = this.NumeroPiso,
                NumeroAsiento = this.NumeroAsiento,
            };
        }
    }
}
