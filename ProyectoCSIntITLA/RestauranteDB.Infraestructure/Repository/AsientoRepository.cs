using DBBoletoBus.Domain.Entities;
using DBBoletoBus.Domain.Interfaces;
using DBBoletoBus.Domain.Models;
using DBBoletoBus.Infraestructure.Context;
using DBBoletoBus.Infraestructure.Core;

namespace DBBoletoBus.Infraestructure.Repository
{
    public class AsientoRepository : BaseRepository<Asiento>, IAsientoRepository
    {
        private readonly BoletoBusContext context;
        public AsientoRepository(BoletoBusContext context) : base(context)
        {
            this.context = context;
        }

        public List<AsientoModel> GetAsientos()
        {
            throw new NotImplementedException();
        }

        public List<AsientoModel> GetAsientosByBus(int busId)
        {
            throw new NotImplementedException();
        }
    }
}
