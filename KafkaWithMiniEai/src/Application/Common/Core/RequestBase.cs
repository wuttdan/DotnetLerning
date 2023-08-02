using Domain.Common.Core;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Application.Common.Core;

public abstract class RequestBase : BracketModel
{
    [JsonIgnore]
    [JsonProperty(Order = -5)]
    public RequestHeader? Header { get; set; }
}
