namespace RV24.PMA.Data.FileStoring.Contract;

public interface IFileWriter
{
    void AppendLine(string path, string line);
}