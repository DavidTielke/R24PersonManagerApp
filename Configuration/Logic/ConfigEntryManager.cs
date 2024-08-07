using RV24.PMA.CrossCutting.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RV24.PMA.CrossCutting.Configuration.Data;

namespace RV24.PMA.CrossCutting.Configuration.Logic
{
    public class ConfigEntryManager : IConfigEntryManager
    {
        private readonly IConfigEntryRepository _repository;

        public ConfigEntryManager(IConfigEntryRepository repository)
        {
            _repository = repository;
        }

        public void Update(ConfigEntry entry)
        {
            _repository.Update(entry);
        }

        public IQueryable<ConfigEntry> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
