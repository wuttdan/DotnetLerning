namespace Application.Common.Core;

public class CommonResponseModel : ResponseBase
{
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