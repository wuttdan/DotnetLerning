using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.NotifyAppointmentOrder;

public class NotifyAppointmentOrderHandler : IRequestHandler<NotifyAppointmentOrderRequestModel, NotifyAppointmentOrderResponseModel>
{
    public Task<NotifyAppointmentOrderResponseModel> Handle(NotifyAppointmentOrderRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}