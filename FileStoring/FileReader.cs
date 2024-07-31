namespace RV24.PMA.Data.FileStoring;

public class FileReader : IFileReader
{
    public IEnumerable<string> ReadAllLines(string path)
    {
        return File.ReadAllLines(path);
    }
}