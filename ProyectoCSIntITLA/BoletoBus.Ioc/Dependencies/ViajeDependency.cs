

using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Ioc.Dependencies
{
    public static class ViajeDependency
    {
        public static void AddViajeDependency(this IServiceCollection services)
        {
            services.AddScoped<IViajeRepository, ViajeRepository>();

        }
    }
}
