namespace SortMachine.Storage;

public interface IDataManager
{
    string? ReadData();

    void WriteData(string sortedList);
}