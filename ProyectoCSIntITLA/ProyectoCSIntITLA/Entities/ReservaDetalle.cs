﻿
using DBBoletoBus.Domain.Core;

namespace DBBoletoBus.Domain.Entities
{
    public sealed class ReservaDetalle : AuditableEntity
    {
        public int IdReservaDetalle { get; set; }
        public int IdReserva { get; set; }
        public int IdAsiento { get; set; }

        public Reserva Reserva { get; set; }
        public Asiento Asiento { get; set; }
    }
}
