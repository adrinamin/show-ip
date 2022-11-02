using System.Text.Json;
using System.Text.Json.Serialization;

namespace IpHistory;

public class Ip 
{
    public DateTime CurrentDateTime { get; set; }
    public string IpEntry { get; set; } = string.Empty;
}