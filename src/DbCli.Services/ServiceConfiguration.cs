using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Tectil.NCommand.Template.Abstractions.Contracts;
using Tectil.NCommand.Template.Abstractions.Settings;

namespace Tectil.NCommand.Template.Services
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
