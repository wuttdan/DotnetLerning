using MediatR;

namespace Application.Query.NotifyAppointmentOrder;

public sealed class DecomposeNotifyAppointmentOrderHandler : IRequestHandler<DecomposeNotifyAppointmentOrderRequestModel, DecomposeNotifyAppointmentOrderResponseModel>
{
    public Task<DecomposeNotifyAppointmentOrderResponseModel> Handle(DecomposeNotifyAppointmentOrderRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}