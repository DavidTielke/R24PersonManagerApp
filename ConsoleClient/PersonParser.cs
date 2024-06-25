namespace ConsoleClient;

class PersonParser
{
    public Person ParseCsv(string dataLines)
    {
        var parts = dataLines.Split(",");
        var person = new Person
        {
            Id = int.Parse(parts[0]),
            Name = parts[1],
            Age = int.Parse(parts[2])
        };
        return person;
    }
}