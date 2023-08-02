using Application.Common.Core;
using Application.Query.NotifyAppointmentOrder;
using Microsoft.AspNetCore.Mvc;
using MiniEAI.Api.Controllers;

namespace miniEAI.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class QueryController : ApiController
{
    [HttpPost("/api/NotifyAppointmentOrder")]
    public async Task<ResponseBase> NotifyAppointmentOrder([FromHeader] RequestHeader header, [FromBody] NotifyAppointmentOrderRequestModel body, CancellationToken cancellationToken)
    {
        body.Header = header;
        return await mediator.Send(body, cancellationToken);
    }

}
