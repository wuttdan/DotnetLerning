using Application.Common.Interfaces;
using Domain.Entities.Minieai;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IntegrationTests;

public static class IntegrationTestSeeding
{
    private static readonly string CreatedBy = "IntegrationTest";
    public static void Seeding(this IPrimaryDbContext primaryDb)
    {
        var executionStrategy = primaryDb.Db.CreateExecutionStrategy();
        executionStrategy.Execute(() =>
        {
            using (var transaction = primaryDb.Db.BeginTransaction())
            {
                try
                {
                    if (!primaryDb.FbbTblMappingIds.Any())
                    {
                        primaryDb.SeedMappingId();
                    }
                    if (!primaryDb.FbbTblMappingWos.Any())
                    {
                        primaryDb.SeedMappingWo();
                    }
                    if (!primaryDb.FbbTblMappingExternals.Any())
                    {
                        primaryDb.SeedMappingExternal();
                    }
                    if (!primaryDb.FbbTblListOfValues.Any())
                    {
                        primaryDb.SeedListOfValue();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error occurred Seeding: {ex.ToString()}");
                    transaction.Rollback();
                }
            }
        });
    }
    private static void SeedMappingId(this IPrimaryDbContext primaryDb)
    {
        List<FbbTblMappingId> allMappingId = new()
        {
            new(){ TypeEvent="evSendCheckINLate", AppSource="FOA", ResponseTime="IMMEDIATELY", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ TypeEvent="evNotifyAppointmentOrder", AppSource="FBSS", ResponseTime="IMMEDIATELY", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ TypeEvent="evMicrosite", AppSource="Microsite", ResponseTime="IMMEDIATELY", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ TypeEvent="evMicrositeUpdate", AppSource="IM, Sale Portal", ResponseTime="IMMEDIATELY", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ TypeEvent="evAuthorization", AppSource="ACIM", ResponseTime="WAIT", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ TypeEvent="evAutoApprove", AppSource="FBBPortalBatch", ResponseTime="IMMEDIATELY", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ TypeEvent="evJobIncomplete", AppSource="FBSS SOA", ResponseTime="IMMEDIATELY", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ TypeEvent="evJobApprove", AppSource="FBSS SOA", ResponseTime="IMMEDIATELY", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
        };
        primaryDb.FbbTblMappingIds.AddRange(allMappingId);
        primaryDb.SaveChanges();
    }
    private static void SeedMappingWo(this IPrimaryDbContext primaryDb)
    {
        List<FbbTblMappingWo> allMappingWo = new()
        {
            new(){ MappingId=1, Destination="FBB Portal", ExternalId="SENDCHECINLATE_FBB_PORTAL", TypeExternal="SENDCHECINLATE_FBB_PORTAL", SeqNum=1, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=1, Destination="Line Connect", ExternalId="SENDCHECINLATE_LINE_CONNECT", TypeExternal="SENDCHECINLATE_LINE_CONNECT", SeqNum=2,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=1, Destination="IVR Push Trigger", ExternalId="SENDCHECINLATE_IVR", TypeExternal="SENDCHECINLATE_IVR", SeqNum=3,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=1, Destination="SMS Portal", ExternalId="SENDCHECINLATE_SMS", TypeExternal="SENDCHECINLATE_SMS", SeqNum=4,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=1, Destination="Add Point Portal", ExternalId="SENDCHECINLATE_ADD_POINT", TypeExternal="SENDCHECINLATE_ADD_POINT", SeqNum=5,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=2, Destination="SOA", ExternalId="NOTIFYAPPOINTMENTORDER_SOA", TypeExternal="NOTIFYAPPOINTMENTORDER_SOA", SeqNum=1,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=2, Destination="Workforce Tracking System", ExternalId="NOTIFYAPPOINTMENTORDER_WFTS", TypeExternal="NOTIFYAPPOINTMENTORDER_WFTS", SeqNum=2,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=3, Destination="WBB Context", ExternalId="MICROSITE_WBB", TypeExternal="MICROSITE_WBB", SeqNum=1,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=3, Destination="Sale Portal", ExternalId="MICROSITE_SALE", TypeExternal="MICROSITE_SALE", SeqNum=3,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=3, Destination="IM", ExternalId="MICROSITE_IM", TypeExternal="MICROSITE_IM", SeqNum=2,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=4, Destination="IM, Sale Portal", ExternalId="MICROSITE_UPDATE", TypeExternal="MICROSITE_UPDATE", SeqNum=1,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=5, Destination="FBB Web", ExternalId="AUTHORIZATION_WBB", TypeExternal="AUTHORIZATION_WBB", SeqNum=1,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=5, Destination="FBB Portal", ExternalId="AUTHORIZATION_FBBPORTAL", TypeExternal="AUTHORIZATION_FBBPORTAL", SeqNum=2,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=5, Destination="FBB Workflow", ExternalId="AUTHORIZATION_WORKFLOW", TypeExternal="AUTHORIZATION_WORKFLOW", SeqNum=3,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=5, Destination="FBSS Service", ExternalId="AUTHORIZATION_FBSS", TypeExternal="AUTHORIZATION_FBSS", SeqNum=4,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=5, Destination="FBSS Query", ExternalId="AUTHORIZATION_FBSSQUERY", TypeExternal="AUTHORIZATION_FBSSQUERY", SeqNum=5,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=6, Destination="FBSS Confirm", ExternalId="AUTOAPPROVE_FBSSCONFIRM", TypeExternal="AUTOAPPROVE_FBSSCONFIRM", SeqNum=1,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=7, Destination="SOA", ExternalId="JOBINCOMPLETE_SOA", TypeExternal="JOBINCOMPLETE_SOA", SeqNum=1,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingId=8, Destination="SOA", ExternalId="JOBAPPROVE_SOA", TypeExternal="JOBAPPROVE_SOA", SeqNum=1,  Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
        };
        primaryDb.FbbTblMappingWos.AddRange(allMappingWo);
        primaryDb.SaveChanges();
    }
    private static void SeedMappingExternal(this IPrimaryDbContext primaryDb)
    {
        List<FbbTblMappingExternal> allMappingExternal = new()
        {
            new(){ MappingWo=1, ExternalId="SENDCHECINLATE_FBB_PORTAL", Typews="REST", EndpointName="FBB Portal", UrlEndpoint="https://staging-fbbportalws.ais.co.th/FBBPortalReceivedIVRServices/api/received", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=2, ExternalId="SENDCHECINLATE_LINE_CONNECT", Typews="WCF", EndpointName="Line Connect", UrlEndpoint="http://10.104.140.72:9095/LINEConnectWebservice/services/LINEConnectServicePort?wsdl", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=3, ExternalId="SENDCHECINLATE_IVR", Typews="REST", EndpointName="IVR", UrlEndpoint="http://10.104.244.160:8090/outboundCall", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=4, ExternalId="SENDCHECINLATE_SMS", Typews="REST", EndpointName="SMS Portal", UrlEndpoint="https://staging-fbbportalws.ais.co.th/FBBPortalReceivedIVRServices/api/sms", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=5, ExternalId="SENDCHECINLATE_ADD_POINT", Typews="REST", EndpointName="Add Point Portal", UrlEndpoint="https://staging-fbbportalws.ais.co.th/FBBPortalReceivedIVRServices/api/addpoint", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=6, ExternalId="NOTIFYAPPOINTMENTORDER_SOA", Typews="REST", EndpointName="Notify Appointment Order to SOA", UrlEndpoint="https://api.staging-fbbsoa.intra.ais/soa/v1/source/eai/job-order", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=7, ExternalId="NOTIFYAPPOINTMENTORDER_WFTS", Typews="REST", EndpointName="Notify Appointment Workforce Tracking System", UrlEndpoint="https://staging-wftsws.intra.ais/wfts/v1/miniEAI", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=8, ExternalId="MICROSITE_WBB", Typews="WCF", EndpointName="WBB Context", UrlEndpoint="https://staging-fixedbbws.ais.co.th/ExWebServices/FbbCpGwInterface.svc", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=9, ExternalId="MICROSITE_SALE", Typews="WCF", EndpointName="Sale Portal", UrlEndpoint="https://staging-fixedbbws.ais.co.th/ExWebServices/FbbCpGwInterface.svc", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=10, ExternalId="MICROSITE_IM", Typews="REST", EndpointName="IM", UrlEndpoint="http://10.138.20.114:8080/prweb/PRRestService/AISNIMCampaignContactList/Services/CreateCampaignContact", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=11, ExternalId="MICROSITE_UPDATE", Typews="WCF", EndpointName="WBB Context", UrlEndpoint="https://staging-fixedbbws.ais.co.th/ExWebServices/FbbCpGwInterface.svc", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=12, ExternalId="AUTHORIZATION_WBB", Typews="WCF", EndpointName="(SSO) FIXED BROADBAND", UrlEndpoint="https://staging-fixedbbws.ais.co.th/ExWebServices/FbbCpGwInterface.svc", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=13, ExternalId="AUTHORIZATION_FBBPORTAL", Typews="REST", EndpointName="(SSO) FBB Portal", UrlEndpoint="https://staging-fbbportalws.ais.co.th/externalapi/services/acimuser", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=14, ExternalId="AUTHORIZATION_WORKFLOW", Typews="WCF", EndpointName="(SSO) FBB Workflow System", UrlEndpoint="https://staging-airnetregws.ais.co.th/airnet-service/AIRInterfaceWorkflowService", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=15, ExternalId="AUTHORIZATION_FBSS", Typews="WCF", EndpointName="FBSS Authorization for SSO", UrlEndpoint="https://staging-api.fbss-order.intra.ais:8105/axis2/services/OrderService", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=16, ExternalId="AUTHORIZATION_FBSSQUERY", Typews="REST", EndpointName="(SSO) FBSS Query Portal", UrlEndpoint="https://staging-fbbportalws.ais.co.th/FBSSQueryRESTWebService/api/acimuser", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=17, ExternalId="AUTOAPPROVE_FBSSCONFIRM", Typews="REST", EndpointName="FBSS", UrlEndpoint="https://staging-api.fbss-wfm8.intra.ais:9807/wfm/ais/doServiceConfirm/v1", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=18, ExternalId="JOBINCOMPLETE_SOA", Typews="REST", EndpointName="Job Incomplete SOA", UrlEndpoint="https://api.staging-fbbsoa.intra.ais/soa/v1/source/eai/incomplete", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ MappingWo=19, ExternalId="JOBAPPROVE_SOA", Typews="REST", EndpointName="Job Approve SOA", UrlEndpoint="https://api.staging-fbbsoa.intra.ais/soa/v1/source/eai/approve", IsOnline="Y", RetryCount=2, SleepTimes=60, RequestTimeout=60, Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
        };
        primaryDb.FbbTblMappingExternals.AddRange(allMappingExternal);
        primaryDb.SaveChanges();
    }

    private static void SeedListOfValue(this IPrimaryDbContext primaryDb)
    {
        List<FbbTblListOfValue> allLov = new()
        {
            new(){ LovName="PREFIX_MA", LovValue1="SRT", LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="EXTERNAL_SERVICE", LovValue1="MN_OPTION", LovValue2="8", LovValue3="NULL", ActiveFlag="Y", ExternalId="SERVICE_SFF", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="EXTERNAL_SERVICE", LovValue1="MN_SOURCESYSTEM", LovValue2="AWN_WEB", LovValue3="NULL", ActiveFlag="Y", ExternalId="SERVICE_SFF", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="POINT_LATE", LovValue1="60", LovValue2="INSTALL", LovValue3="30", ActiveFlag="Y", ExternalId="SENDCHECINLATE_ADD_POINT", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="POINT_LATE", LovValue1="90", LovValue2="INSTALL", LovValue3="30", ActiveFlag="Y", ExternalId="SENDCHECINLATE_ADD_POINT", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="POINT_LATE", LovValue1="120", LovValue2="INSTALL", LovValue3="30", ActiveFlag="Y", ExternalId="SENDCHECINLATE_ADD_POINT", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="DEFAULT_SMS_LANGUAGE", LovValue1="THA", LovValue2="NULL", LovValue3="SERVICE_SFF", ActiveFlag="Y", ExternalId="EXTERNAL_SERVICE", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="POINT_LATE", LovValue1="60", LovValue2="INSTALL", LovValue3="30", ActiveFlag="Y", ExternalId="SENDCHECINLATE_SMS", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-KCJOJ99", LovValue2="FTTH - (Request)Campaign Change Package ตั้งแต่ 100 Mbps ขึ้นไป เพิ่ม/เปลี่ยนอุปกรณ์", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-M8NZN9B", LovValue2="FTTH - (Request) Campaign เพิ่ม Multi Playbox กล่องที่ 2", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-M8NZN7H", LovValue2="FTTB - (Request) Campaign เพิ่ม Multi Playbox กล่องที่ 2", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-M8NZN9C", LovValue2="FTTH - (Request) Campaign เพิ่ม Multi Playbox กล่องที่ 3", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-M8NZN7I", LovValue2="FTTB - (Request) Campaign เพิ่ม Multi Playbox กล่องที่ 3", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-M8NZN9D", LovValue2="FTTH - (Request) Campaign เพิ่ม Multi Playbox กล่องที่ 2 และ 3", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-M8NZN7J", LovValue2="FTTB - (Request) Campaign เพิ่ม Multi Playbox กล่องที่ 2 และ 3", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-M8NZN90", LovValue2="FTTH - (Request) Campaign เปลี่ยนกล่อง Playbox รุ่นใหม่", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-M8NZN7G", LovValue2="FTTB - (Request) Campaign เปลี่ยนกล่อง Playbox รุ่นใหม่", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-NO82S7B", LovValue2="FTTB - (Request) Campaign Change Package + EDIMAX", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-NO82S7C", LovValue2="FTTH - (Request) Campaign Change Package + EDIMAX", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-R1AQL0V", LovValue2="FTTB - (AIS Shop) ลูกค้าถูก Migrate Speed ขอเปลี่ยนอุปกรณ์ (Router)", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-R1AQL0W", LovValue2="FTTH - (AIS Shop) ลูกค้าถูก Migrate Speed ขอเปลี่ยนอุปกรณ์ (Access Point)", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-SJC9G9Y", LovValue2="FTTH - (Request) Campaign Change Package to HomeBROADBAND 50/20 Mbps Get New A702R", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-X862F2P", LovValue2="FTTH - (Request) FIM - Change eSports Package เปลี่ยนอุปกรณ์", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-Y9P3WVJ", LovValue2="FTTH - (Request)Campaign ติดตั้ง Wifi Router เพิ่ม 1 จุดสำหรับลูกค้า eSports Package", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-X9T0F24", LovValue2="FTTH - (Request) FIM - Change eSports Package ติดตั้ง/เปลี่ยน Router", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="1-YS1YOCI", LovValue2="AIS PLAYBOX - (ใช้เฉพาะ FIM) นัดติดตั้ง PLAYBOX กล่องแรก (ลูกค้าไม่ได้รับตอนติดตั้ง)", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="SPECIFY_APPOITMENT_DATE", LovValue2="test for orderNo:SRT2015040900105939", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_LIST", LovValue1="SPECIFY_APPOITMENT_DATE_DISP", LovValue2="test for orderNo:SRT2015041300106110", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_TRIGGER", LovValue1="NULL", LovValue2="NULL", LovValue3="NULL", ActiveFlag="N", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_TRIGGER", LovValue1="MA", LovValue2="ALL", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_RESERVE1", LovValue1="MA", LovValue2="60", LovValue3="42002", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_RESERVE1", LovValue1="INSTALL", LovValue2="60", LovValue3="42001", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="IVR_JOBID", LovValue1="C191122001_J001", LovValue2="15", LovValue3="NULL", ActiveFlag="Y", ExternalId="SENDCHECINLATE_IVR", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="IVR_JOBID", LovValue1="C191122002_J001", LovValue2="30", LovValue3="NULL", ActiveFlag="Y", ExternalId="SENDCHECINLATE_IVR", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="IVR_JOBID", LovValue1="F200606001", LovValue2="60", LovValue3="NULL", ActiveFlag="Y", ExternalId="SENDCHECINLATE_IVR", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="IVR_JOBID", LovValue1="C191122004_J001", LovValue2="90", LovValue3="NULL", ActiveFlag="Y", ExternalId="SENDCHECINLATE_IVR", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="IVR_JOBID", LovValue1="C191122005_J001", LovValue2="120", LovValue3="NULL", ActiveFlag="Y", ExternalId="SENDCHECINLATE_IVR", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="IVR_JOBID", LovValue1="C191122006_J001", LovValue2="FOA_Checkin_Late_Other", LovValue3="NULL", ActiveFlag="Y", ExternalId="SENDCHECINLATE_IVR", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="IVR_JOBID", LovValue1="C191122007_J001", LovValue2="FOA_Checkin_Late_LongDistance", LovValue3="NULL", ActiveFlag="Y", ExternalId="SENDCHECINLATE_IVR", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_SYMPTOM_QUERY_FORMAT", LovValue1=GetPrepareSql("CHECK_SYMPTOM_QUERY_FORMAT"), LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="PREFIX_MICROSITE", LovValue1="MIC", LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_EMPTY", LovValue1="FBB_TBL_EVMICROSITE_DETAIL", LovValue2="FIRSTNAME", LovValue3="NULL", ActiveFlag="Y", ExternalId="MICROSITE_SALE", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CHECK_EMPTY", LovValue1="FBB_TBL_EVMICROSITE_DETAIL", LovValue2="TELEPHONE", LovValue3="NULL", ActiveFlag="Y", ExternalId="MICROSITE_SALE", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CID_KEYWORD", LovValue1="aisfibre", LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="MICROSITE_SALE", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CID_KEYWORD", LovValue1="outbound", LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="MICROSITE_IM", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CID_EXTERNAL_DEFAULT", LovValue1="NULL", LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="MICROSITE_WBB", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="CID_EXTERNAL_DEFAULT", LovValue1="NULL", LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="MICROSITE_SALE", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="QUERY_AUTO_APPROVE", LovValue1=GetPrepareSql("QUERY_AUTO_APPROVE"), LovValue2="18/10/2022", LovValue3="19/10/2022", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="SOA_SHAREPLEX_PARAMETER", LovValue1=GetPrepareSql("SOA_SHAREPLEX_PARAMETER,INSTALL"), LovValue2="NULL", LovValue3="INSTALL_ORDER", ActiveFlag="Y", ExternalId="NOTIFYAPPOINTMENTORDER_SOA", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="SOA_SHAREPLEX_PARAMETER", LovValue1=GetPrepareSql("SOA_SHAREPLEX_PARAMETER,MA"), LovValue2="NULL", LovValue3="MA_ORDER", ActiveFlag="Y", ExternalId="NOTIFYAPPOINTMENTORDER_SOA", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="JOB_INCOMPLETE_REASON_CODE", LovValue1=GetPrepareSql("JOB_INCOMPLETE_REASON_CODE"), LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="JOB_INCOMPLETE_PREFIX_MA", LovValue1="SRT", LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="NOTIFYAPPOINTMENT_REJECT", LovValue1="89", LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="AIRINTERFACEWORKFLOWSERVICE_NODE", LovValue1="PREM", LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
            new(){ LovName="FBBCPGWINTERFACE_NODE", LovValue1="PREM", LovValue2="NULL", LovValue3="NULL", ActiveFlag="Y", ExternalId="NULL", Created=CreatedBy, CreatedDate=DateTime.Now, LastUpd=CreatedBy, LastUpdDate=DateTime.Now },
        };
        primaryDb.FbbTblListOfValues.AddRange(allLov);
        primaryDb.SaveChanges();
    }

    private static string GetPrepareSql(string key)
    {
        switch (key)
        {
            case "CHECK_SYMPTOM_QUERY_FORMAT": return CHECK_SYMPTOM_QUERY_FORMAT.Replace("'", "''");

            case "QUERY_AUTO_APPROVE": return QUERY_AUTO_APPROVE.Replace("'", "''");

            case "SOA_SHAREPLEX_PARAMETER,INSTALL": return SOA_SHAREPLEX_PARAMETER_INSTALL.Replace("'", "''");

            case "SOA_SHAREPLEX_PARAMETER,MA": return SOA_SHAREPLEX_PARAMETER_MA.Replace("'", "''");

            case "JOB_INCOMPLETE_REASON_CODE": return JOB_INCOMPLETE_REASON_CODE.Replace("'", "''");
        }
        return string.Empty;
    }

    private static string CHECK_SYMPTOM_QUERY_FORMAT => 
        @"SELECT * 
        FROM oam.ttt_fault_order_attr a 
        WHERE a.state = ':state'
            AND a.ord_no = ':orderNo'
            AND a.field_code IN (':fieldCode') 
            limit :numRow;";

    private static string QUERY_AUTO_APPROVE =>
        @"select w.ask_no as ORDER_NO,
            r.new_num as FIBRENET_ID,
            r.serv_event_name as JOB_TYPE,
            r.product_name,
            w.create_date, '1' as ORDER_TYPE,
            'A' as ACTION, '' as Reason,
            '' as Sub_reason,'' as TAG_CODE,
            '5520' as STAFF_ID,
            'Batch Auto Approved '|| to_char(current_date,'dd/mm/yyyy') --e.g. ""2022-06-28 as REMARK --to_char(sysdate, 'dd/mm/yyyy') 
            ,w.create_date
            ,date_trunc('day',w.create_date)::timestamp --e.g. 2020-05-22 00:00:00  --trunc(w.create_date)
            ,to_char(w.create_date,'dd/mm/yyyy') --to_date(trunc(w.create_date), 'dd/mm/yyyy')
        from PROV.TOM_WORK_ORDER w, PROV.TOM_EXEC_ORDER r
        where w.SEQ = '0'
        and w.work_state = '1'
        and w.workorder_type = 'COSC_400'
          and date_trunc('day',w.create_date)::timestamp BETWEEN
          case when isnullorblank(':dateStart','-')='-'
               then current_date -- '10/03/2021' = parm_date_start
               else TO_DATE(':dateStart','DD/MM/YYYY') end
          and
          case when isnullorblank(':dateEnded','-')='-'
               then current_date -- '10/03/2021' = parm_date_end
               else TO_DATE(':dateEnded','DD/MM/YYYY') end
        and w.ask_no = r.ask_no
        and r.serv_event_name in ('Join', 'UpdateProfile')
        and r.install_flag = '2'
        --and r.new_num in ('8850099315')
        group by w.ask_no, r.new_num, w.create_date, r.serv_event_name, r.product_name
        order by w.create_date DESC;";

    private static string SOA_SHAREPLEX_PARAMETER_INSTALL =>
        @"--Installation order
        select t.request_no,t.latitude installation_latitude,t.longitude installation_longitude
               ,a.building_name,a.sub_district area,r.region_name region
               ,e.attr_value3 cs_note
        from wfm_r8.wf_task t,prov.trm_address_local a,prov.area_dtl r,prov.tom_exec_order e
        where t.request_no = ':REQUEST_NO' --Input #1
           and t.is_last_construct = 'Y' --lastest
           and t.action_type = '0' --0: construct
           and to_number(t.address_id,'999999999999') = a.addr_id  --20657882
           and a.area_id = r.subdistrict_id
           and e.ask_no = t.request_no
        limit 1;";

    private static string SOA_SHAREPLEX_PARAMETER_MA =>
        @"--Ma order
        select t.request_no,
               t.latitude installation_latitude,
               t.longitude installation_longitude,
               (select a.field_value
                  from oam.ttt_fault_order_attr a
                 where a.ord_no = t.attr_value3
                   and a.field_code = 'ASSIGN_CONDITION_SERVICE_LEVEL') sevice_level,
               a.building_name,
               a.sub_district area,
               r.region_name region,
               t.address,
                (select STRING_AGG(c.comment_text,'//' ORDER BY c.modify_date)

                  from wfm_r8.wf_task_comment c
                 where c.task_order_no in
                       (select t1.task_order_no
                          from wfm_r8.wf_task t1
                         where t1.request_no = t.request_no)
                   and c.comment_type = '1') cs_note
          from wfm_r8.wf_task t, prov.trm_address_local a, prov.area_dtl r
        where t.request_no = ':REQUEST_NO' --Input #1
           and t.is_last_construct = 'Y' --lastest
           and t.action_type = '0' --0: construct
           and to_number(t.address_id,'999999999999') = a.addr_id
           and a.area_id = r.subdistrict_id
        limit 1;";

    private static string JOB_INCOMPLETE_REASON_CODE =>
        @"SELECT r.reason_code, r.reason_name
            FROM WFM_R8.WFS_REASON r 
            WHERE r.STATE = 'A' 
              AND r.reason_code like 'COSC%' 
              AND r.TAGS = 'CONFIRM_INCOMPLETE' 
              AND  length(r.reason_code) = 6 --6: MA 
              AND r.reason_name = ':reasonName'
              limit 1;";
    
}