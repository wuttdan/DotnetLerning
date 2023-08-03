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
        return await mediator.Send(sendCheckInLate, cancellationToken);
    }

    [HttpPost("/api/NotifyAppointmentOrder")]
    public async Task<ResponseBase> NotifyAppointmentOrder([FromHeader] RequestHeader header, [FromBody] NotifyAppointmentOrderRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/SendCheckInLate")]
    public async Task<ResponseBase> SendCheckInLate([FromHeader] RequestHeader header, [FromBody] SendCheckInLateRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/Microsite")]
    public async Task<ResponseBase> Microsite([FromHeader] RequestHeader header, [FromBody] MicrositeRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/acimuser")]
    [HttpPut("/api/acimuser")]
    [HttpPost("/api/acimuser/del")]
    public async Task<ResponseBase> Authorization([FromHeader] AuthorizationRequestHeader header, [FromBody] AuthorizationRequestModel body, CancellationToken cancellationToken)
    {
        body.Prepare(header, Request.Method, Request.Path);
        return await mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/AutoApprove")]
    public async Task<ResponseBase> AutoApprove([FromHeader] RequestHeader header, [FromBody] AutoApproveRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/JobIncomplete")]
    public async Task<ResponseBase> JobIncomplete([FromHeader] RequestHeader header, [FromBody] JobIncompleteRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await mediator.Send(body, cancellationToken);
    }

    [HttpPost("/api/JobApprove")]
    public async Task<ResponseBase> JobApprove([FromHeader] RequestHeader header, [FromBody] JobApproveRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await mediator.Send(body, cancellationToken);
    }
}
