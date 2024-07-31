using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Data.DataStoring;

namespace RV24.PMA.Logic.Domain.PersonManagement;

public class PersonManager : IPersonManager
{
    private IPersonRepository _repository;

    public PersonManager(IPersonRepository repository)
    {
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
        var children = _repository.Query().Where(p => p.Age < 18);
        return children;
    }

    public IQueryable<Person> GetAllAdults()
    {
        var adults = _repository.Query().Where(p => p.Age >= 18);
        return adults;
    }
}