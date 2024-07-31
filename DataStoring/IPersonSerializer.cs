using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Data.DataStoring;

public interface IPersonSerializer
{
    string SerializeToCsv(Person person);
}