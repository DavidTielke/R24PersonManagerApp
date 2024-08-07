using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.Configuration;
using RV24.PMA.CrossCutting.Configuration.Contract;
using RV24.PMA.CrossCutting.Configuration.Logic;

namespace RV24.PMA.CrossCutting.Configuration
{
    public class MemoryConfigurator : IConfigurator
    {
        private readonly IConfigEntryManager _manager;

        private Dictionary<string, object> _persistedItems;
        private Dictionary<string, object> _tempItems;

        public MemoryConfigurator(IConfigEntryManager manager)
        {
            _manager = manager;
            _persistedItems = new Dictionary<string, object>();
            _tempItems = new Dictionary<string, object>();
            Initialize();
        }

        public void Initialize()
        {
            var entries = _manager.GetAll().ToList();
            foreach (var entry in entries)
            {
                var entryKey = entry.Key;
                var entryValue = Convert.ChangeType(entry.Value, Type.GetType(entry.DataType));
                _persistedItems[entryKey] = entryValue;
            }
        }

        public TValue Get<TValue>(string key)
        {
            var existInTempItems = _tempItems.ContainsKey(key);
            if (existInTempItems)
            {
                var value = (TValue)_tempItems[key];
                return value;
            }
            else
            {
                var value = (TValue)_persistedItems[key];
                return value;
            }
        }

        public void Set<TValue>(string key, TValue value)
        {
            _tempItems[key] = value;
        }
    }
}
