namespace RV24.PMA.Logic.Domain.Localization.Contract
{
    public interface ILocalizator
    {
        // key = Persons.AddMask.Firstname
        string Get(string key);

        // Das Paket ist {0} cm lang
        string Get(string key, params object[] parameter);
    }
}
