using Application.Common.Models.Microsite;
using MediatR;

namespace Application.Query.Microsite;

public sealed class WorkorderMicrositeUpdateRequestModel : MicrositeRequestBase, IRequest<WorkorderMicrositeUpdateResponseModel>
{
}
