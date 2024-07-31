namespace RV24.PMA.Data.FileStoring;

public interface IFileWriter
{
    void AppendLine(string path, string line);
}