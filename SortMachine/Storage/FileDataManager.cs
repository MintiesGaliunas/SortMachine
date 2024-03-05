using SortMachine.Models;

namespace SortMachine.Storage;

public class FileDataManager: IDataManager
{
    private readonly string _fileName;

    public FileDataManager(IConfiguration configuration)
    {
        _fileName = configuration.GetValue<string>("StorageFileName") ?? throw new ArgumentNullException();
    }

    public string? ReadData()
    {
        using StreamReader streamReader = new(_fileName);
        return streamReader.ReadLine();
    }

    public void WriteData(string sortedList)
    {
        using StreamWriter streamWriter = new(_fileName);
        streamWriter.WriteLine(sortedList);
    }
}
