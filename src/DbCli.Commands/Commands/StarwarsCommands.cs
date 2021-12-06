using System.Collections.Generic;
using Tectil.NCommand.Abstractions;
using Tectil.DbCli.Abstractions.Contracts;

namespace Tectil.DbCli.Commands.Commands
{
    /// <summary>
    /// Starwars commands.
    /// </summary>
    [Topic(Label = "Starwars topic")]
    public class StarwarsCommands
        : INCommandRepository
    {
        private readonly IStarwarsService _starwarsService;

        /// <inheritdoc/>
        public StarwarsCommands(IStarwarsService starwarsService)
        {
            _starwarsService = starwarsService;
        }

        /// <summary>
        /// Get Jedis.
        /// </summary>
        [Command(Label = "Get Jedis")]
        public IList<string> GetJedis()
        {
            return _starwarsService.GetJedis();
        }

        /// <summary>
        /// Get Siths.
        /// </summary>
        [Command(Label = "Get Siths")]
        public IList<string> GetSiths()
        {
            return _starwarsService.GetSiths();
        }
    }
}
