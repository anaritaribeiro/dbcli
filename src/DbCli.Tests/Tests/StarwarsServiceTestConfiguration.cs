using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using Tectil.NCommand.Template.Tests.Base;

namespace Tectil.NCommand.Template.Tests
{
    /// <summary>
    /// Starwars service test configuration. Service provider setup is done in base class.
    /// </summary>
    public class StarwarsServiceTestConfiguration
        : TemplateCommandsServiceProvider
    {
        /// <summary>
        /// Starwars service test configuration. Service provider setup is done in base class.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <param name="configuration"></param>
        protected override async Task ConfigureServicesAsync(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            await base.ConfigureServicesAsync(serviceProvider, configuration);
            //await SetupDataContextAsync(serviceProvider.GetService<DbContext>());
        }

        private async Task SetupDataContextAsync(DbContext context)
        {
            // SETUP DATABASE CONTEXT
            await context.SaveChangesAsync();
        }
    }
}
