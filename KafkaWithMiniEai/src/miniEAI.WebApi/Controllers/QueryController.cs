using Application.Common.Core;
using Application.Common.Models.Authorization;
using Application.Common.Models.AutoApprove;
using Application.Common.Models.JobApprove;
using Application.Common.Models.JobIncomplete;
using Application.Common.Models.Microsite;
using Application.Common.Models.NotifyAppointmentOrder;
using Application.Common.Models.SendCheckInLate;
using Application.Query;
using Application.Query.NotifyAppointmentOrder;
using Microsoft.AspNetCore.Mvc;
using MiniEAI.Api.Controllers;

namespace miniEAI.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class QueryController : ApiController
{
    [HttpPost("/api/execute")]
    public async Task<ResponseBase> ExecuteV1([FromHeader] RequestHeader header, [FromBody] EventRequestV1Model body, CancellationToken cancellationToken)
    {
        var sendCheckInLate = body.AsSendCheckInLate(header);
        return await Mediator.Send(sendCheckInLate, cancellationToken);
    }

    [HttpPost("/api/NotifyAppointmentOrder")]
    public async Task<ResponseBase> NotifyAppointmentOrder([FromHeader] RequestHeader header, [FromBody] CommitNotifyAppointmentOrderRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/SendCheckInLate")]
    public async Task<ResponseBase> SendCheckInLate([FromHeader] RequestHeader header, [FromBody] SendCheckInLateRequestBase body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/Microsite")]
    public async Task<ResponseBase> Microsite([FromHeader] RequestHeader header, [FromBody] MicrositeRequestBase body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/acimuser")]
    [HttpPut("/api/acimuser")]
    [HttpPost("/api/acimuser/del")]
    public async Task<ResponseBase> Authorization([FromHeader] AuthorizationRequestHeader header, [FromBody] AuthorizationRequestBase body, CancellationToken cancellationToken)
    {
        body.Prepare(header, Request.Method, Request.Path);
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/AutoApprove")]
    public async Task<ResponseBase> AutoApprove([FromHeader] RequestHeader header, [FromBody] AutoApproveRequestBase body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/JobIncomplete")]
    public async Task<ResponseBase> JobIncomplete([FromHeader] RequestHeader header, [FromBody] JobIncompleteRequestBase body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/JobApprove")]
    public async Task<ResponseBase> JobApprove([FromHeader] RequestHeader header, [FromBody] JobApproveRequestBase body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }
}
