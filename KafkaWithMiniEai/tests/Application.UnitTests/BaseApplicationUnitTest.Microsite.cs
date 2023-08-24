using Application.Query.Microsite;
using Application.Query.SendCheckInLate;

namespace Application.UnitTests;

public abstract partial class BaseApplicationUnitTest
{
    protected CommitMicrositeRequestModel GetTempMicrosite()
    {
        return new()
        {
            Header = GetCommonRequestHeader(),
            USER = "old,serenade",
            SEGMENT = "individual",
            NUMBER_OF_USER = "1",
            RESIDENTIAL = "condo",
            TYPE_OF_USER = "internet,gaming",
            PACKAGE = "BROADBAND Package",
            PACKAGE_CODE = "P200300871",
            SPEED = "500_500",
            PLAYBOX_BUNDLE = "PLAYFamily",
            PLAYBOX_ADDON = "PLAYPremium",
            ROUTER_BUNDLE = "SuperMESHWiFi_1",
            ROUTER_ADDON = "SuperMESHWiFi_add1",
            PRICE = "899",
            FIRSTNAME = "test",
            LASTNAME = "vavn",
            TELEPHONE = "0959033031",
            EMAIL = "warodom@hotmail.com",
            ADDRESS = "11 ซ.ไทยานนท์ 17/1",
            SUBDISTRICT = "ท่าตะเภา",
            DISTRICT = "เมืองชุมพร",
            PROVINCE = "ชุมพร",
            ZIPCODE = "86000",
            MEDIA_STREAMING = "netflix,LINE TV",
            USER_JOURNEY = "index,newuser",
            CID = "outbound Voice IVR-organic media",
            COMPLETE = "true"
        };
    }

    protected CommitMicrositeUpdateRequestModel GetTempMicrositeUpdate()
    {
        return new()
        {
            Header = GetCommonRequestHeader(),
            ORDER_NO = "MIC-202209241454306851373",
            ORDER_CHANNEL = "CC",
            IS_CONTACT_CUSTOMER = "08453454354",
            IS_IN_COVERAGE = "Yes",
            USER_ACTION = "test",
            DATE_ACTION = "2020-11-26 19:22:07",
            ORDER_PRE_REGISTER = "FBB-NW-201612-000066",
            STATUS_ORDER = "Completed",
            REMARK_NOTE = ""
        };
    }
}