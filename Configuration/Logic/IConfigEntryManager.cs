using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.CrossCutting.Configuration.Logic;

public interface IConfigEntryManager
{
    void Update(ConfigEntry entry);
    IQueryable<ConfigEntry> GetAll();
}