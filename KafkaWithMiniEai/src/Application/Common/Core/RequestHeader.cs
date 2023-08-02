using Microsoft.AspNetCore.Mvc;
using Domain.Common.Core;
using Newtonsoft.Json;

namespace Application.Common.Core;

public sealed class RequestHeader : BracketModel
{
    [JsonIgnore]
    [FromHeader(Name = "Transaction-Id")]
    public string? TransactionId { get; set; }
    [JsonIgnore]
    [FromHeader(Name = "App-Source")]
    public string? AppSource { get; set; }
    [JsonIgnore]
    [FromHeader(Name = "App-Destination")]
    public string? AppDestination { get; set; }


    private string? _Token;
    [JsonIgnore]
    [FromHeader(Name = "Authorization")]
    public string Token
    {
        get
        {
            return string.IsNullOrEmpty(_Token)
                    ? string.Empty
                    : _Token.Replace("Bearer", string.Empty).Replace("Basic", string.Empty).Trim();
        }

        set
        {
            _Token = value;
        }
    }
}
