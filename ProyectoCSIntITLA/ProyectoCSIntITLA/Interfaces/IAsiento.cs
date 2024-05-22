

using DBBoletoBus.Domain.Entities;

namespace DBBoletoBus.Domain.Interfaces
{
    public interface IAsiento
    {
        Task Save(Asiento asiento);
        Task Save(List<Asiento> asientos);
        Task Update(Asiento asiento);
        Task<Asiento> Get(int idAsiento);
        Task<List<Asiento>> GetAll();
    }
}
