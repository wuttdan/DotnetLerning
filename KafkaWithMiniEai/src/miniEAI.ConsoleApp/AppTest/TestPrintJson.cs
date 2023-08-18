using ConsoleTables;
using miniEAI.ConsoleApp.CoreTest;
using Newtonsoft.Json.Linq;

namespace miniEAI.ConsoleApp.AppTest;

public sealed class TestPrintJson : ApplicationTestBase
{
    private readonly string _printing = "d3";
    private static int _counter = 0;
    public TestPrintJson(ILogger logger)
        : base(logger)
    {
    }

    public override Task Run(params string[] args)
    {
        var fileInstall = File.ReadAllText(@"DataTest/notify-install.json");
        var fileMa = File.ReadAllText(@"DataTest/notify-install.json");

        Console.WriteLine("notify-install");
        PrintNotifyAppointmentOrder(fileInstall);

        Console.WriteLine("notify-install");
        PrintNotifyAppointmentOrder(fileMa);
        return Task.CompletedTask;
    }

    public void PrintNotifyAppointmentOrder(string json)
    {
        var table = new ConsoleTable("id", "key", "value");
        var jobj = JObject.Parse(json);
        PrintJson(jobj, ref table, "");
        table.Write(Format.MarkDown);
    }

    public void PrintJson(JObject? jobj, ref ConsoleTable table, string parent = "")
    {
        foreach (var kvp in jobj!)
        {
            var prefix = string.IsNullOrEmpty(parent) ? "" : $"{parent}.";
            if (kvp.Value is JObject)
            {
                prefix = string.IsNullOrEmpty(parent) ? kvp.Key : $"{parent}.{kvp.Key}";
                PrintJson(kvp.Value as JObject, ref table, prefix);
                continue;
            }
            if (kvp.Value is JArray)
            {
                var i = 0;
                foreach (var item in kvp.Value)
                {
                    prefix = string.IsNullOrEmpty(parent) ? kvp.Key : $"{parent}.{kvp.Key}[{i}]";
                    if (item is JObject || item is JArray)
                    {
                        PrintJson((JObject)item, ref table, prefix);
                    }
                    else
                    {
                        ////Debug.WriteLine($"{_counter.ToString(_printing)} - Key: {prefix}\t\tValue: {item.ToString()}");
                        table.AddRow(_counter.ToString(_printing), prefix, item.ToString());
                    }
                    i += 1;
                }
                continue;
            }
            ////Debug.WriteLine($"{_counter.ToString(_printing)} - Key: {prefix}{kvp.Key}\t\tValue: {kvp.Value}");
            table.AddRow(_counter.ToString(_printing), $"{prefix}{kvp.Key}", $"{kvp.Value}");
            _counter += 1;
        }
    }
}