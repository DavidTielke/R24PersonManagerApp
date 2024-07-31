using EmailManagement;
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
            var fileReader = new FileReader();
            var fileWriter = new FileWriter();
            var parser = new PersonParser();
            var serializer = new PersonSerializer();
            var repo = new PersonRepository(parser, fileReader, fileWriter, serializer);
            var manager = new PersonManager(repo);
            var sender = new EmailSender();
            var workflow = new PersonWorkflows(manager, sender);
            var commands = new PersonCommands(manager, workflow);


            commands.AddTestPerson();
            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
