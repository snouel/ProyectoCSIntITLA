
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Context;
using BoletoBus.Infraestructure.Core;
using BoletoBus.Infraestructure.Exceptions;
using System.Linq.Expressions;

namespace BoletoBus.Infraestructure.Repository
{
    public class RutaRepository : BaseRepository<Ruta>, IRutaRepository
    {
        private readonly BusTicketContext context;
        public RutaRepository(BusTicketContext context) : base(context)
        {
            this.context = context;
        }

        public override async Task Save(Ruta entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad Ruta no debe ser nula.");
            }
            //if (await base.Exists(cd => cd.IdBus == entity.IdBus))
            //{

            //}

            await base.Save(entity);
        }

        public override Task Update(Ruta entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad Ruta no debe ser nula.");
            }

            return base.Update(entity);
        }

        public override Task Update(List<Ruta> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad Ruta no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new RutaDataException("Debe proporcionar por lo menos un numero de Ruta");
            }
            return base.Update(entities);
        }

        public override Task Save(List<Ruta> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad Ruta no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new RutaDataException("Debe proporcionar por lo menos un numero de Ruta");
            }
            return base.Save(entities);
        }

        public override Task<List<Ruta>> GetAll(Expression<Func<Ruta, bool>> filter)
        {
            return base.GetAll(filter);
        }

        public override Task<Ruta> Get(int Id)
        {
            return base.Get(Id);
        }

        public List<Ruta> GetRuta()
        {
            throw new NotImplementedException();
        }
    }
}
