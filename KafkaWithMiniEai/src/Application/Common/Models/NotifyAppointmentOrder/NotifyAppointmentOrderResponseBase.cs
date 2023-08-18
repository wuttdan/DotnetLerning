using Application.Common.Core;
using Newtonsoft.Json;

namespace Application.Common.Models.NotifyAppointmentOrder;

public class NotifyAppointmentOrderResponseBase : ResponseBase
{
    [JsonProperty(Order = -8)]
    public string? FIBRENET_ID { get; set; }

    [JsonProperty(Order = -7)]
    public string? TYPE { get; set; }
}