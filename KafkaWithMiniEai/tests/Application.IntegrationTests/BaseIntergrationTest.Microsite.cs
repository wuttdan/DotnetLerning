using Application.Query.Microsite;
using Application.Query.SendCheckInLate;

namespace Application.IntegrationTests;

public abstract partial class BaseIntergrationTest : IClassFixture<IntegrationTestWebAppFactory>
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
}