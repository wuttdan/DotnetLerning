using Application.Query.SendCheckInLate;

namespace Application.IntegrationTests;

public abstract partial class BaseIntergrationTest : IClassFixture<IntegrationTestWebAppFactory>
{
    protected CommitSendCheckInLateRequestModel TempSendCheckInLate => new()
    {
        MN_TRANSACTION_ID = "SOA202106071906591313_8f36",
        MN_INTERNET_ID = "8850051224",
        MN_ORDER_NO = "S-21-000370315",
        MN_APPOINTMENT_DATE = "2021-06-07",
        MN_SLOT = "19:00-22:00",
        MN_PACKAGE = "BROADBAND24 II Package 500/500 Mbps 599 THB 24 months",
        MN_PRODUCT_NAME = "FTTH/Playbox",
        MN_ORDER_TYPE = "MA",
        MN_CUSTOMER_NAME = "อี้ป๋อ หวัง",
        MN_CUSTOMER_CONTACT_1 = "0800000000",
        MN_CUSTOMER_CONTACT_2 = "NA",
        MN_CUSTOMER_CONTACT_3 = "NA",
        MN_CUSTOMER_ADDRESS = "240/3 ซ.ซอยลาดพร้าว 64 ถ.ถนนลาดพร้าว วังทองหลาง วังทองหลาง กรุงเทพ 10310",
        MN_CUSTOMER_LATITUDE = "13.918115",
        MN_CUSTOMER_LONGITUDE = "100.440881",
        MN_REGION = "BKK",
        MN_STAFF_CODE = "el08",
        MN_STAFF_NAME = "EL08",
        MN_STAFF_PHONE = "0800000000",
        MN_SUBCONTRACT_TEAM = "AFP_InstallAndMA_YUMEPII_YUMEPII_1112_FTH,FTB,FTR,PLB",
        MN_CHECKIN_LATE_TIME = "2021-06-07 20:00",
        MN_CHECKIN_LATE_REASON = "ติดปัญหา job ก่อนหน้า - เปลี่ยนโปรโมชั่น,เพิ่ม Mesh/Playbox",
        MN_REMARKS = "",
        MN_CURRENT_LATITUDE = "13.920400191341244",
        MN_CURRENT_LONGITUDE = "100.45081834480784",
        MN_CREATE_DATE = "2021-06-07 19:07",
        MN_CREATED_BY = "WuttDan"
    };
}