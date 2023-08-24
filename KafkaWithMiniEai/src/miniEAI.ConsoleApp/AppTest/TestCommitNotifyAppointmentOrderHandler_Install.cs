using Application.Common.Core;
using Application.Common.Interfaces;
using Application.Common.Models.NotifyAppointmentOrder;
using Application.Query;
using Application.Query.NotifyAppointmentOrder;
using Application.Util;
using Domain.Extension;
using miniEAI.ConsoleApp.CoreTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniEAI.ConsoleApp.AppTest;

public class TestCommitNotifyAppointmentOrderHandler_Install : ApplicationTestBase
{
    private CommitNotifyAppointmentOrderValidator? _validator = null;
    private CommitNotifyAppointmentOrderHandler? _handler = null;
    public TestCommitNotifyAppointmentOrderHandler_Install(ILogger logger,
        IPrimaryDbContext primaryDb,
        CommitNotifyAppointmentOrderValidator validator)
        : base(logger)
    {

        _validator = validator;
        _handler = new CommitNotifyAppointmentOrderHandler(logger, primaryDb);
    }

    public override async Task Run(params string[] args)
    {
        var req = TempNotifyInstall;
        req.Header = GetCommonRequestHeader("");
        try
        {
            _validator.Validate(req);
            _logger.Information($"console app => req: {req.ObjToJson(true)}");

            var res = await _handler.Handle(TempNotifyInstall, default);

            _logger.Information($"console app => res: {res.ObjToJson(true)}");
        }
        catch (Exception ex)
        {
            _logger.Error(ex, $"Error occurred at {GetType().Name}.Run");
        }
    }
}