

using DBBoletoBus.Domain.Entities;

namespace DBBoletoBus.Domain.Interfaces
{
    public interface IRuta
    {
        Task Save(Ruta ruta);
        Task Save(List<Ruta> rutas);
        Task Update(Ruta ruta);
        Task<Ruta> Get(int idRuta);
        Task<List<Ruta>> GetAll();
    }
}
