using BoletoBus.Domain.Core;
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Models;

namespace BoletoBus.Domain.Interfaces
{
    public interface IBusRepository : IBaseRepository<Bus>
    {
        List<BusModel> GetBus();
        List<BusModel> GetBusByIdAsync();



    }
}
