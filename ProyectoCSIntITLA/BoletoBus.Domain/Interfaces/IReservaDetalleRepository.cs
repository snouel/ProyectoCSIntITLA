using BoletoBus.Domain.Core;
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Models;

namespace BoletoBus.Domain.Interfaces
{
    public interface IReservaDetalleRepository : IBaseRepository<ReservaDetalle>
    {
        List<ReservaDetalleModel> GetReservaDetalle();

    }
}
