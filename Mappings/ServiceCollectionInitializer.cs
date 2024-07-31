using EmailManagement;
using Microsoft.Extensions.DependencyInjection;
using RV24.PMA.Data.DataStoring;
using RV24.PMA.Data.FileStoring;
using RV24.PMA.Logic.Domain.PersonManagement;
using Workflows;

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
        }
    }
}
