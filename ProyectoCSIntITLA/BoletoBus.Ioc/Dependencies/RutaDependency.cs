

using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Ioc.Dependencies
{
    public static class RutaDependency
    {
        public static void AddRutaDependency(this IServiceCollection services)
        {
            services.AddScoped<IRutaRepository, RutaRepository>();

        }
    }
}
