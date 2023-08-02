using Application.Common.Core;
using Application.Common.Models.NotifyAppointmentOrder;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Application.Query.NotifyAppointmentOrder;

public class NotifyAppointmentOrderRequestModel : RequestBase, IRequest<NotifyAppointmentOrderResponseModel>
{
    [FromBody]
    [JsonProperty(Order = -4)]
    public string? FIBRENET_ID { get; set; }

    [FromBody]
    [JsonProperty(Order = -3)]
    public string? TYPE { get; set; }

    [FromBody]
    [JsonProperty(Order = -2)]
    public string? TYPE_OPER_DATE { get; set; }

    [FromBody]
    [JsonProperty(Order = -1)]
    public string? MSG_SEQ_ID { get; set; }

    [FromBody]
    [JsonProperty(Order = 0, NullValueHandling = NullValueHandling.Ignore)]
    public NotifyAppointmentOrderInstall? INSTALL_ORDER { get; set; }

    [FromBody]
    [JsonProperty(Order = 1, NullValueHandling = NullValueHandling.Ignore)]
    public NotifyAppointmentOrderMA? MA_ORDER { get; set; }
}