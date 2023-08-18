using Application.Common.Models.Authorization;
using Application.Query.NotifyAppointmentOrder;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.Authorization;

public sealed class CommitAuthorizationRequestModel: AuthorizationRequestBase, IRequest<CommitAuthorizationResponseModel>
{
}
