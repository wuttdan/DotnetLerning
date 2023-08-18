﻿using Application.Common.Models.NotifyAppointmentOrder;
using MediatR;

namespace Application.Query.NotifyAppointmentOrder;

public sealed class WorkorderNotifyAppointmentOrderRequestModel : NotifyAppointmentOrderRequestBase, IRequest<WorkorderNotifyAppointmentOrderResponseModel>
{
}