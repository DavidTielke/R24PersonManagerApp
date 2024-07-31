using EmailManagement;
using Logging;
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

            collection.AddTransient<IPersonCommands, PersonCommands>();
            collection.AddTransient<IPersonManager, PersonManager>();
            collection.AddTransient<IPersonWorkflows, PersonWorkflows>();
            collection.AddTransient<IPersonRepository, PersonRepository>();
            collection.AddTransient<IPersonParser, PersonParser>();
            collection.AddTransient<IPersonSerializer, PersonSerializer>();
            collection.AddTransient<IFileReader, FileReader>();
            collection.AddTransient<IFileWriter, FileWriter>();
            collection.AddTransient<IEmailSender, EmailSender>();

            var provider = collection.BuildServiceProvider();

            var commands = provider.GetRequiredService<IPersonCommands>();

            commands.InputTestPerson();
            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
