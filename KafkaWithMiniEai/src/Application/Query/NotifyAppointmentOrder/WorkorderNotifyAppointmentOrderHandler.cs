using MediatR;

namespace Application.Query.NotifyAppointmentOrder;

public sealed class WorkorderNotifyAppointmentOrderHandler : IRequestHandler<WorkorderNotifyAppointmentOrderRequestModel, WorkorderNotifyAppointmentOrderResponseModel>
{
    public Task<WorkorderNotifyAppointmentOrderResponseModel> Handle(WorkorderNotifyAppointmentOrderRequestModel request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}