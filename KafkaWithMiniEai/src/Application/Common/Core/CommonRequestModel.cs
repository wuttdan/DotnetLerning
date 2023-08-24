using Application.Common.Interfaces;
using Application.Query.NotifyAppointmentOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Core;

public class CommonRequestModel: RequestBase
{
    public virtual CommonResponseModel CreateResponse(string resultDesc = "", string resultCode = "")
    {
        return new CommonResponseModel
        {
            TRANSACTION_ID = Header?.TransactionId,
            RESULT_CODE = resultCode,
            RESULT_DESC = resultDesc
        };
    }
}