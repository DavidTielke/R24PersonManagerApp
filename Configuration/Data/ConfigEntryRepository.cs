using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.CrossCutting.Configuration.Data;

public class ConfigEntryRepository : IConfigEntryRepository
{
    private readonly ConfigDataContext _context;

    public ConfigEntryRepository()
    {
        _context = new ConfigDataContext();
    }

    public void Update(ConfigEntry entry)
    {
        var entryFromDB = GetAll().First(c => c.Id == entry.Id);
        entryFromDB.Value = entry.Value;
        entryFromDB.DataType = entry.DataType;
        _context.SaveChanges();
    }

    public IQueryable<ConfigEntry> GetAll()
    {
        return _context.Set<ConfigEntry>();
    }
}