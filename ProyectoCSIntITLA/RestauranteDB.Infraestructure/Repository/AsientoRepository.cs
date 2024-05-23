using DBBoletoBus.Domain.Entities;
using DBBoletoBus.Domain.Interfaces;
using DBBoletoBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace DBBoletoBus.Infraestructure.Repository
{
    public class AsientoRepository : IAsiento
    {
        private readonly BoletoBusContext DBBoletoBus;

        public AsientoRepository(BoletoBusContext boletoBus)
        {
             
        }
        public Task<Asiento> Get(int idAsiento)
        {
            throw new NotImplementedException();

        }

        public Task<List<Asiento>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Save(Asiento asiento)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Asiento> asientos)
        {
            throw new NotImplementedException();
        }

        public Task Update(Asiento asiento)
        {
            throw new NotImplementedException();
        }
    }
}
