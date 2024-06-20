

using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Ioc.Dependencies
{
    public static class ReservaDetalleDependency
    {
        public static void AddReservaDetalleDependency(this IServiceCollection services)
        {
            services.AddScoped<IReservaDetalleRepository, ReservaDetalleRepository>();

        }
    }
}
