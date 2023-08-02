using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MiniEAI.Api.Controllers;

public abstract class ApiController : ControllerBase
{
    protected readonly ILogger _logger = null!;
    protected readonly IMediator _mediator = null!;

    public ILogger logger => _logger ?? HttpContext.RequestServices.GetRequiredService<ILogger>();
    public IMediator mediator => _mediator ?? HttpContext.RequestServices.GetRequiredService<IMediator>();
}
