using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MiniEAI.Api.Controllers;

public abstract class ApiController : ControllerBase
{
    protected readonly ILogger _logger = null!;
    protected readonly IMediator _mediator = null!;

    public ILogger Logger => _logger ?? HttpContext.RequestServices.GetRequiredService<ILogger>();
    public IMediator Mediator => _mediator ?? HttpContext.RequestServices.GetRequiredService<IMediator>();
}
