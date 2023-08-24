using Application.Common.Core;
using Application.Common.Models.Authorization;
using Application.Query;
using Application.Query.Authorization;
using Application.Query.AutoApprove;
using Application.Query.JobApprove;
using Application.Query.JobIncomplete;
using Application.Query.Microsite;
using Application.Query.NotifyAppointmentOrder;
using Application.Query.SendCheckInLate;
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
        var res = await Mediator.Send(sendCheckInLate, cancellationToken);
        return res;
    }

    [HttpPost("/api/NotifyAppointmentOrder")]
    public async Task<ResponseBase> NotifyAppointmentOrder([FromHeader] RequestHeader header, [FromBody] CommitNotifyAppointmentOrderRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/SendCheckInLate")]
    public async Task<ResponseBase> SendCheckInLate([FromHeader] RequestHeader header, [FromBody] CommitSendCheckInLateRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/Microsite")]
    public async Task<ResponseBase> Microsite([FromHeader] RequestHeader header, [FromBody] CommitMicrositeRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/Microsite/Update")]
    public async Task<ResponseBase> MicrositeUpdate([FromHeader] RequestHeader header, [FromBody] CommitMicrositeUpdateRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/acimuser")]
    [HttpPut("/api/acimuser")]
    [HttpPost("/api/acimuser/del")]
    public async Task<ResponseBase> Authorization([FromHeader] AuthorizationRequestHeader header, [FromBody] CommitAuthorizationRequestModel body, CancellationToken cancellationToken)
    {
        body.Prepare(header, Request.Method, Request.Path);
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/AutoApprove")]
    public async Task<ResponseBase> AutoApprove([FromHeader] RequestHeader header, [FromBody] CommitAutoApproveRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/JobIncomplete")]
    public async Task<ResponseBase> JobIncomplete([FromHeader] RequestHeader header, [FromBody] CommitJobIncompleteRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/JobApprove")]
    public async Task<ResponseBase> JobApprove([FromHeader] RequestHeader header, [FromBody] CommitJobApproveRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await Mediator.Send(body, cancellationToken);
    }
}
