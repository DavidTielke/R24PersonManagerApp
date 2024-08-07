using RV24.PMA.CrossCutting.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using RV24.PMA.CrossCutting.Configuration.Contract;
using RV24.PMA.CrossCutting.Configuration.Data;

namespace RV24.PMA.CrossCutting.Configuration.Logic
{
    public class ConfigEntryManager : IConfigEntryManager
    {
        private readonly IConfigEntryRepository _repository;
        private readonly IServiceProvider _provider;

        public ConfigEntryManager(IConfigEntryRepository repository, 
            IServiceProvider provider)
        {
            _repository = repository;
            _provider = provider;
        }

        public void Update(ConfigEntry entry)
        {
            _repository.Update(entry);

            var configurator = _provider.GetRequiredService<IConfigurator>();
            configurator.Initialize();
        }

        public IQueryable<ConfigEntry> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
