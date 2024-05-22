

using DBBoletoBus.Domain.Entities;

namespace DBBoletoBus.Domain.Interfaces
{
    public interface IReservaDetalle
    {
        Task Save(ReservaDetalle reservaDetalle);
        Task Save(List<ReservaDetalle> reservaDetalles);
        Task Update(ReservaDetalle reservaDetalleasiento);
        Task<ReservaDetalle> Get(int idReservaDetalle);
        Task<List<ReservaDetalle>> GetAll();
    }
}
