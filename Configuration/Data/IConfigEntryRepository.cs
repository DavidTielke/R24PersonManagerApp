using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.CrossCutting.Configuration.Data
{
    public interface IConfigEntryRepository
    {
        void Update(ConfigEntry entry);
        IQueryable<ConfigEntry> GetAll();
    }
}
