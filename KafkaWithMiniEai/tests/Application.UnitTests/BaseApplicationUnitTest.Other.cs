using Application.Query.JobApprove;
using Application.Query.JobIncomplete;
using Application.Query.Microsite;
using Application.Query.SendCheckInLate;

namespace Application.UnitTests;

public abstract partial class BaseApplicationUnitTest
{
    protected CommitJobIncompleteRequestModel GetTempJobIncomplete()
    {
        return new()
        {
            Header = GetCommonRequestHeader(),
            internetNo = "8802247432",
            orderNo = "SRT2022052000162752",
            reason = "การแก้ไขไม่เรียบร้อย เข้าดำเนินการแก้ไขใหม่",
            subReason = "บ้านเลขที่ไม่ตรง",
            remark = "รูปถ่ายเช็คอินไม่ถูกต้อง (บ้านเลขที่ไม่ตรง) **ลูกค้าแจ้งที่อยู่ในการติดตั้งคือ 135**",
            attributeValue = "HOME_CHECK_IN,AP2",
            attributeDesc = "Home Check In,ใบสมัครแผ่นที่ 2",
            incompleteTime = "2018-10-17 15:17:46"
        };
    }

    protected CommitJobApproveRequestModel GetTempJobApprove()
    {
        return new()
        {
            Header = GetCommonRequestHeader(),
            internetNo = "8802247432",
            orderNo = "8653728258_1964692467.2",
            approveTime = "2018-10-17 15:17:46"
        };
    }
}