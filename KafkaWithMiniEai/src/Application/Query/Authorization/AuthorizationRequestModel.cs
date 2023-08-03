using Application.Common.Core;
using Application.Common.Models.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace Application.Query.Authorization;

public class AuthorizationRequestModel : IRequest<AuthorizationResponseModel>
{
    public AuthorizationRequestHeader? Header { get; set; }
    /// <summary>
    /// A : Add
    /// U : Update
    /// D : Delete
    /// </summary>
    [JsonIgnore]
    public string? ACTION { get; set; }

    public void Prepare([NotNull] AuthorizationRequestHeader header, string method, string path)
    {
        Header = header;
        if (path.EndsWith("/del"))
        {
            ACTION = "D";//delete
        }
        else if (method.Equals("post", StringComparison.OrdinalIgnoreCase))
        {
            ACTION = "A";//insert, add
        }
        else if (method.Equals("put", StringComparison.OrdinalIgnoreCase))
        {
            ACTION = "U";//update
        }
    }
}
