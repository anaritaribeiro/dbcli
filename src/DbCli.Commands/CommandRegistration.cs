using System.Threading.Tasks;
using Tectil.NCommand.Abstractions;
using Tectil.DbCli.Abstractions.Settings;
using Tectil.DbCli.Services;

namespace Tectil.DbCli.Commands
{
    public class CommandRegistration
        : INCommandRegistrationBase
    {
        public void AddDependencies(RegistrationContext context)
        {
            context.Services.AddTemplateCommandsServices(new StarwarsServiceOptions()); // TODO from config
        }

        public Task ConfigureDependenciesAsync(ConfigurationContext context)
        {
            return Task.FromResult(0);
        }
    }
}
