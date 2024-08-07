using RV24.PMA.CrossCutting.Configuration.Contract;

namespace RV24.PMA.CrossCutting.Configuration
{
    public class MemoryConfigurator : IConfigurator
    {
        private Dictionary<string, object> _items;

        public MemoryConfigurator()
        {
            _items = new Dictionary<string, object>();
        }

        public TValue Get<TValue>(string key)
        {
            var value = (TValue)_items[key];
            return value;
        }

        public void Set<TValue>(string key, TValue value, bool persist = false)
        {
            _items[key] = value;
        }
    }
}
