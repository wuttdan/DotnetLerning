using MediatR;

namespace Application.Query.Microsite;

public sealed class DecomposeMicrositeUpdateHandler : IRequestHandler<DecomposeMicrositeUpdateRequestModel, DecomposeMicrositeUpdateResponseModel>
{
    public Task<DecomposeMicrositeUpdateResponseModel> Handle(DecomposeMicrositeUpdateRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}


