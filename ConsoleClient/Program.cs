using Microsoft.EntityFrameworkCore;
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

            collection.AddLogging(c =>
            {
                c.AddFilter(ll => true);
                c.AddDebug();
            });

            collection.AddDbContext<DatabaseContext>(o =>
            {
                o.UseSqlServer(
                    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonManagerApp;Integrated Security=True");
            });


            collection.AddTransient<IPersonCommands, PersonCommands>();

            var provider = collection.BuildServiceProvider();

            var config = provider.GetRequiredService<IConfigurator>();

            var user = new User(4711, "David");
            config.Set("User", user);


            var commands = provider.GetRequiredService<IPersonCommands>();

            //commands.InputTestPerson();
            commands.DisplayAllAdults();
            commands.DisplayAllChildren();
        }
    }
}
