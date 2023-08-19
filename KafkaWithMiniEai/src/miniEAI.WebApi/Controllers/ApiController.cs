using Application.Common.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MiniEAI.Api.Controllers;

public abstract class ApiController : ControllerBase
{
    protected readonly ILogger _logger = null!;
    protected readonly IMediator _mediator = null!;
    protected readonly IPrimaryDbContext _primaryDb = null!;
    protected readonly ISecondaryDbContext _secondaryDb = null!;

    public ILogger Logger => _logger ?? HttpContext.RequestServices.GetRequiredService<ILogger>();
    public IMediator Mediator => _mediator ?? HttpContext.RequestServices.GetRequiredService<IMediator>();
    public IPrimaryDbContext PrimaryDb => _primaryDb ?? HttpContext.RequestServices.GetRequiredService<IPrimaryDbContext>();
    public ISecondaryDbContext SecondaryDb => _secondaryDb ?? HttpContext.RequestServices.GetRequiredService<ISecondaryDbContext>();
}
