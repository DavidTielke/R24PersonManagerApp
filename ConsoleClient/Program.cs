using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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

            var configRepository = provider.GetRequiredService<IConfigEntryRepository>();
            var entries = configRepository.GetAll().ToList();

            var first = entries.First();
            first.Value = "50";
            configRepository.Update(first);

            var commands = provider.GetRequiredService<IPersonCommands>();

            commands.InputTestPerson();
            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
