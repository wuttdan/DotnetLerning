using Application.Common.Models.JobApprove;
using MediatR;

namespace Application.Query.JobApprove;

public sealed class CommitJobApproveRequestModel : JobApproveRequestBase, IRequest<CommitJobApproveResponseModel>
{
}
