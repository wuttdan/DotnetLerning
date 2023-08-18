using Domain.Entities.Minieai;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IPrimaryDbContext : IBaseDbContext
{
    DbSet<FbbTblEvAuthorizationDetail> FbbTblEvAuthorizationDetails { get; set; }
    DbSet<FbbTblEvAuthorizationHeader> FbbTblEvAuthorizationHeaders { get; set; }
    DbSet<FbbTblEvAutoApproveHeader> FbbTblEvAutoApproveHeaders { get; set; }
    DbSet<FbbTblEvCustomerInfoDetail> FbbTblEvCustomerInfoDetails { get; set; }
    DbSet<FbbTblEvCustomerInfoHeader> FbbTblEvCustomerInfoHeaders { get; set; }
    DbSet<FbbTblEvJobApproveDetail> FbbTblEvJobApproveDetails { get; set; }
    DbSet<FbbTblEvJobApproveHeader> FbbTblEvJobApproveHeaders { get; set; }
    DbSet<FbbTblEvJobIncompleteDetail> FbbTblEvJobIncompleteDetails { get; set; }
    DbSet<FbbTblEvJobIncompleteHeader> FbbTblEvJobIncompleteHeaders { get; set; }
    DbSet<FbbTblEvMicrositeDetail> FbbTblEvMicrositeDetails { get; set; }
    DbSet<FbbTblEvMicrositeHeader> FbbTblEvMicrositeHeaders { get; set; }
    DbSet<FbbTblEvMicrositeUpdDetail> FbbTblEvMicrositeUpdDetails { get; set; }
    DbSet<FbbTblEvMicrositeUpdHeader> FbbTblEvMicrositeUpdHeaders { get; set; }
    DbSet<FbbTblEvNotifyAppointmentCompany> FbbTblEvNotifyAppointmentCompanies { get; set; }
    DbSet<FbbTblEvNotifyAppointmentCrm> FbbTblEvNotifyAppointmentCrms { get; set; }
    DbSet<FbbTblEvNotifyAppointmentFee> FbbTblEvNotifyAppointmentFees { get; set; }
    DbSet<FbbTblEvNotifyAppointmentHeader> FbbTblEvNotifyAppointmentHeaders { get; set; }
    DbSet<FbbTblEvNotifyAppointmentOntop> FbbTblEvNotifyAppointmentOntops { get; set; }
    DbSet<FbbTblEvNotifyAppointmentOrder> FbbTblEvNotifyAppointmentOrders { get; set; }
    DbSet<FbbTblEvNotifyAppointmentResource> FbbTblEvNotifyAppointmentResources { get; set; }
    DbSet<FbbTblEvNotifyAppointmentStaff> FbbTblEvNotifyAppointmentStaffs { get; set; }
    DbSet<FbbTblEvNotifyAppointmentTeam> FbbTblEvNotifyAppointmentTeams { get; set; }
    DbSet<FbbTblEvNotifyAppointmentWfm> FbbTblEvNotifyAppointmentWfms { get; set; }
    DbSet<FbbTblEvsendchecklateDetail> FbbTblEvsendchecklateDetails { get; set; }
    DbSet<FbbTblEvsendchecklateHeader> FbbTblEvsendchecklateHeaders { get; set; }
    DbSet<FbbTblExceptionError> FbbTblExceptionErrors { get; set; }
    DbSet<FbbTblListOfValue> FbbTblListOfValues { get; set; }
    DbSet<FbbTblLogging> FbbTblLoggings { get; set; }
    DbSet<FbbTblMappingExternal> FbbTblMappingExternals { get; set; }
    DbSet<FbbTblMappingId> FbbTblMappingIds { get; set; }
    DbSet<FbbTblMappingParameter> FbbTblMappingParameters { get; set; }
    DbSet<FbbTblMappingValidate> FbbTblMappingValidates { get; set; }
    DbSet<FbbTblMappingWo> FbbTblMappingWos { get; set; }
    DbSet<FbbTblWo> FbbTblWos { get; set; }
    DbSet<FbbTblWoAttribute> FbbTblWoAttributes { get; set; }
    DbSet<FbbTblWoBlame> FbbTblWoBlames { get; set; }
    DbSet<FbbTblWoErrorMessage> FbbTblWoErrorMessages { get; set; }
    DbSet<FbbTblWoSoaCompany> FbbTblWoSoaCompanies { get; set; }
    DbSet<FbbTblWoSoaCrm> FbbTblWoSoaCrms { get; set; }
    DbSet<FbbTblWoSoaFee> FbbTblWoSoaFees { get; set; }
    DbSet<FbbTblWoSoaHeader> FbbTblWoSoaHeaders { get; set; }
    DbSet<FbbTblWoSoaInstallOrder> FbbTblWoSoaInstallOrders { get; set; }
    DbSet<FbbTblWoSoaMaOrder> FbbTblWoSoaMaOrders { get; set; }
    DbSet<FbbTblWoSoaOntop> FbbTblWoSoaOntops { get; set; }
    DbSet<FbbTblWoSoaResource> FbbTblWoSoaResources { get; set; }
    DbSet<FbbTblWoSoaStaff> FbbTblWoSoaStaffs { get; set; }
    DbSet<FbbTblWoSoaTeam> FbbTblWoSoaTeams { get; set; }
    DbSet<FbbTblWoSoaWfm> FbbTblWoSoaWfms { get; set; }
}
