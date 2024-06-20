

using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Ioc.Dependencies
{
    public static class ReservaDependency
    {
        public static void AddReservaDependency(this IServiceCollection services)
        {
            services.AddScoped<IReservaRepository, ReservaRepository>();

        }
    }
}
