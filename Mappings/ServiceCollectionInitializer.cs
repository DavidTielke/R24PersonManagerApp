using Microsoft.Extensions.DependencyInjection;
using RV24.PMA.CrossCutting.Configuration;
using RV24.PMA.CrossCutting.Configuration.Contract;
using RV24.PMA.Data.DataStoring;
using RV24.PMA.Data.DataStoring.Contract;
using RV24.PMA.Data.FileStoring;
using RV24.PMA.Data.FileStoring.Contract;
using RV24.PMA.Logic.Business.Workflows;
using RV24.PMA.Logic.Business.Workflows.Contract;
using RV24.PMA.Logic.Domain.EmailManagement;
using RV24.PMA.Logic.Domain.EmailManagement.Contract;
using RV24.PMA.Logic.Domain.PersonManagement;
using RV24.PMA.Logic.Domain.PersonManagement.Contract;

namespace Mappings
{
    public class ServiceCollectionInitializer
    {
        public void Initialize(IServiceCollection collection)
        {
            collection.AddTransient<IPersonManager, PersonManager>();
            collection.AddTransient<IPersonWorkflows, PersonWorkflows>();
            collection.AddTransient<IPersonRepository, PersonRepository>();
            collection.AddTransient<IPersonParser, PersonParser>();
            collection.AddTransient<IPersonSerializer, PersonSerializer>();
            collection.AddTransient<IFileReader, FileReader>();
            collection.AddTransient<IFileWriter, FileWriter>();
            collection.AddTransient<IEmailSender, EmailSender>();
            collection.AddSingleton<IConfigurator, MemoryConfigurator>();
        }
    }
}
