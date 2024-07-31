using EmailManagement;
using Microsoft.Extensions.DependencyInjection;
using RV24.PMA.Data.DataStoring;
using RV24.PMA.Data.FileStoring;
using RV24.PMA.Logic.Domain.PersonManagement;
using Workflows;

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

            var commands = provider.GetRequiredService<IPersonCommands>();

            commands.InputTestPerson();
            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
