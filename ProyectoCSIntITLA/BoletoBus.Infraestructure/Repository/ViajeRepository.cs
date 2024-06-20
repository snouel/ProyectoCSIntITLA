using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Context;
using BoletoBus.Infraestructure.Core;
using BoletoBus.Infraestructure.Exceptions;
using System.Linq.Expressions;

namespace BoletoBus.Infraestructure.Repository
{
    public class ViajeRepository : BaseRepository<Viaje>, IViajeRepository
    {
        private readonly BusTicketContext context;
        public ViajeRepository(BusTicketContext context) : base(context)
        {
            this.context = context;
        }

        public override async Task Save(Viaje entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad Viaje no debe ser nula.");
            }
            //if (await base.Exists(cd => cd.IdBus == entity.IdBus))
            //{

            //}

            await base.Save(entity);
        }

        public override Task Update(Viaje entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad Viaje no debe ser nula.");
            }

            return base.Update(entity);
        }

        public override Task Update(List<Viaje> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad Viaje no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new ViajeDataException("Debe proporcionar por lo menos un numero de Viaje");
            }
            return base.Update(entities);
        }

        public override Task Save(List<Viaje> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad Viaje no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new ViajeDataException("Debe proporcionar por lo menos un numero de Viaje");
            }
            return base.Save(entities);
        }

        public override Task<List<Viaje>> GetAll(Expression<Func<Viaje, bool>> filter)
        {
            return base.GetAll(filter);
        }

        public override Task<Viaje> Get(int Id)
        {
            return base.Get(Id);
        }

        public List<Viaje> GetViaje()
        {
            throw new NotImplementedException();
        }
    }
}