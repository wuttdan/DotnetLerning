using MediatR;

namespace Application.Query.Microsite;

public sealed class WorkorderMicrositeHandler : IRequestHandler<WorkorderMicrositeRequestModel, WorkorderMicrositeResponseModel>
{
    public Task<WorkorderMicrositeResponseModel> Handle(WorkorderMicrositeRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}


