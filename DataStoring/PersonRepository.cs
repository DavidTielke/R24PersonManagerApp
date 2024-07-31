using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Data.FileStoring;

namespace RV24.PMA.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private const string DATAPATH = "data.csv";
    private readonly IPersonParser _personParser;
    private readonly IFileReader _fileReader;
    private readonly IFileWriter _fileWriter;
    private readonly IPersonSerializer _personSerializer;

    public PersonRepository(IPersonParser personParser, 
        IFileReader fileReader, 
        IFileWriter fileWriter, 
        IPersonSerializer personSerializer)
    {
        _personParser = personParser;
        _fileReader = fileReader;
        _fileWriter = fileWriter;
        _personSerializer = personSerializer;
    }

    public IQueryable<Person> Query()
    {
        var lines = _fileReader.ReadAllLines(DATAPATH);
        var persons = lines.Select(l => _personParser.ParseFromCsv(l));
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