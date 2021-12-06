using System;
using System.Threading.Tasks;
using Tectil.NCommand.Template.Abstractions.Contracts;
using Tectil.NCommand.Template.Tests.Base;
using Tectil.NCommand.Testing.Infrastructure.Traits;
using Xunit;

namespace Tectil.NCommand.Template.Tests
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
