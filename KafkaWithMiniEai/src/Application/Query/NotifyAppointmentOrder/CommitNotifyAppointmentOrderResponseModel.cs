using Application.Common.Core;
using Application.Common.Models.NotifyAppointmentOrder;
using Newtonsoft.Json;

namespace Application.Query.NotifyAppointmentOrder;

public sealed class CommitNotifyAppointmentOrderResponseModel : CommonResponseModel
{
    [JsonProperty(Order = -8)]
    public string? FIBRENET_ID { get; set; }

    [JsonProperty(Order = -7)]
    public string? TYPE { get; set; }
}
