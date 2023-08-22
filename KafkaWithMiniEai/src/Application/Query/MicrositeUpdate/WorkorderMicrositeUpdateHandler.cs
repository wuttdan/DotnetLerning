using MediatR;

namespace Application.Query.Microsite;

public sealed class WorkorderMicrositeUpdateHandler : IRequestHandler<WorkorderMicrositeUpdateRequestModel, WorkorderMicrositeUpdateResponseModel>
{
    public Task<WorkorderMicrositeUpdateResponseModel> Handle(WorkorderMicrositeUpdateRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}


