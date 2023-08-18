using Application.Common.Interfaces;
using Application.Common.Models.NotifyAppointmentOrder;
using Domain.Common.Core;
using Domain.Entities.Minieai;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Application.Query.NotifyAppointmentOrder;

public sealed class CommitNotifyAppointmentOrderHandler : IRequestHandler<CommitNotifyAppointmentOrderRequestModel, CommitNotifyAppointmentOrderResponseModel>
{
    private readonly ILogger _logger;
    private readonly IPrimaryDbContext _primaryDb;

    public CommitNotifyAppointmentOrderHandler(ILogger logger, IPrimaryDbContext primaryDb)
    {
        _logger = logger;
        _primaryDb = primaryDb;
    }

    //insert into header table
    //then add to minieai-decompose
    public Task<CommitNotifyAppointmentOrderResponseModel> Handle(CommitNotifyAppointmentOrderRequestModel request, CancellationToken cancellationToken)
    {
        var result = new CommitNotifyAppointmentOrderResponseModel
        {
            TRANSACTION_ID = request.TransactionId,
            FIBRENET_ID = request.FIBRENET_ID,
            TYPE = request.TYPE
        };
        _logger.Information("CommitNotifyAppointmentOrder: {0}, {1}, {2}, {3}", request?.Header?.TransactionId, request?.FIBRENET_ID, request?.MSG_SEQ_ID, request?.TYPE);

        var executionStrategy = _primaryDb.Db.CreateExecutionStrategy();
        executionStrategy.Execute(() =>
        {
            using (var transaction = _primaryDb.Db.BeginTransaction())
            {
                try
                {
                    var headerId = InserHeader(request);
                    if (request?.INSTALL_ORDER != null)
                    {
                        var installId = InsertInstallOrder(headerId, request.INSTALL_ORDER, request.AppSource);
                        //ontops, fees
                        InsertOntopAndFees(installId, request.INSTALL_ORDER.SERVICE_ONTOP, request.INSTALL_ORDER.FEE_LIST, request.AppSource);
                        //wfm, crm
                        InsertWfmsAndCrms(installId, request.INSTALL_ORDER.WFM_SUBCONTRACT_REMARKS, request.INSTALL_ORDER.CRM_SUBCONTRACT_REMARKS, request.AppSource);
                        //Staffs,Companies,Teams
                        InsertStaffsAndCompaniesAndTeams(installId, request.INSTALL_ORDER.STAFF_LIST, request.AppSource);
                        //resource
                        InsertResource(installId, request.INSTALL_ORDER.RESOURCE, request.AppSource);
                    }
                    if (request?.MA_ORDER != null)
                    {
                        var maId = InsertMaOrder(headerId, request.MA_ORDER, request.AppSource);
                        //wfm, crm
                        InsertWfmsAndCrms(maId, request.MA_ORDER.WFM_SUBCONTRACT_REMARKS, null, request.AppSource);
                        //Staffs,Companies,Teams
                        InsertStaffsAndCompaniesAndTeams(maId, request.MA_ORDER.STAFF_LIST, request.AppSource);
                        //resource
                        InsertResource(maId, request.MA_ORDER.RESOURCE, request.AppSource);
                    }

                    transaction.Commit();
                    result.AsSuccess();
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, $"Error occurred {GetType().Name}.Handle");
                    transaction.Rollback();
                    result.AsError();
                }
            }
        });
        return Task.FromResult(result);
    }

    private void InsertStaffsAndCompaniesAndTeams(long orderId, List<NotifyAppointmentOrderStaff>? staffs, string appSource)
    {
        var staffGroup = 0;
        var companyGroup = 0;
        var teamGroup = 0;
        foreach (var staff in staffs ?? new List<NotifyAppointmentOrderStaff>())
        {
            var aStaff = new FbbTblEvNotifyAppointmentStaff
            {
                OrderId = orderId,
                Group = staffGroup,
                StaffCode = staff.STAFF_CODE,
                StaffName = staff.STAFF_NAME,
                StaffPhone = staff.STAFF_PHONE,
                StaffEmail = staff.STAFF_EMAIL,
                StaffLatitude = staff.STAFF_LATITUDE,
                StaffLongitude = staff.STAFF_LONGITUDE,
                StaffFirstDayWorking = staff.STAFF_FIRST_DAY_WORKING,
                StaffEndDayWorking = staff.STAFF_END_DAY_WORKING,
                StaffRole = staff.STAFF_ROLE,
                StaffProfilePictureFilename = staff.STAFF_PROFILE_PICTURE_FILENAME,
                Created = appSource,
                CreatedDate = DateTime.Now,
                LastUpd = appSource,
                LastUpdDate = DateTime.Now
            };
            _primaryDb.FbbTblEvNotifyAppointmentStaffs.Add(aStaff);
            _primaryDb.SaveChanges();
            staffGroup++;
            foreach (var company in staff?.COMPANY_LIST ?? new List<NotifyAppointmentOrderCompany>())
            {
                var aCompany = new FbbTblEvNotifyAppointmentCompany
                {
                    OrderId = orderId,
                    StaffId = aStaff.Id,
                    Group = companyGroup,
                    CompanyName = company.COMPANY_NAME,
                    CompanyId = company.COMPANY_ID,
                    VendorCode = company.VENDOR_CODE,
                    LocationCode = company.LOCATION_CODE,
                    StorageLocation = company.STORAGE_LOCATION,
                    Created = appSource,
                    CreatedDate = DateTime.Now,
                    LastUpd = appSource,
                    LastUpdDate = DateTime.Now
                };
                _primaryDb.FbbTblEvNotifyAppointmentCompanies.Add(aCompany);
                _primaryDb.SaveChanges();
                companyGroup++;
                foreach (var team in company?.TEAM_LIST ?? new List<NotifyAppointmentOrderTeam>())
                {
                    var aTeam = new FbbTblEvNotifyAppointmentTeam
                    {
                        OrderId = orderId,
                        CompanyId = aCompany.Id,
                        Group = teamGroup,
                        TeamName = team.TEAM_NAME,
                        TeamId = team.TEAM_ID,
                        TeamService = team.TEAM_SERVICE,
                        VendorCode = team.VENDOR_CODE,
                        LocationCode = team.LOCATION_CODE,
                        StorageLocation = team.STORAGE_LOCATION,
                        ShipTo = team.SHIP_TO,
                        Created = appSource,
                        CreatedDate = DateTime.Now,
                        LastUpd = appSource,
                        LastUpdDate = DateTime.Now
                    };
                    _primaryDb.FbbTblEvNotifyAppointmentTeams.Add(aTeam);
                    _primaryDb.SaveChanges();
                    teamGroup++;
                }//teams
            }//companies
        }//staffs
    }

    private void InsertResource(long orderId, NotifyAppointmentOrderResource? res, string appSource)
    {
        var resource = new FbbTblEvNotifyAppointmentResource
        {
            OrderId = orderId,
            Service = res?.SERVICE,
            DownlinkRate = res?.DOWNLINK_RATE,
            UplinkRate = res?.UPLINK_RATE,
            Password = res?.PASSWORD,
            CpeModel = res?.CPE_MODEL,
            SplitterPort = res?.SPLITTER_PORT,
            SplitterNamePrimary = res?.SPLITTER_NAME_PRIMARY,
            OltName = res?.OLT_NAME,
            ActivationId = res?.ACTIVATION_ID,
            CpeSn = res?.CPE_SN,
            Cvlan = res?.CVLAN,
            DeviceModel = res?.DEVICE_MODEL,
            DslamManufacturer = res?.DSLAM_MANUFACTURER,
            DslamPort = res?.DSLAM_PORT,
            MdfOutPort = res?.MDF_OUT_PORT,
            OdfFiberCore = res?.ODF_FIBER_CORE,
            Sp1FiberCore = res?.SP1_FIBER_CORE,
            Gemport = res?.GEMPORT,
            StandardAddressName = res?.STANDARD_ADDRESS_NAME,
            IpAddress = res?.IP_ADDRESS,
            Sp1Latitude = res?.SP1_LATITUDE,
            Sp1Longitude = res?.SP1_LONGITUDE,
            Sp2Latitude = res?.SP2_LATITUDE,
            Sp2Longitude = res?.SP2_LONGITUDE,
            OdfIn = res?.ODF_IN,
            OdfOut = res?.ODF_OUT,
            OltManufacturer = res?.OLT_MANUFACTURER,
            OltPonPort = res?.OLT_PON_PORT,
            Onu = res?.ONU,
            OnuId = res?.ONU_ID,
            OnuModel = res?.ONU_MODEL,
            OnuUplinkPort = res?.ONU_UPLINK_PORT,
            Sp1RunningState = res?.SP1_RUNNING_STATE,
            Sp2RunningState = res?.SP2_RUNNING_STATE,
            SplitterDistance = res?.SPLITTER_DISTANCE,
            Sp1InPort = res?.SP1_IN_PORT,
            Sp2InPort = res?.SP2_IN_PORT,
            Sp1OutPort = res?.SP1_OUT_PORT,
            Sp2OutPort = res?.SP2_OUT_PORT,
            Svlan = res?.SVLAN,
            Tcont = res?.TCONT,
            Sp2Distance = res?.SP2_DISTANCE,
            DropWireDistance = res?.DROP_WIRE_DISTANCE,
            ExistingDropWireId = res?.EXISTING_DROP_WIRE_ID,
            EndPointLatitude = res?.END_POINT_LATITUDE,
            EndPointLongitude = res?.END_POINT_LONGITUDE,
            NewDropWireId = res?.NEW_DROP_WIRE_ID,
            ReuseFlag = res?.REUSE_FLAG,
            CpeInstallation = res?.CPE_INSTALLATION,
            Created = appSource,
            CreatedDate = DateTime.Now,
            LastUpd = appSource,
            LastUpdDate = DateTime.Now
        };
        _primaryDb.FbbTblEvNotifyAppointmentResources.Add(resource);
        _primaryDb.SaveChanges();
    }

    private void InsertWfmsAndCrms(long orderId, List<NotifyAppointmentOrderWfm>? wfms, List<NotifyAppointmentOrderCrm>? crms, string appSource)
    {
        if (wfms != null && wfms.Any())
        {
            var newWfms = new List<FbbTblEvNotifyAppointmentWfm>();
            var group = 0;
            foreach (var data in wfms)
            {
                newWfms.Add(new FbbTblEvNotifyAppointmentWfm
                {
                    OrderId = orderId,
                    Group = group,
                    Author = data.AUTHOR,
                    SubcontractRemarks = data.SUBCONTRACT_REMARKS,
                    RemarkDate = data.REMARK_DATE,
                    Created = appSource,
                    CreatedDate = DateTime.Now,
                    LastUpd = appSource,
                    LastUpdDate = DateTime.Now
                });
                group++;
            }
            _primaryDb.FbbTblEvNotifyAppointmentWfms.AddRange(newWfms);
        }
        if (crms != null && crms.Any())
        {
            var newCrms = new List<FbbTblEvNotifyAppointmentCrm>();
            var group = 0;
            foreach (var data in crms)
            {
                newCrms.Add(new FbbTblEvNotifyAppointmentCrm
                {
                    OrderId = orderId,
                    Group = group,
                    Author = data.AUTHOR,
                    SubcontractRemarks = data.SUBCONTRACT_REMARKS,
                    RemarkDate = data.REMARK_DATE,
                    Created = appSource,
                    CreatedDate = DateTime.Now,
                    LastUpd = appSource,
                    LastUpdDate = DateTime.Now
                });
                group++;
            }
            _primaryDb.FbbTblEvNotifyAppointmentCrms.AddRange(newCrms);
        }
        _primaryDb.SaveChanges();
    }

    private void InsertOntopAndFees(long orderId, List<string>? ontops, List<string>? fees, string appSource)
    {
        if (ontops != null && ontops.Any())
        {
            var newOntops = new List<FbbTblEvNotifyAppointmentOntop>();
            foreach (var data in ontops)
            {
                newOntops.Add(new FbbTblEvNotifyAppointmentOntop
                {
                    OrderId = orderId,
                    Group = 0,
                    Data = data,
                    Created = appSource,
                    CreatedDate = DateTime.Now,
                    LastUpd = appSource,
                    LastUpdDate = DateTime.Now
                });
            }
            _primaryDb.FbbTblEvNotifyAppointmentOntops.AddRange(newOntops);
        }
        if (fees != null && fees.Any())
        {
            var newFees = new List<FbbTblEvNotifyAppointmentFee>();
            foreach (var data in fees)
            {
                newFees.Add(new FbbTblEvNotifyAppointmentFee
                {
                    OrderId = orderId,
                    Group = 0,
                    Data = data,
                    Created = appSource,
                    CreatedDate = DateTime.Now,
                    LastUpd = appSource,
                    LastUpdDate = DateTime.Now
                });
            }
            _primaryDb.FbbTblEvNotifyAppointmentFees.AddRange(newFees);
        }
        _primaryDb.SaveChanges();
    }

    private long InserHeader(CommitNotifyAppointmentOrderRequestModel? req)
    {
        var header = new FbbTblEvNotifyAppointmentHeader
        {
            TransactionId = req?.Header?.TransactionId,
            FibrenetId = req?.FIBRENET_ID,
            Type = req?.TYPE,
            OrderType = req?.MA_ORDER == null ? "INSTALL" : "MA",
            TypeOperDate = req?.TYPE_OPER_DATE,
            MsgSeqId = req?.MSG_SEQ_ID,
            Status = EnumTransactionState.COMMIT.ToString(),
            Created = req?.AppSource,
            CreatedDate = DateTime.Now,
            LastUpd = req?.AppSource,
            LastUpdDate = DateTime.Now,
            ServerName = Dns.GetHostName()
        };
        _primaryDb.FbbTblEvNotifyAppointmentHeaders.Add(header);
        _primaryDb.SaveChanges();
        return header.Id;
    }

    private long InsertInstallOrder(long headerId, NotifyAppointmentOrderInstall orderInstal, string appSource)
    {
        var order = new FbbTblEvNotifyAppointmentOrder
        {
            HeaderId = headerId,
            CustomerOrderNo = orderInstal.CUSTOMER_ORDER_NO,
            FbssOrderNo = orderInstal.FBSS_ORDER_NO,
            TaskOrderNo = orderInstal.TASK_ORDER_NO,
            FibrenetId = orderInstal.FIBRENET_ID,
            JobState = orderInstal.JOB_STATE,
            JobPriority = orderInstal.JOB_PRIORITY,
            ProductName = orderInstal.PRODUCT_NAME,
            AccessMode = orderInstal.ACCESS_MODE,
            OrderType = orderInstal.ORDER_TYPE,
            ReplaceOntFlag = orderInstal.REPLACE_ONT_FLAG,
            ReplaceRouterFlag = orderInstal.REPLACE_ROUTER_FLAG,
            RouterNum = orderInstal.ROUTER_NUM,
            CustomerName = orderInstal.CUSTOMER_NAME,
            ContactPersonName = orderInstal.CONTACT_PERSON_NAME,
            ContactMobilePhone1 = orderInstal.CONTACT_MOBILE_PHONE1,
            ContactMobilePhone2 = orderInstal.CONTACT_MOBILE_PHONE2,
            ContactMobilePhone3 = orderInstal.CONTACT_MOBILE_PHONE3,
            InstallationAddress = orderInstal.INSTALLATION_ADDRESS,
            InstallationLatitude = orderInstal.INSTALLATION_LATITUDE,
            InstallationLongitude = orderInstal.INSTALLATION_LONGITUDE,
            Brand = orderInstal.BRAND,
            EventflowFlag = orderInstal.EVENTFLOW_FLAG,
            ServiceLevel = orderInstal.SERVICE_LEVEL,
            OntopPack = orderInstal.ONTOP_PACK,
            ServicePack = orderInstal.SERVICE_PACK,
            VoipNumber1 = orderInstal.VOIP_NUMBER1,
            VoipPassword1 = orderInstal.VOIP_PASSWORD1,
            VoipNumber2 = orderInstal.VOIP_NUMBER2,
            VoipPassword2 = orderInstal.VOIP_PASSWORD2,
            PlayboxContent = orderInstal.PLAYBOX_CONTENT,
            TotalFee = orderInstal.TOTAL_FEE,
            AppointmentDate = orderInstal.APPOINTMENT_DATE,
            AppointmentTimeslot = orderInstal.APPOINTMENT_TIMESLOT,
            Created = appSource,
            CreatedDate = DateTime.Now,
            LastUpd = appSource,
            LastUpdDate = DateTime.Now,
        };
        _primaryDb.FbbTblEvNotifyAppointmentOrders.Add(order);
        _primaryDb.SaveChanges();
        return order.Id;
    }

    private long InsertMaOrder(long headerId, NotifyAppointmentOrderMA OrderMa, string appSource)
    {
        var order = new FbbTblEvNotifyAppointmentOrder
        {
            HeaderId = headerId,
            TroubleTicketNo = OrderMa.TROUBLE_TICKET_NO,
            SiebelRequestNo = OrderMa.SIEBEL_REQUEST_NO,
            TaskOrderNo = OrderMa.TASK_ORDER_NO,
            FibrenetId = OrderMa.FIBRENET_ID,
            JobState = OrderMa.JOB_STATE,
            JobPriority = OrderMa.JOB_PRIORITY,
            ProductName = OrderMa.PRODUCT_NAME,
            Service = OrderMa.SERVICE,
            AccessMode = OrderMa.ACCESS_MODE,
            DownlinkRate = OrderMa.DOWNLINK_RATE,
            UplinkRate = OrderMa.UPLINK_RATE,
            CommitDate = OrderMa.COMMIT_DATE,
            AcceptDate = OrderMa.ACCEPT_DATE,
            TroubleSymptom = OrderMa.TROUBLE_SYMPTOM,
            ComplaintTitle = OrderMa.COMPLAINT_TITLE,
            CustomerComplaintName = OrderMa.CUSTOMER_COMPLAINT_NAME,
            CustomerComplaintMobile = OrderMa.CUSTOMER_COMPLAINT_MOBILE,
            NocRemark = OrderMa.NOC_REMARK,
            NocNumber = OrderMa.NOC_NUMBER,
            DetailsForResolved = OrderMa.DETAILS_FOR_RESOLVED,
            ComplaintDescription = OrderMa.COMPLAINT_DESCRIPTION,
            CustomerName = OrderMa.CUSTOMER_NAME,
            ContactPersonName = OrderMa.CONTACT_PERSON_NAME,
            ContactMobilePhone1 = OrderMa.CONTACT_MOBILE_PHONE1,
            ContactMobilePhone2 = OrderMa.CONTACT_MOBILE_PHONE2,
            ContactMobilePhone3 = OrderMa.CONTACT_MOBILE_PHONE3,
            AppointmentDate = OrderMa.APPOINTMENT_DATE,
            AppointmentTimeslot = OrderMa.APPOINTMENT_TIMESLOT,
            InstallationAddress = OrderMa.INSTALLATION_ADDRESS,
            ////InstallationAddress = OrderMa.ADDRESS,
            InstallationLatitude = OrderMa.INSTALLATION_LATITUDE,
            InstallationLongitude = OrderMa.INSTALLATION_LONGITUDE,
            ServicePack = OrderMa.SERVICE_PACK,
            ServiceLevel = OrderMa.SERVICE_LEVEL,
            OntopPack = OrderMa.ONTOP_PACK,
            PlayboxContent = OrderMa.PLAYBOX_CONTENT
        };
        _primaryDb.FbbTblEvNotifyAppointmentOrders.Add(order);
        _primaryDb.SaveChanges();
        return order.Id;
    }
}