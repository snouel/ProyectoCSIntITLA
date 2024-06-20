﻿using BoletoBus.Domain.Core;
using BoletoBus.Domain.Entities;
using BoletoBus.Domain.Models;

namespace BoletoBus.Domain.Interfaces
{
    public interface IAsientoRepository : IBaseRepository<Asiento>
    {
        List<AsientoModel> GetAsientos();
        List<AsientoModel> GetAsientosYBuses();
        List<AsientoModel> GetAsientosByBusID(int busId);
        Task<Asiento> GetAsientoByIdAsync(int id);



    }
}
