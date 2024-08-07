namespace RV24.PMA.CrossCutting.Configuration.Contract
{
    public interface IConfigurator
    {
        TValue Get<TValue>(string key);
        void Set<TValue>(string key, TValue value, bool persist = false);
    }
}
