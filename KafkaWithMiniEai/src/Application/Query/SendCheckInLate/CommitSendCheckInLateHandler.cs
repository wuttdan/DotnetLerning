using Application.Common.Interfaces;
using Domain.Common.Core;
using Domain.Entities.Minieai;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Net;

namespace Application.Query.SendCheckInLate;

public sealed class CommitSendCheckInLateHandler : IRequestHandler<CommitSendCheckInLateRequestModel, CommitSendCheckInLateResponseModel>
{
    private const string CHECKINLATE_DATETIME_FORMAT = "yyyy-MM-dd HH:mm";
    private readonly ILogger _logger;
    private readonly IPrimaryDbContext _primaryDb;

    public CommitSendCheckInLateHandler(ILogger logger, IPrimaryDbContext primaryDb)
    {
        _logger = logger;
        _primaryDb = primaryDb;
    }
    public Task<CommitSendCheckInLateResponseModel> Handle(CommitSendCheckInLateRequestModel request, CancellationToken cancellationToken)
    {
        var result = request.CreateResponse();
        _logger.Information("{0}: {0}, {1}, {2}, {3}", GetType().Name, request?.TransactionId, request?.MN_INTERNET_ID, request?.MN_ORDER_NO, request?.MN_ORDER_TYPE);

        var executionStrategy = _primaryDb.Db.CreateExecutionStrategy();
        executionStrategy.Execute(() =>
        {
            using (var transaction = _primaryDb.Db.BeginTransaction())
            {
                try
                {
                    var headerId = InserHeader(request);
                    InserDetail(headerId, request);
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

    private long InserHeader(CommitSendCheckInLateRequestModel? req)
    {
        var header = new FbbTblEvSendChecklateHeader
        {
            TransactionId = req?.TransactionId,
            InternetId = req?.MN_INTERNET_ID,
            OrderNo = req?.MN_ORDER_NO,
            OrderType = req?.MN_ORDER_TYPE,
            Status = EnumTransactionState.COMMIT.ToString(),
            Created = req?.AppSource,
            CreatedDate = DateTime.Now,
            LastUpd = req?.AppSource,
            LastUpdDate = DateTime.Now,
            ServerName = Dns.GetHostName()
        };
        _primaryDb.FbbTblEvsendchecklateHeaders.Add(header);
        _primaryDb.SaveChanges();
        return header.Id;
    }

    private void InserDetail(long headerId, CommitSendCheckInLateRequestModel? req)
    {
        var refId = _primaryDb.GenRefIdSeq();
        var lateMin = GetLateDuration(req?.MN_APPOINTMENT_DATE, req?.MN_SLOT, req?.MN_CHECKIN_LATE_TIME);
        var detail = new FbbTblEvSendChecklateDetail
        {
            HeaderId = headerId,
            MnAppointmentDate = req?.MN_APPOINTMENT_DATE,
            MnSlot = req?.MN_SLOT,
            MnPackage = req ?.MN_PACKAGE,
            MnProductName = req?.MN_PRODUCT_NAME,
            MnCustomerName = req?.MN_CUSTOMER_NAME,
            MnCustomerAddress = req?.MN_CUSTOMER_ADDRESS,
            MnCustomerLatitude = req?.MN_CUSTOMER_LATITUDE,
            MnCustomerLongitude = req?.MN_CUSTOMER_LONGITUDE,
            MnRegion = req?.MN_REGION,
            MnStaffCode = req?.MN_STAFF_CODE,
            MnStaffName = req?.MN_STAFF_NAME,
            MnStaffPhone = req?.MN_STAFF_PHONE,
            MnSubcontractTeam = req?.MN_SUBCONTRACT_TEAM,
            MnCheckinLateTime = req?.MN_CHECKIN_LATE_TIME,
            MnCheckinLateReason = req?.MN_CHECKIN_LATE_REASON,
            MnCurrentLatitude = req?.MN_CURRENT_LATITUDE,
            MnCurrentLongitude = req?.MN_CURRENT_LONGITUDE,
            MnCreateDate = req?.MN_CREATE_DATE,
            MnCreatedBy = req?.MN_CREATED_BY,
            MnCustomerContact1 = req?.MN_CUSTOMER_CONTACT_1,
            MnCustomerContact2 = req?.MN_CUSTOMER_CONTACT_2,
            MnCustomerContact3 = req?.MN_CUSTOMER_CONTACT_3,
            MnRemarks = req?.MN_REMARKS,
            Refid = refId,
            LateDuration = lateMin,
            Created = req?.AppSource,
            CreatedDate = DateTime.Now,
            LastUpd = req?.AppSource,
            LastUpdDate = DateTime.Now
        };
        _primaryDb.FbbTblEvsendchecklateDetails.Add(detail);
        _primaryDb.SaveChanges();
    }

    public string GetLateDuration(string? mnAppointmentDate, string? mnSlot, string? mnCheckInLateTime)
    {
        var time = mnSlot?.Split("-").FirstOrDefault() ?? "00:00";
        mnCheckInLateTime ??= DateTime.Now.ToString(CHECKINLATE_DATETIME_FORMAT);
        _ = DateTime.TryParseExact($"{mnAppointmentDate} {time}", CHECKINLATE_DATETIME_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out var appointmentDateTime);
        _ = DateTime.TryParseExact(mnCheckInLateTime, CHECKINLATE_DATETIME_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out var checkInLateDateTime);
        var timeDiff = checkInLateDateTime - appointmentDateTime;
        return timeDiff.TotalMinutes.ToString();
    }
}

