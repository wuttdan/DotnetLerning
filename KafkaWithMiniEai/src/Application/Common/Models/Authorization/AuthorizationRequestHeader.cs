using Domain.Common.Core;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Application.Common.Models.Authorization;

public sealed class AuthorizationRequestHeader : BracketModel
{
    public const string XAcimVersion = "x-acim-version";
    public const string XAcimReqId = "x-acim-req-id";
    public const string XAcimSp = "x-acim-sp";
    public const string XAcimClientId = "x-acim-clientId";
    public const string XContentType = "Content-Type";

    [JsonIgnore]
    [FromHeader(Name = XAcimVersion)]
    public string? Version { get; set; }

    [JsonIgnore]
    [FromHeader(Name = XAcimReqId)]
    public string? ReqId { get; set; }

    [JsonIgnore]
    [FromHeader(Name = XAcimSp)]
    public string? AppName { get; set; }

    [JsonIgnore]
    [FromHeader(Name = XAcimClientId)]
    public string? ClientId { get; set; }

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

