using System.Threading.Tasks;
using Tectil.NCommand.Abstractions;
using Tectil.NCommand.Template.Abstractions.Settings;
using Tectil.NCommand.Template.Services;

namespace Tectil.NCommand.Template.Commands
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
