using BoletoBus.Api.Model.AsientoModel.AsientoModel;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Domain.Models;
using BoletoBus.Infraestructure.Repository;

namespace BoletoBus.Api.Services.AsientoService
{
    public class AsientoApiService : IAsientoService
    {
        private readonly IAsientoRepository _asientoRepository;
        public AsientoApiService(IAsientoRepository asientoRepository)
        {
            _asientoRepository = asientoRepository;
        }

        public Task AddAsientoAsync(AsientoAddModel asiento)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsientoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AsientoModel> GetAsientoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AsientoModel>> GetAsientosAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsientoAsync(AsientoUpdateModel asiento)
        {
            throw new NotImplementedException();
        }
    }
}
