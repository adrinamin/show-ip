using System.Text.Json;

namespace IpHistory;

public class IpReader
{
    public IpHistoryEntries ReadData()
    {
        const string fileName = "IpHistory.json";
        var json = File.ReadAllText(fileName);
        var historyEntries = JsonSerializer.Deserialize<IpHistoryEntries>(json);
        return historyEntries ?? new IpHistoryEntries(); //todo: avoid too graceful handling
    }
}