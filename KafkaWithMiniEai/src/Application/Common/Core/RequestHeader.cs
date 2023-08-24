using Domain.Common.Core;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Application.Common.Core;

public sealed class RequestHeader : BracketModel
{
    public const string XTransactionId = "Transaction-Id";
    public const string XAppSource = "App-Source";
    public const string XAppDestination = "App-Destination";
    public const string XContentType = "Content-Type";

    [JsonIgnore]
    [FromHeader(Name = XTransactionId)]
    public string? TransactionId { get; set; }

    [JsonIgnore]
    [FromHeader(Name = XAppSource)]
    public string? AppSource { get; set; }

    [JsonIgnore]
    [FromHeader(Name = XAppDestination)]
    public string? AppDestination { get; set; }

    [JsonIgnore]
    [FromHeader(Name = XContentType)]
    public string? ContentType { get; set; }

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
