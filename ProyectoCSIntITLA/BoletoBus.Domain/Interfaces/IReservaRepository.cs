using BoletoBus.Domain.Core;
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Models;

namespace BoletoBus.Domain.Interfaces
{
    public interface IReservaRepository : IBaseRepository<Reserva>
    {
        List<ReservaModel> GetReserva();

    }
}
