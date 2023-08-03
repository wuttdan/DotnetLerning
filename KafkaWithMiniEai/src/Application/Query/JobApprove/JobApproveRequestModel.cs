using Application.Common.Core;
using MediatR;

namespace Application.Query.JobApprove;

public class JobApproveRequestModel : RequestBase, IRequest<JobApproveResponseModel>
{
}
