using Domain.Common.Core;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Application.Common.Models.Authorization;

public sealed class AuthorizationRequestHeader : BracketModel
{
    [JsonIgnore]
    [FromHeader(Name = "x-acim-version")]
    public string? Version { get; set; }
    [JsonIgnore]
    [FromHeader(Name = "x-acim-req-id")]
    public string? ReqId { get; set; }
    [JsonIgnore]
    [FromHeader(Name = "x-acim-sp")]
    public string? AppName { get; set; }
    [JsonIgnore]
    [FromHeader(Name = "x-acim-clientId")]
    public string? ClientId { get; set; }
}
