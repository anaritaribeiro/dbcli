using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;
using Tectil.DbCli.Abstractions.Contracts;
using Tectil.NCommand.Testing.Infrastructure.Traits;
using Xunit;

namespace Tectil.DbCli.Tests
{
    [IntegrationTest]
    public class StarwarsServiceIntegrationTests
        : IClassFixture<StarwarsServiceTestConfiguration>
    {
        private readonly StarwarsServiceTestConfiguration _serviceFixture;

        public StarwarsServiceIntegrationTests(StarwarsServiceTestConfiguration serviceFixture)
        {
            _serviceFixture = serviceFixture;
        }

        [Fact]
        public async Task GetJedis_ShouldReturnTestDataFromMock()
        {
            // arrange
            var provider = await _serviceFixture.GetProviderAsync();
            var sut = provider.GetService<IStarwarsService>();
            sut.Should().NotBeNull(because: $@"Precondition failed, {nameof(IStarwarsService)} should not be null.");

            // act
            var jedis = sut.GetJedis();

            // assert
            jedis.Should().NotBeNull();
            jedis.Should().HaveCount(1);
            jedis.First().Should().Be(StarwarsServiceTestConfiguration.JediName);
        }
    }
}
