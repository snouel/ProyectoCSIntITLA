using BoletoBus.Domain.Core;
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Domain.Models;
using BoletoBus.Infraestructure.Context;
using BoletoBus.Infraestructure.Core;
using BoletoBus.Infraestructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace BoletoBus.Infraestructure.Repository
{
    public class BusRepository : BaseRepository<Bus>, IBusRepository
    {
        private readonly BusTicketContext context;
        public BusRepository(BusTicketContext context) : base(context)
        {
            this.context = context;
        }


        public override async Task Save(Bus entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad Bus no debe ser nula.");
            }
            //if (await base.Exists(cd => cd.IdBus == entity.IdBus))
            //{

            //}

            await base.Save(entity);
        }

        public override Task Update(Bus entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad Bus no debe ser nula.");
            }

            return base.Update(entity);
        }

        public override Task Update(List<Bus> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad Bus no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new BusDataException("Debe proporcionar por lo menos un numero de Bus");
            }
            return base.Update(entities);
        }

        public override Task Save(List<Bus> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad Bus no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new BusDataException("Debe proporcionar por lo menos un numero de Bus");
            }
            return base.Save(entities);
        }

        public override Task<List<Bus>> GetAll(Expression<Func<Bus, bool>> filter)
        {
            return base.GetAll(filter);
        }

        public override Task<Bus> Get(int Id)
        {
            return base.Get(Id);
        }

        public List<BusModel> GetBus()
        {
            var buses = (from b in context.Bus
                         join a in context.Asiento on b.IdBus equals a.IdBus
                         where b.Eliminado == false
                         select new BusModel
                         {
                             IdBus = b.IdBus,
                             Nombre = b.Nombre,
                             NumeroPlaca = b.NumeroPlaca,
                             Disponible = b.Disponible,

                         }).ToList();

            return buses;
        }


        public List<BusModel> GetBusByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
