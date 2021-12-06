using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Tectil.NCommand.Abstractions;
using Tectil.NCommand.Base;
using Tectil.NCommand.Template.Commands.Commands;

namespace Tectil.NCommand.Template.Host
{
    class Program
    {
        private const int RetainedFileCountLimit = 10;
        private const string ApplicationTitle = "NCommand Console";
        private static IList<Assembly> _commandAssemblies = new[] 
        {
            typeof(StarwarsCommands).Assembly
        };

        static async Task Main(string[] args)
        {
            var collection = new ServiceCollection();
            var ncommand = await collection.BuildNCommandConsoleAsync(
                _commandAssemblies,
                options: new NCommandOptions() {
                    Title = ApplicationTitle,
                    Notation = ParserNotation.Windows,
                    EnableSocketServer = true
                },
                registerCallback: request => {
                    request.Services.AddLogging(builder =>
                    {
                        builder.ClearProviders();
                        builder.AddConfiguration(request.Configuration.GetSection("Logging"));
                        //builder.AddConsole();
                        builder.AddFile("Logs/ncommand-{Date}.txt",
                            isJson: true,
                            retainedFileCountLimit: RetainedFileCountLimit);
                    });
                });
            await ncommand.RunAsync(args);
        }
    }
}
