using Application.Common.Core;
using Application.Query.NotifyAppointmentOrder;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Application.Common.Models.NotifyAppointmentOrder;

public class NotifyAppointmentOrderRequestBase : RequestBase
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

    public CommitNotifyAppointmentOrderResponseModel CreateResponse(string resultDesc = "", string resultCode = "")
    {
        return new CommitNotifyAppointmentOrderResponseModel
        {
            TRANSACTION_ID = TransactionId,
            FIBRENET_ID = FIBRENET_ID,
            TYPE = TYPE,
            RESULT_CODE = resultCode,
            RESULT_DESC = resultDesc
        };
    }

    public DecomposeNotifyAppointmentOrderRequestModel ToDecompose()
    {
        return new DecomposeNotifyAppointmentOrderRequestModel
        {
            Header = Header,
            FIBRENET_ID = FIBRENET_ID,
            TYPE = TYPE,
            TYPE_OPER_DATE = TYPE_OPER_DATE,
            MSG_SEQ_ID = MSG_SEQ_ID,
            INSTALL_ORDER = INSTALL_ORDER,
            MA_ORDER = MA_ORDER
        };
    }

    public WorkorderNotifyAppointmentOrderRequestModel ToWorkorder()
    {
        return new WorkorderNotifyAppointmentOrderRequestModel
        {
            Header = Header,
            FIBRENET_ID = FIBRENET_ID,
            TYPE = TYPE,
            TYPE_OPER_DATE = TYPE_OPER_DATE,
            MSG_SEQ_ID = MSG_SEQ_ID,
            INSTALL_ORDER = INSTALL_ORDER,
            MA_ORDER = MA_ORDER
        };
    }

    public string GetOrderType()
    {
        return (INSTALL_ORDER != null) ? "INSTALL_ORDER" : "MA_ORDER";
    }

    public string? GetRequestNo()
    {
        if (INSTALL_ORDER != null)
        {
            return INSTALL_ORDER?.CUSTOMER_ORDER_NO;
        }
        return MA_ORDER?.SIEBEL_REQUEST_NO;
    }
}