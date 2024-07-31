namespace RV24.PMA.Data.FileStoring;

public interface IFileReader
{
    IEnumerable<string> ReadAllLines(string path);
}