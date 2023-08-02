using MediatR;

namespace Application.Query.NotifyAppointmentOrder;

public class NotifyAppointmentOrderHandler : IRequestHandler<NotifyAppointmentOrderRequestModel, NotifyAppointmentOrderResponseModel>
{
    public Task<NotifyAppointmentOrderResponseModel> Handle(NotifyAppointmentOrderRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}