using Application.Common.Core;
using MediatR;

namespace Application.Query.SendCheckInLate;

public class SendCheckInLateRequestModel : RequestBase, IRequest<SendCheckInLateResponseModel>
{
}
