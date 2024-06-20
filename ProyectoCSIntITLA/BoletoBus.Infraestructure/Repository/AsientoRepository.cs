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
    public class AsientoRepository : BaseRepository<Asiento>, IAsientoRepository
    {
        private readonly BusTicketContext context;
        public AsientoRepository(BusTicketContext context) : base(context)
        {
            this.context = context;
        }


        public List<AsientoModel> GetAsientos()
        {
            var asientos = context.Asiento.Select(cd => new AsientoModel()
            {

                IdAsiento = cd.IdAsiento,
                IdBus = cd.IdBus,
                NumeroPiso = cd.NumeroPiso,
                NumeroAsiento = cd.NumeroAsiento
            }).ToList();



            return asientos;
        }

        public List<AsientoModel> GetAsientosYBuses()
        {
            var asientosAndBuses = (from a in context.Asiento
                            join b in context.Bus on a.IdBus equals b.IdBus
                            where a.Eliminado == false
                            select new AsientoModel
                            {
                                NumeroAsiento = a.NumeroAsiento,
                                NumeroPiso = a.NumeroPiso,

                                Bus = new BusModel
                                {
                                    NumeroPlaca = b.NumeroPlaca,
                                    Nombre = b.Nombre,
                                    Disponible = b.Disponible

                                },
                                ReservaDetalles = (from rd in context.ReservaDetalle
                                                   where rd.IdAsiento == a.IdAsiento
                                                   select new ReservaDetalleModel
                                                   {
                                                       IdReserva = rd.IdReserva,
                                                       IdAsiento = rd.IdAsiento

                                                   }).ToList()
                            }).ToList();

            return asientosAndBuses;
        }

     

        public List<AsientoModel> GetAsientosByBusID(int busId)
        {
            var asientosByBusID = (from a in context.Asiento
                            join b in context.Bus on a.IdBus equals b.IdBus
                            where a.Eliminado == false && a.IdBus == busId
                            select new AsientoModel
                            {
                                NumeroAsiento = a.NumeroAsiento,
                                NumeroPiso = a.NumeroPiso,

                                Bus = new BusModel
                                {
                                    NumeroPlaca = b.NumeroPlaca,
                                    Nombre = b.Nombre,
                                    Disponible = b.Disponible

                                },
                                ReservaDetalles = (from rd in context.ReservaDetalle
                                                   where rd.IdAsiento == a.IdAsiento
                                                   select new ReservaDetalleModel
                                                   {
                                                       IdReserva = rd.IdReserva,
                                                       IdAsiento = rd.IdAsiento

                                                   }).ToList()
                            }).ToList();

            return asientosByBusID;
        }

        public override async Task Save(Asiento entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad asiento no debe ser nula.");
            }
            //if (await base.Exists(cd => cd.IdAsiento == entity.IdAsiento))
            //{
                
            //}

             await base.Save(entity);
        }

        public override Task Update(Asiento entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("La entidad asiento no debe ser nula.");
            }

            return base.Update(entity);
        }

        public override Task Update(List<Asiento> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad asiento no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new AsientoDataException("Debe proporcionar por lo menos un numero de asiento");
            }
            return base.Update(entities);
        }

        public override Task Save(List<Asiento> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException("La entidad asiento no debe ser nula.");
            }

            if (!entities.Any())
            {
                throw new AsientoDataException("Debe proporcionar por lo menos un numero de asiento");
            }
            return base.Save(entities);
        }

        public override Task<List<Asiento>> GetAll(Expression<Func<Asiento, bool>> filter)
        {
            return base.GetAll(filter);
        }

        public override Task<Asiento> Get(int Id)
        {
            return base.Get(Id);
        }

        public async Task<Asiento> GetAsientoByIdAsync(int id)
        {
            var asiento = await context.Asiento.FindAsync(id);

            if (asiento == null)
            {
                throw new KeyNotFoundException($"Asiento with ID {id} not found.");
            }
            return asiento;
        }

      
    }
}
