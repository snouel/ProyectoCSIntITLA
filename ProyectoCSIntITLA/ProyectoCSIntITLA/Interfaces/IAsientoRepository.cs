

using DBBoletoBus.Domain.Core;
using DBBoletoBus.Domain.Entities;
using DBBoletoBus.Domain.Models;

namespace DBBoletoBus.Domain.Interfaces
{
    public interface IAsientoRepository : IBaseRepository<Asiento>
    {
       List<AsientoModel> GetAsientos();
    }
}
