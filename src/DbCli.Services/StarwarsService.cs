using Microsoft.Extensions.Options;
using System.Collections.Generic;
using Tectil.DbCli.Abstractions.Contracts;
using Tectil.DbCli.Abstractions.Settings;

namespace Tectil.DbCli.Services
{
    public class StarwarsService
        : IStarwarsService
    {
        private readonly StarwarsServiceOptions _options;

        public StarwarsService(IOptions<StarwarsServiceOptions> options)
        {
            _options = options.Value ?? new StarwarsServiceOptions();
        }

        public IList<string> GetJedis()
        {
            var arr = new List<string>() {
                "Luke",
                "Leia"
            };
            if (_options.AllSeasons)
            {
                arr.Add("Rey");
            }
            return arr;
        }

        public IList<string> GetSiths()
        {
            var arr = new List<string>() {
                "Darth Sidious",
                "Darth Vader"
            };
            if (_options.AllSeasons)
            {
                arr.Add("Kylo Ren");
            }
            return arr;
        }
    }
}
