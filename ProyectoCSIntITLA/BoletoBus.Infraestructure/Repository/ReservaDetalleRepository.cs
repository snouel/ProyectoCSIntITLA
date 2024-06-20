using BoletoBus.Domain.Core;
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Domain.Models;
using BoletoBus.Infraestructure.Context;
using BoletoBus.Infraestructure.Core;
using BoletoBus.Infraestructure.Exceptions;
using System.Linq.Expressions;

namespace BoletoBus.Infraestructure.Repository
{
    public class ReservaDetalleRepository : BaseRepository<ReservaDetalle>, IReservaDetalleRepository
    {
        private readonly BusTicketContext context;
        public ReservaDetalleRepository(BusTicketContext context) : base(context)
        {
            this.context = context;
        }

        public override async Task Save(ReservaDetalle entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad ReservaDetalle no debe ser nula.");
            }
            //if (await base.Exists(cd => cd.IdBus == entity.IdBus))
            //{

            //}

            await base.Save(entity);
        }

        public override Task Update(ReservaDetalle entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad ReservaDetalle no debe ser nula.");
            }

            return base.Update(entity);
        }

        public override Task Update(List<ReservaDetalle> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad ReservaDetalle no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new ReservaDetalleDataException("Debe proporcionar por lo menos un numero de ReservaDetalle");
            }
            return base.Update(entities);
        }

        public override Task Save(List<ReservaDetalle> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad ReservaDetalle no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new ReservaDetalleDataException("Debe proporcionar por lo menos un numero de ReservaDetalle");
            }
            return base.Save(entities);
        }

        public override Task<List<ReservaDetalle>> GetAll(Expression<Func<ReservaDetalle, bool>> filter)
        {
            return base.GetAll(filter);
        }

        public override Task<ReservaDetalle> Get(int Id)
        {
            return base.Get(Id);
        }

        public List<ReservaDetalleModel> GetReservaDetalle()
        {
            throw new NotImplementedException();
        }
    }
}