using MediatR;

namespace Application.Query.Microsite;

public class MicrositeHandler : IRequestHandler<MicrositeRequestModel, MicrositeResponseModel>
{
    public Task<MicrositeResponseModel> Handle(MicrositeRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
