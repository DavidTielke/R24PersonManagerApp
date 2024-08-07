using RV24.PMA.CrossCutting.DataClasses;

namespace RV24.PMA.Data.DataStoring.Contract;

public interface IPersonParser
{
    Person ParseFromCsv(string dataLines);
}