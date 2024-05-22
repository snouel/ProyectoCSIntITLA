

using DBBoletoBus.Domain.Entities;

namespace DBBoletoBus.Domain.Interfaces
{
    public interface IBus
    {
        Task Save(Bus bus);
        Task Save(List<Bus> buses);
        Task Update(Bus bus);
        Task<Bus> Get(int idBus);
        Task<List<Bus>> GetAll();
    }
}
