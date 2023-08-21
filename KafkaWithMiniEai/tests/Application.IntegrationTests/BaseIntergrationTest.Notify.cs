using Application.Common.Interfaces;
using Application.Common.Models.NotifyAppointmentOrder;
using Application.Query.NotifyAppointmentOrder;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Application.IntegrationTests;

public abstract partial class BaseIntergrationTest : IClassFixture<IntegrationTestWebAppFactory>
{
    protected CommitNotifyAppointmentOrderRequestModel TempNotifyInstall => new ()
    {
        FIBRENET_ID = "8800000000",
        TYPE_OPER_DATE = "YYYY-MM-DD HH:mm:ss",
        MSG_SEQ_ID = "0000",
        TYPE = "AAAAAAAAA",
        INSTALL_ORDER = new NotifyAppointmentOrderInstall
        {
            TASK_ORDER_NO = "210927151757678917",
            FIBRENET_ID = "8803204137",
            CUSTOMER_NAME = "เสาวลักษ์ บุญเสนอ",
            PRODUCT_NAME = "FTTHxxxxx",
            JOB_PRIORITY = "Normal Job",
            CONTACT_PERSON_NAME = "เสาวลักษ์ บุญเสนอ",
            CONTACT_MOBILE_PHONE1 = "0800000001",
            CONTACT_MOBILE_PHONE2 = "0800000002",
            CONTACT_MOBILE_PHONE3 = "0800000003",
            ROUTER_NUM = "router_num",
            SERVICE_PACK = "POWER4 Mini Package 200/200 Mbps 399 THB for 12 months",
            TOTAL_FEE = "ไม่มี",
            PLAYBOX_CONTENT = "this is test playbox_content",
            INSTALLATION_ADDRESS = "264 หมู่9 หนองกุงใหญ่ กระนวน ขอนแก่น 40170",
            ONTOP_PACK = "this is test ontop_pack",
            REPLACE_ONT_FLAG = "this is test replace_ont_flag",
            FBSS_ORDER_NO = "9618950383_207530775.2",
            ACCESS_MODE = "FTTH",
            ORDER_TYPE = "New Connection",
            APPOINTMENT_TIMESLOT = "18:00-21:00",
            EVENTFLOW_FLAG = "eventflow_flag",
            CUSTOMER_ORDER_NO = "R2108001147956_106623303",
            APPOINTMENT_DATE = "2021-09-29",
            REPLACE_ROUTER_FLAG = "replace_router_flag",
            BRAND = "FMC",
            SERVICE_LEVEL = "this is test service_level",
            INSTALLATION_LATITUDE = "16.634603",
            INSTALLATION_LONGITUDE = "103.072795",
            JOB_STATE = "Prepare",
            SERVICE_ONTOP = new() 
            { 
                "0VOIP", 
                "0IPTV" 
            },
            FEE_LIST = new() 
            { 
                "ค่าธรรมเนียมแรกเข้า 0 บาท",
                "ค่าธรรมเนียมแรกเข้า 99 บาท" 
            },
            CRM_SUBCONTRACT_REMARKS = new()
            {
                new()
                {
                    REMARK_DATE = "2021-09-27 15:15:58",
                    AUTHOR = "CRM",
                    SUBCONTRACT_REMARKS = "อย่าลืมหยิบซิม AIS ไปให้ลูกค้าด้วยนะ (LC=1003944)"
                },
                new()
                {
                    REMARK_DATE = "9999-09-27 00:00:00",
                    AUTHOR = "Admin",
                    SUBCONTRACT_REMARKS = "Originating from within the African-American community."
                }
            },
            WFM_SUBCONTRACT_REMARKS = new()
            {
                new()
                {
                    REMARK_DATE = "2020-12-25 16:55:19",
                    AUTHOR = "WFMRemark",
                    SUBCONTRACT_REMARKS = "ฝากหากล่องเครื่องมาด้วยนะคับ พอดีที่ออฟฟิสไม่มีให้",
                },
                new()
                {
                    REMARK_DATE = "9999-09-27 00:00:00",
                    AUTHOR = "Admin",
                    SUBCONTRACT_REMARKS = "Black Lives Matter is an international human rights movement.",
                }
            },
            STAFF_LIST = new()
            {
                new()
                {
                    STAFF_PROFILE_PICTURE_FILENAME = "STAFF 1",
                    STAFF_LONGITUDE = "STAFF 1",
                    STAFF_PHONE = "STAFF 1",
                    STAFF_ROLE = "STAFF 1",
                    STAFF_NAME = "STAFF 1",
                    STAFF_LATITUDE = "STAFF 1",
                    STAFF_CODE = "STAFF 1",
                    STAFF_EMAIL = "STAFF 1",
                    COMPANY_LIST = new()
                    {
                        new()
                        {
                            COMPANY_NAME = "COMPANY 11",
                            LOCATION_CODE = "COMPANY 11",
                            STORAGE_LOCATION = "COMPANY 11",
                            VENDOR_CODE = "COMPANY 11",
                            COMPANY_ID = "COMPANY 11",
                            TEAM_LIST = new() 
                            { 
                                new() 
                                {
                                    SHIP_TO = "TEAM 111",
                                    TEAM_NAME = "TEAM 111",
                                    LOCATION_CODE = "TEAM 111",
                                    STORAGE_LOCATION = "TEAM 111",
                                    VENDOR_CODE = "TEAM 111",
                                    TEAM_SERVICE = "TEAM 111",
                                    TEAM_ID = "TEAM 111"
                                },
                                new()
                                {
                                    SHIP_TO = "TEAM 112",
                                    TEAM_NAME = "TEAM 112",
                                    LOCATION_CODE = "TEAM 112",
                                    STORAGE_LOCATION = "TEAM 112",
                                    VENDOR_CODE = "TEAM 112",
                                    TEAM_SERVICE = "TEAM 112",
                                    TEAM_ID = "TEAM 112"
                                }
                            }
                        },
                        new ()
                        {
                            COMPANY_NAME = "COMPANY 12",
                            LOCATION_CODE = "COMPANY 12",
                            STORAGE_LOCATION = "COMPANY 12",
                            VENDOR_CODE = "COMPANY 12",
                            COMPANY_ID = "COMPANY 12",
                            TEAM_LIST = new()
                            {
                                new()
                                {
                                    SHIP_TO = "TEAM 121",
                                    TEAM_NAME = "TEAM 121",
                                    LOCATION_CODE = "TEAM 121",
                                    STORAGE_LOCATION = "TEAM 121",
                                    VENDOR_CODE = "TEAM 121",
                                    TEAM_SERVICE = "TEAM 121",
                                    TEAM_ID = "TEAM 121"
                                },
                                new()
                                {
                                    SHIP_TO = "TEAM 122",
                                    TEAM_NAME = "TEAM 122",
                                    LOCATION_CODE = "TEAM 122",
                                    STORAGE_LOCATION = "TEAM 122",
                                    VENDOR_CODE = "TEAM 122",
                                    TEAM_SERVICE = "TEAM 122",
                                    TEAM_ID = "TEAM 122"
                                }
                            }
                        }
                    }
                },
                //staff[0]
                new NotifyAppointmentOrderStaff
                {
                    STAFF_PROFILE_PICTURE_FILENAME = "STAFF 2",
                    STAFF_LONGITUDE = "STAFF 2",
                    STAFF_PHONE = "STAFF 2",
                    STAFF_ROLE = "STAFF 2",
                    STAFF_NAME = "STAFF 2",
                    STAFF_LATITUDE = "STAFF 2",
                    STAFF_CODE = "STAFF 2",
                    STAFF_EMAIL = "STAFF 2",
                    COMPANY_LIST = new()
                    {
                        new ()
                        {
                            COMPANY_NAME = "COMPANY 21",
                            LOCATION_CODE = "COMPANY 21",
                            STORAGE_LOCATION = "COMPANY 21",
                            VENDOR_CODE = "COMPANY 21",
                            COMPANY_ID = "COMPANY 21",
                            TEAM_LIST = new()
                            {
                                new()
                                {
                                    SHIP_TO = "TEAM 211",
                                    TEAM_NAME = "TEAM 211",
                                    LOCATION_CODE = "TEAM 211",
                                    STORAGE_LOCATION = "TEAM 211",
                                    VENDOR_CODE = "TEAM 211",
                                    TEAM_SERVICE = "TEAM 211",
                                    TEAM_ID = "TEAM 211"
                                },
                                new()
                                {
                                    SHIP_TO = "TEAM 212",
                                    TEAM_NAME = "TEAM 212",
                                    LOCATION_CODE = "TEAM 212",
                                    STORAGE_LOCATION = "TEAM 212",
                                    VENDOR_CODE = "TEAM 212",
                                    TEAM_SERVICE = "TEAM 212",
                                    TEAM_ID = "TEAM 212"
                                }
                            }
                        }
                    }
                }
                //staff[1]
            },
            //staff_list
            RESOURCE = new()
            {
                SPLITTER_NAME_PRIMARY = "P00_SP01_18:1/3",
                DROP_WIRE_DISTANCE = "N/A",
                NEW_DROP_WIRE_ID = "8803204137",
                SPLITTER_DISTANCE = "0",
                DEVICE_MODEL = "MA5608T",
                OLT_NAME = "OX_NKGYM_ZZ_01HW",
                ONU = "ONT4917250",
                UPLINK_RATE = "200Mbps",
                DSLAM_PORT = "N/A",
                ACTIVATION_ID = "2109118540",
                CPE_INSTALLATION = "CPE",
                SP2_OUT_PORT = "KKN0104-003:1/4",
                SP2_RUNNING_STATE = "Available",
                MDF_OUT_PORT = "N/A",
                REUSE_FLAG = "N/A",
                GEMPORT = "10(HSI over FTTH(GPON))",
                SPLITTER_PORT = "KKN0104-003:1/4",
                CPE_SN = "N/A",
                PASSWORD = "97QY8JQ3M7",
                ONU_ID = "17",
                SP1_OUT_PORT = "P00_SP01_18:1/3",
                ONU_UPLINK_PORT = "ONT4917250:eth/1",
                IP_ADDRESS = "10.2.135.166",
                STANDARD_ADDRESS_NAME = "Nong Kung Yai 40170 / BAN NONG KUNG YAI",
                END_POINT_LONGITUDE = "N/A",
                ODF_OUT = "ODF_NKGYM_01:1/1",
                ODF_IN = "ODF_NKGYM_01:0/1",
                CPE_MODEL = "HG8010H(ONU)",
                DOWNLINK_RATE = "200Mbps",
                SP1_RUNNING_STATE = "Available",
                ONU_MODEL = "HG8010H(ONU)",
                SP1_IN_PORT = "P00_SP01_18:0/1",
                SP2_LONGITUDE = "103.076752",
                SERVICE = "FTTH",
                SP1_FIBER_CORE = "P00_SP01_18---P00_SP02_06_18:4",
                EXISTING_DROP_WIRE_ID = "N/A",
                DSLAM_MANUFACTURER = "N/A",
                END_POINT_LATITUDE = "N/A",
                SP2_LATITUDE = "16.636861",
                SP2_DISTANCE = "0",
                SVLAN = "2569(HSI over FTTH(GPON))",
                SP1_LATITUDE = "16.634482",
                SP1_LONGITUDE = "103.076439",
                TCONT = "0(HSI over FTTH(GPON))",
                CVLAN = "10(HSI over FTTH(GPON))",
                SP2_IN_PORT = "KKN0104-003:0/1",
                ODF_FIBER_CORE = "ODF_NKGYM_01---P00_SP01_18:1",
                OLT_MANUFACTURER = "HUAWEI",
                OLT_PON_PORT = "OX_NKGYM_ZZ_01HW:0-0-0-0"
            }
        }//install
    };
}