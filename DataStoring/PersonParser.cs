using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Data.DataStoring;

public class PersonParser : IPersonParser
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