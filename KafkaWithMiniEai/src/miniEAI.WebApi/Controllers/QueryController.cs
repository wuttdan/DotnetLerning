using Application;
using Application.Common.Core;
using Application.Query.NotifyAppointmentOrder;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MiniEAI.Api.Controllers;

namespace miniEAI.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class QueryController : ApiController
{
    [HttpPost("/api/NotifyAppointmentOrder")]
    //public async Task<ResponseBase> NotifyAppointmentOrder([FromHeader] RequestHeader head, [FromBody] NotifyAppointmentOrderRequestModel body, CancellationToken cancellationToken)
    //    => await mediator.Send(body, cancellationToken);

    //(x, y) => _ = (X += x, Y += y);
    public async Task<ResponseBase> NotifyAppointmentOrder([FromHeader] RequestHeader head, [FromBody] NotifyAppointmentOrderRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = head;
        return await mediator.Send(body, cancellationToken);
    }
        
}
