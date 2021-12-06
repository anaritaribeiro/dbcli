using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Tectil.DbCli.Abstractions.Contracts;
using Tectil.DbCli.Abstractions.Settings;

namespace Tectil.DbCli.Services
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddTemplateCommandsServices(this IServiceCollection services, StarwarsServiceOptions options)
        {
            services.AddSingleton<IStarwarsService, StarwarsService>();
            services.AddSingleton(Options.Create(options ?? new StarwarsServiceOptions()));
            return services;
        }
    }
}
