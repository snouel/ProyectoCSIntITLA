
using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace BoletoBus.Ioc.Dependencies
{
    public static class UsuarioDependency
    {
        public static void AddUsuarioDependency(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

        }
    }
}
