using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Data.FileStoring;

namespace RV24.PMA.Data.DataStoring;

public class PersonRepository
{
    private const string DATAPATH = "data.csv";
    private readonly PersonParser _personParser;
    private readonly FileReader _fileReader;
    private readonly FileWriter _fileWriter;
    private readonly PersonSerializer _personSerializer;

    public PersonRepository()
    {
        _personParser = new PersonParser();
        _fileReader = new FileReader();
        _fileWriter = new FileWriter();
        _personSerializer = new PersonSerializer();
    }

    public IQueryable<Person> Query()
    {
        var lines = _fileReader.ReadAllLines(DATAPATH);
        var persons = lines.Select(l => _personParser.ParseCsv(l));
        return persons.AsQueryable();
    }

    public void Insert(Person person)
    {
        var id = GetMaxId() + 1;
        person.Id = id;
        var dataLine = _personSerializer.SerializeToCsv(person);
        _fileWriter.AppendLine(DATAPATH, dataLine);
    }

    private int GetMaxId()
    {
        var maxId = Query().Max(p => p.Id);
        return maxId;
    }
}