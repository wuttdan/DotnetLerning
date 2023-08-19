using Application.Query.NotifyAppointmentOrder;
using ConsoleTables;
using Domain.Extension;
using miniEAI.ConsoleApp.CoreTest;
using Newtonsoft.Json.Linq;

namespace miniEAI.ConsoleApp.AppTest;

public sealed class Testpolymorphism : ApplicationTestBase
{
    public Testpolymorphism(ILogger logger)
        : base(logger)
    {
    }

    public override Task Run(params string[] args)
    {
        var fileInstall = File.ReadAllText(@"DataTest/notify-install.json");
        var commit = fileInstall.JsonToObj<CommitNotifyAppointmentOrderRequestModel>();
        var decompose = commit.ToDecompose();
        var workorder = decompose.ToWorkorder();

        return Task.CompletedTask;
    }
}