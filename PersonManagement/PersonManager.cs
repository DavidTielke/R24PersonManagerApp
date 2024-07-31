using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Data.DataStoring;

namespace RV24.PMA.Logic.PersonManagement;

public class PersonManager
{
    private PersonRepository _repository;

    public PersonManager()
    {
        _repository = new PersonRepository();
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