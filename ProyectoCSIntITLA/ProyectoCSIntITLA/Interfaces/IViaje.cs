using DBBoletoBus.Domain.Entities;

namespace DBBoletoBus.Domain.Interfaces
{
    public interface IViaje
    {
        Task Save(Viaje viaje);
        Task Save(List<Viaje> viajes);
        Task Update(Viaje viaje);
        Task<Viaje> Get(int idViaje);
        Task<List<Viaje>> GetAll();
    }
}
