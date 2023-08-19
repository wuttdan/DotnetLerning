using Domain.Common.Core;
using Newtonsoft.Json;

namespace Application.Common.Core;

public abstract class RequestBase : BracketModel
{
    [JsonIgnore]
    [JsonProperty(Order = -5)]
    public RequestHeader? Header { get; set; }

    [JsonIgnore]
    public string TransactionId => Header?.TransactionId ?? string.Empty;
    [JsonIgnore]
    public string AppSource => Header?.AppSource ?? AppConstant.SystemName;
    [JsonIgnore]
    public string AppTarget => Header?.AppDestination ?? AppConstant.SystemName;
}
