using Application.Common.Models.NotifyAppointmentOrder;
using MediatR;

namespace Application.Query.NotifyAppointmentOrder;

public sealed class CommitNotifyAppointmentOrderHandler : IRequestHandler<CommitNotifyAppointmentOrderRequestModel, CommitNotifyAppointmentOrderResponseModel>
{
    public Task<CommitNotifyAppointmentOrderResponseModel> Handle(CommitNotifyAppointmentOrderRequestModel request, CancellationToken cancellationToken)
    {
        //insert into header table
        //then add to minieai-decompose
        throw new NotImplementedException();
    }
}