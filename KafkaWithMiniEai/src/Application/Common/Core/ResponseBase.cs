using Domain.Common.Core;
using Newtonsoft.Json;

namespace Application.Common.Core;

public abstract class ResponseBase : BracketModel
{
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Order = -10)]
    public string? RESULT_CODE { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Order = -9)]
    public string? RESULT_DESC { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Order = 98)]
    public string? TRANSACTION_ID { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore, Order = 99)]
    public dynamic? RESULT_DATA { get; set; }

    public void AsSuccess(string resultDesc = "Success", string resultCode = "20000")
    {
        RESULT_CODE = resultCode;
        RESULT_DESC = resultDesc;
    }
    public void AsError(string resultDesc = "MiniEAI Error", string resultCode = "50000")
    {
        RESULT_CODE = resultCode;
        RESULT_DESC = resultDesc;
    }
}