

using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Ioc.Dependencies
{
    public static class BusDependency
    {
        public static void AddBusDependency(this IServiceCollection services)
        {
            services.AddScoped<IBusRepository, BusRepository>();

        }
    }
}
