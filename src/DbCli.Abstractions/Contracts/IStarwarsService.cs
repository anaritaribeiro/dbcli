using System.Collections.Generic;

namespace Tectil.NCommand.Template.Abstractions.Contracts
{
    public interface IStarwarsService
    {
        IList<string> GetJedis();

        IList<string> GetSiths();
    }
}
