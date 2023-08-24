using Domain.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.Authorization;

public class CommonAuthorizationResponseModel : BracketModel
{
    public string? code { get; set; }
    public string? desc { get; set; }
}