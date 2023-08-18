using Application.Common.Models.JobApprove;
using MediatR;

namespace Application.Query.JobApprove;

public sealed class WorkorderJobApproveRequestModel : JobApproveRequestBase, IRequest<WorkorderJobApproveResponseModel>
{
}
