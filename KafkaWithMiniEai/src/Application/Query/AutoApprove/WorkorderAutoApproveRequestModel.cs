using Application.Common.Models.AutoApprove;
using MediatR;

namespace Application.Query.AutoApprove;

public sealed class WorkorderAutoApproveRequestModel : AutoApproveRequestBase, IRequest<WorkorderAutoApproveResponseModel>
{
}



