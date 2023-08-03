using Application.Common.Core;
using MediatR;

namespace Application.Query.AutoApprove;

public class AutoApproveRequestModel : RequestBase, IRequest<AutoApproveResponseModel>
{
}
