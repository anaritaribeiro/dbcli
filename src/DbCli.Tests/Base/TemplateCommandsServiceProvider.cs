using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;
using Tectil.DbCli.Abstractions.Contracts;
using Tectil.DbCli.Abstractions.Settings;
using Tectil.DbCli.Services;
using Tectil.NCommand.Testing.Infrastructure;
using Tectil.NCommand.Testing.Infrastructure.Helpers;

namespace Tectil.DbCli.Tests.Base
{
    /// <summary>
    /// DokVorlage ServiceProvider. Setup services and mocks for testclasses.
    /// </summary>
    public class TemplateCommandsServiceProvider
        : ServiceProviderTestFixture
    {
        public const string JediName = "MockedJedi";

        /// <inheritdoc />
        public TemplateCommandsServiceProvider() : base(serviceCollectionPerTest: true) { } // Service Provider on class or test level 

        /// <summary>
        /// Add Dok Vorlage specific dependency injection registration.
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="configuration"></param>
        /// <param name="mappingAssemblies"></param>
        protected override void AddServices(IServiceCollection serviceCollection, IConfiguration configuration, HashSet<Assembly> mappingAssemblies)
        {
            serviceCollection.AddTemplateCommandsServices(new StarwarsServiceOptions()); // TODO from configuration
            AddInMemoryDatabases(serviceCollection, databasename: TestFixtureName.ToLower());
            AddServiceReplacements(serviceCollection);
        }
        
        private void AddInMemoryDatabases(IServiceCollection serviceCollection, string databasename)
        {
            //serviceCollection.AddInMemoryDataContext<DbContext>(databasename);
        }

        private void AddServiceReplacements(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMoqSingleton<IStarwarsService>(moq => moq.Setup(sut => sut.GetJedis()).Returns(new List<string>() { JediName }));
        }

    }
}
