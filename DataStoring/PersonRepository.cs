using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Data.FileStoring;

namespace RV24.PMA.Data.DataStoring;

public class PersonRepository
{
    private readonly PersonParser _parser;
    private readonly FileReader _reader;

    public PersonRepository()
    {
        _parser = new PersonParser();
        _reader = new FileReader();
    }

    public IQueryable<Person> Query()
    {
        var lines = _reader.ReadAllLines("data.csv");
        var persons = lines.Select(l => _parser.ParseCsv(l));
        return persons.AsQueryable();
    }
}