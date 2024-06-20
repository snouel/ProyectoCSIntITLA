
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Domain.Models;
using System.Linq.Expressions;

namespace BoletoBus.Infraestructure.Repository.Mock
{
    public class AsientoMockRep : IAsientoRepository
    {
        private List<Asiento> asientos;

        public AsientoMockRep()
        {
            this.asientos = new List<Asiento>();
        }

        public Task<bool> Exists(Expression<Func<Asiento, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<Asiento> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Asiento>> GetAll(Expression<Func<Asiento, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<Asiento> GetAsientoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<AsientoModel> GetAsientos()
        {
            throw new NotImplementedException();
        }

        public List<AsientoModel> GetAsientosByBusID(int busId)
        {
            throw new NotImplementedException();
        }

        public List<AsientoModel> GetAsientosYBuses()
        {
            throw new NotImplementedException();
        }

        public Task Save(Asiento entity)
        {
            throw new NotImplementedException();
        }

        public Task Save(List<Asiento> entities)
        {
            throw new NotImplementedException();
        }

        public Task Update(Asiento entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<Asiento> entities)
        {
            throw new NotImplementedException();
        }
    }
}
