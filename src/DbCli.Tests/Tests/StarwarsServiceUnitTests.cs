using FluentAssertions;
using Tectil.DbCli.Abstractions.Settings;
using Tectil.DbCli.Services;
using Tectil.NCommand.Testing.Infrastructure.Helpers;
using Tectil.NCommand.Testing.Infrastructure.Traits;
using Xunit;

namespace Tectil.DbCli.Tests
{
    [UnitTest]
    public class StarwarsServiceUnitTests
    {
        [Theory]
        [InlineData(true, 3)]
        [InlineData(false, 2)]
        public void GetJedis_ShouldReturnTestDataFromMock(bool allSeasons, int expectedCountItems)
        {
            // arrange
            var sut = new StarwarsService(
                            MoqHelper.CreateOptionsMock<StarwarsServiceOptions>(e => e.Setup(sut => sut.AllSeasons).Returns(allSeasons))
                            );

            // act
            var jedis = sut.GetJedis();

            // assert
            jedis.Should().NotBeNull();
            jedis.Should().HaveCount(expectedCountItems);
        }
    }
}
