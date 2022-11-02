// See https://aka.ms/new-console-template for more information
using IpHistory;

var httpClient = new HttpClient();
var ip = await httpClient.GetStringAsync("https://api.ipify.org");
Console.WriteLine($"Your public IP address is: {ip}");
Console.WriteLine("Do you want to save this ip in your history? yes or no?");
var userInput = Console.ReadLine();

switch (userInput)
{
    case "yes":
    case "y":
        var ipWriter = new IpWriter();
        ipWriter.WriteData(ip);
        break;
    case "no":
    case "n":
        break;
    default:
        Console.WriteLine("Wrong input!");
        break;
}

Console.WriteLine("Exiting application.");

