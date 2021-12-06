using System.Collections.Generic;

namespace Tectil.DbCli.Abstractions.Contracts
{
    public interface IStarwarsService
    {
        IList<string> GetJedis();

        IList<string> GetSiths();
    }
}
