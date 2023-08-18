using Application.Common.Models.NotifyAppointmentOrder;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.NotifyAppointmentOrder;

public sealed class CommitNotifyAppointmentOrderRequestModel: NotifyAppointmentOrderRequestBase, IRequest<CommitNotifyAppointmentOrderResponseModel>
{
}
