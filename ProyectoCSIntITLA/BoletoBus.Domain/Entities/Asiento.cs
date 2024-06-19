﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using BoletoBus.Domain.Core;

namespace BoletoBus.Domain.Entities
{
    public sealed class Asiento : AuditableEntity
    {
        [Key]
        public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }

        public Bus Bus { get; set; }
        public ICollection<ReservaDetalle> ReservaDetalles { get; set; }

    }
}
