namespace RV24.PMA.Data.FileStoring.Contract;

public interface IFileReader
{
    IEnumerable<string> ReadAllLines(string path);
}