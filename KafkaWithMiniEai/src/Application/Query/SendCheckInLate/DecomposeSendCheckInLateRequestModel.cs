using Application.Common.Models.SendCheckInLate;
using MediatR;

namespace Application.Query.SendCheckInLate;

public sealed class DecomposeSendCheckInLateRequestModel : SendCheckInLateRequestBase, IRequest<DecomposeSendCheckInLateResponseModel>
{
}
