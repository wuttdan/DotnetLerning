using Application.Common.Core;
using Application.Common.Interfaces;
using Application.Common.Models.NotifyAppointmentOrder;
using Application.Query;
using Application.Query.NotifyAppointmentOrder;
using Application.Query.SendCheckInLate;
using Application.Util;
using Domain.Extension;
using miniEAI.ConsoleApp.CoreTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniEAI.ConsoleApp.AppTest;

public class TestCommitSendCheckInLateHandler_Install : ApplicationTestBase
{
    private CommitSendCheckInLateValidator? _validator = null;
    private CommitSendCheckInLateHandler? _handler = null;
    public TestCommitSendCheckInLateHandler_Install(ILogger logger,
        IPrimaryDbContext primaryDb,
        CommitSendCheckInLateValidator validator)
        : base(logger)
    {

        _validator = validator;
        _handler = new CommitSendCheckInLateHandler(logger, primaryDb);
    }

    public override async Task Run(params string[] args)
    {
        var req = GetTempSendCheckInLateInstall();
        try
        {
            var result = _validator.Validate(req);
            if (result.IsValid)
            {
                _logger.Information($"console app => req: {req.ObjToJson(true)}");

                var res = await _handler.Handle(req, default);

                _logger.Information($"console app => res: {res.ObjToJson(true)}");
            }
        }
        catch (Exception ex)
        {
            _logger.Error(ex, $"Error occurred at {GetType().Name}.Run");
        }
    }
}