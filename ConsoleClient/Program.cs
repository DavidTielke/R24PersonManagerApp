using Microsoft.Extensions.DependencyInjection;
using RV24.PMA.CrossCutting.Configuration.Contract;
using RV24.PMA.CrossCutting.Configuration.Data;
using RV24.PMA.Data.DataStoring;
using RV24.PMA.Data.FileStoring;
using RV24.PMA.Logic.Domain.PersonManagement;

namespace RV24.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();

            collection.AddApplicationMappings();

            collection.AddTransient<IPersonCommands, PersonCommands>();

            var provider = collection.BuildServiceProvider();

            var config = provider.GetRequiredService<IConfigurator>();
            config.Set("PersonManagement.AgeTreshold", 10);

            var configManager = provider.GetRequiredService<IConfigEntryRepository>();
            var entries = configManager.GetAll().ToList();

            var commands = provider.GetRequiredService<IPersonCommands>();

            commands.InputTestPerson();
            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
