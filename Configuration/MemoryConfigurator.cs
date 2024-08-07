using Microsoft.Extensions.Configuration;
using RV24.PMA.CrossCutting.Configuration.Contract;
using RV24.PMA.CrossCutting.Configuration.Logic;

namespace RV24.PMA.CrossCutting.Configuration
{
    public class MemoryConfigurator : IConfigurator
    {
        private readonly IConfigEntryManager _manager;

        private Dictionary<string, object> _items;

        public MemoryConfigurator(IConfigEntryManager manager)
        {
            _manager = manager;
            _items = new Dictionary<string, object>();
            Initialize();
        }

        public void Initialize()
        {
            var entries = _manager.GetAll().ToList();
            foreach (var entry in entries)
            {
                var entryKey = entry.Key;
                var entryValue = Convert.ChangeType(entry.Value, Type.GetType(entry.DataType));
                _items[entryKey] = entryValue;
            }
        }

        public TValue Get<TValue>(string key)
        {
            var value = (TValue)_items[key];
            return value;
        }

        public void Set<TValue>(string key, TValue value)
        {
            _items[key] = value;
        }
    }
}
