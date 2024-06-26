using BoletoBus.Api.Model.AsientoModel.AsientoModel;
using BoletoBus.Domain.Models;

namespace BoletoBus.Api.Services.AsientoService
{
    public interface IAsientoService
    {
        Task<IEnumerable<AsientoModel>> GetAsientosAsync();
        Task<AsientoModel> GetAsientoByIdAsync(int id);
        Task AddAsientoAsync(AsientoAddModel asiento);
        Task UpdateAsientoAsync(AsientoUpdateModel asiento);
        Task DeleteAsientoAsync(int id);
    }
}
