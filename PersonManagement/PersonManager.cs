using RV24.PMA.CrossCutting.Configuration.Contract;
using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Data.DataStoring;
using RV24.PMA.Data.DataStoring.Contract;
using RV24.PMA.Logic.Domain.PersonManagement.Contract;

namespace RV24.PMA.Logic.Domain.PersonManagement;

public class PersonManager : IPersonManager
{
    private IPersonRepository _repository;
    private readonly int AGETRESHOLD;

    public PersonManager(IPersonRepository repository,
        IConfigurator config)
    {
        AGETRESHOLD = config.Get<int>("PersonManagement.AgeTreshold");
        _repository = repository;
    }

    public void Add(Person person)
    {
        if (string.IsNullOrWhiteSpace(person.Name) || person.Name.Length < 3)
            throw new ArgumentException("Name not valid", nameof(person.Name));

        _repository.Insert(person);
    }

    public IQueryable<Person> GetAllChildren()
    {
        var children = _repository.Query().Where(p => p.Age < AGETRESHOLD);
        return children;
    }

    public IQueryable<Person> GetAllAdults()
    {
        var adults = _repository.Query().Where(p => p.Age >= AGETRESHOLD);
        return adults;
    }
}