using Application.Query.NotifyAppointmentOrder;
using miniEAI.ConsoleApp.CoreTest;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Extension;
using System.Diagnostics;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsWPF;
using ConsoleTables;

namespace miniEAI.ConsoleApp.AppTest;

public sealed class TestJsonPath : ApplicationTestBase
{

    public TestJsonPath(ILogger logger) 
        : base(logger)
    {
    }

    public override Task Run(params string[] args)
    {
        var validateInstall = File.ReadLines(@"DataTest/validate-install.txt");
        var textInstall = File.ReadAllText(@"DataTest/notify-install.json");
        var jsonInstall = JObject.Parse(textInstall);

        foreach (var line in validateInstall)
        {
            var values = jsonInstall.SelectTokens(line);
            var value = values.FirstOrDefault();
            var isNull = value == null ? "isnull" : "notnull";
            if (value?.Type == JTokenType.String && string.IsNullOrEmpty(value?.ToString()))
            {
                isNull = "isempty";
            }
            Debug.WriteLine($"token: {line}, value: {isNull}");
        }


        return Task.CompletedTask;
    }
}