using System.Text.Json;

namespace IpHistory;

public class IpWriter
{
    public void WriteData(string rawIp)
    {
        const string fileName = "IpHistory.json";
        var ip = new Ip
        {
            CurrentDateTime = DateTime.Now,
            IpEntry = rawIp
        };

        var entries = new IpReader().ReadData();
        entries.Ips.Add(ip);

        var jsonString = JsonSerializer.Serialize<IpHistoryEntries>(entries);
        
        File.WriteAllText(fileName, jsonString);
    }
}