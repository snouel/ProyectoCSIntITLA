﻿using BoletoBus.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace BoletoBus.Domain.Entities
{
    public sealed class Reserva : AuditableEntity
    {
        [Key]
        public int IdReserva { get; set; }
        public int IdViaje { get; set; }
        public int IdPasajero { get; set; }
        public int AsientosReservados { get; set; }
        public decimal MontoTotal { get; set; }
        public Viaje Viaje { get; set; }
        public Usuario Pasajero { get; set; }
        public ICollection<ReservaDetalle> ReservaDetalles { get; set; }
    }
}