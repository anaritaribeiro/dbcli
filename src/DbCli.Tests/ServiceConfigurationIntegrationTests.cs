using System;
using System.Threading.Tasks;
using Tectil.DbCli.Abstractions.Contracts;
using Tectil.DbCli.Tests.Base;
using Tectil.NCommand.Testing.Infrastructure.Traits;
using Xunit;

namespace Tectil.DbCli.Tests
{
    [IntegrationTest]
    public class ServiceConfigurationTests
        : IClassFixture<TemplateCommandsServiceProvider>
    {
        private readonly TemplateCommandsServiceProvider _serviceFixture;

        public ServiceConfigurationTests(TemplateCommandsServiceProvider serviceFixture)
        {
            _serviceFixture = serviceFixture;
        }

        [Theory]
        [InlineData(typeof(IStarwarsService))] 
        public async Task CreateServiceTest(Type resolveType)
        {
            // arrange
            var provider = await _serviceFixture.GetProviderAsync();

            // act
            var result = provider.GetService(resolveType);

            // assert
            Assert.NotNull(result);
        }
    }
}
