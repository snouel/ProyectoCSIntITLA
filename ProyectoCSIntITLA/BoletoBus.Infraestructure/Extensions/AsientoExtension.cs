using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Models;

namespace BoletoBus.Infraestructure.Extensions
{
    public static class AsientoExtension
    {
        public static AsientoModel ConvertAsientoEntitytoAsientoModel(this Asiento asiento)
        {
            AsientoModel asientoModel = new AsientoModel()
            {
                IdAsiento = asiento.IdAsiento,
                IdBus = asiento.IdBus,
                NumeroPiso = asiento.NumeroPiso,
                NumeroAsiento = asiento.NumeroAsiento
            };

            return asientoModel;

        }
    }
}
