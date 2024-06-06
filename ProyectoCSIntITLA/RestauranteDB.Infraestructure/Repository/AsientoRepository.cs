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
            var asientos = (from a in this.context.Asiento
                           join b in this.context.Bus on a.IdBus equals b.IdBus
                            where a.Deleted == false
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

             return asientos;
        }

        public List<AsientoModel> GetAsientosByBus(int busId)
        {
            var asientos = (from a in this.context.Asiento
                            join b in this.context.Bus on a.IdBus equals b.IdBus
                            where a.IdBus == busId
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

            return asientos;
        }
    }
}
