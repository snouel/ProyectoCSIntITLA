
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Domain.Models;
using BoletoBus.Infraestructure.Context;
using BoletoBus.Infraestructure.Core;
using BoletoBus.Infraestructure.Exceptions;
using System.Linq.Expressions;

namespace BoletoBus.Infraestructure.Repository
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        private readonly BusTicketContext context;
        public ReservaRepository(BusTicketContext context) : base(context)
        {
            this.context = context;
        }

        public override async Task Save(Reserva entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad Reserva no debe ser nula.");
            }
            //if (await base.Exists(cd => cd.IdBus == entity.IdBus))
            //{

            //}

            await base.Save(entity);
        }

        public override Task Update(Reserva entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad Reserva no debe ser nula.");
            }

            return base.Update(entity);
        }

        public override Task Update(List<Reserva> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad Reserva no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new ReservaDataException("Debe proporcionar por lo menos un numero de Reserva");
            }
            return base.Update(entities);
        }

        public override Task Save(List<Reserva> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad Reserva no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new ReservaDataException("Debe proporcionar por lo menos un numero de Reserva");
            }
            return base.Save(entities);
        }

        public override Task<List<Reserva>> GetAll(Expression<Func<Reserva, bool>> filter)
        {
            return base.GetAll(filter);
        }

        public override Task<Reserva> Get(int Id)
        {
            return base.Get(Id);
        }

        public List<ReservaModel> GetReserva()
        {
            throw new NotImplementedException();
        }
    }
}
