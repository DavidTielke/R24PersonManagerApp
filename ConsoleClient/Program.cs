using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RV24.PMA.CrossCutting.Configuration.Contract;
using RV24.PMA.CrossCutting.Configuration.Data;
using RV24.PMA.CrossCutting.Configuration.Logic;
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

            var user = new User(4711, "David");
            config.Set("User", user);


            var commands = provider.GetRequiredService<IPersonCommands>();

            commands.InputTestPerson();
            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User()
        {
            
        }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
