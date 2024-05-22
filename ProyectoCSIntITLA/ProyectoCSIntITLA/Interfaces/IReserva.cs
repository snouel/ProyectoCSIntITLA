

using DBBoletoBus.Domain.Entities;

namespace DBBoletoBus.Domain.Interfaces
{
    public interface IReserva
    {
        Task Save(Reserva reserva);
        Task Save(List<Reserva> reservas);
        Task Update(Reserva reserva);
        Task<Reserva> Get(int idReserva);
        Task<List<Reserva>> GetAll();
    }
}
