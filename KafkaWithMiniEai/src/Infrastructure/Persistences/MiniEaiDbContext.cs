using Application.Common.Core;
using Application.Common.Interfaces;
using Domain.Entities.Minieai;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistences;

public partial class MiniEaiDbContext : BaseDbContext, IPrimaryDbContext
{
    public MiniEaiDbContext(DbContextOptions<MiniEaiDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FbbTblEvAuthorizationDetail> FbbTblEvAuthorizationDetails { get; set; } = null!;
    public virtual DbSet<FbbTblEvAuthorizationHeader> FbbTblEvAuthorizationHeaders { get; set; } = null!;
    public virtual DbSet<FbbTblEvAutoApproveHeader> FbbTblEvAutoApproveHeaders { get; set; } = null!;
    public virtual DbSet<FbbTblEvCustomerInfoDetail> FbbTblEvCustomerInfoDetails { get; set; } = null!;
    public virtual DbSet<FbbTblEvCustomerInfoHeader> FbbTblEvCustomerInfoHeaders { get; set; } = null!;
    public virtual DbSet<FbbTblEvJobApproveDetail> FbbTblEvJobApproveDetails { get; set; } = null!;
    public virtual DbSet<FbbTblEvJobApproveHeader> FbbTblEvJobApproveHeaders { get; set; } = null!;
    public virtual DbSet<FbbTblEvJobIncompleteDetail> FbbTblEvJobIncompleteDetails { get; set; } = null!;
    public virtual DbSet<FbbTblEvJobIncompleteHeader> FbbTblEvJobIncompleteHeaders { get; set; } = null!;
    public virtual DbSet<FbbTblEvMicrositeDetail> FbbTblEvMicrositeDetails { get; set; } = null!;
    public virtual DbSet<FbbTblEvMicrositeHeader> FbbTblEvMicrositeHeaders { get; set; } = null!;
    public virtual DbSet<FbbTblEvMicrositeUpdDetail> FbbTblEvMicrositeUpdDetails { get; set; } = null!;
    public virtual DbSet<FbbTblEvMicrositeUpdHeader> FbbTblEvMicrositeUpdHeaders { get; set; } = null!;
    public virtual DbSet<FbbTblEvNotifyAppointmentCompany> FbbTblEvNotifyAppointmentCompanies { get; set; } = null!;
    public virtual DbSet<FbbTblEvNotifyAppointmentCrm> FbbTblEvNotifyAppointmentCrms { get; set; } = null!;
    public virtual DbSet<FbbTblEvNotifyAppointmentFee> FbbTblEvNotifyAppointmentFees { get; set; } = null!;
    public virtual DbSet<FbbTblEvNotifyAppointmentHeader> FbbTblEvNotifyAppointmentHeaders { get; set; } = null!;
    public virtual DbSet<FbbTblEvNotifyAppointmentOntop> FbbTblEvNotifyAppointmentOntops { get; set; } = null!;
    public virtual DbSet<FbbTblEvNotifyAppointmentOrder> FbbTblEvNotifyAppointmentOrders { get; set; } = null!;
    public virtual DbSet<FbbTblEvNotifyAppointmentResource> FbbTblEvNotifyAppointmentResources { get; set; } = null!;
    public virtual DbSet<FbbTblEvNotifyAppointmentStaff> FbbTblEvNotifyAppointmentStaffs { get; set; } = null!;
    public virtual DbSet<FbbTblEvNotifyAppointmentTeam> FbbTblEvNotifyAppointmentTeams { get; set; } = null!;
    public virtual DbSet<FbbTblEvNotifyAppointmentWfm> FbbTblEvNotifyAppointmentWfms { get; set; } = null!;
    public virtual DbSet<FbbTblEvsendchecklateDetail> FbbTblEvsendchecklateDetails { get; set; } = null!;
    public virtual DbSet<FbbTblEvsendchecklateHeader> FbbTblEvsendchecklateHeaders { get; set; } = null!;
    public virtual DbSet<FbbTblExceptionError> FbbTblExceptionErrors { get; set; } = null!;
    public virtual DbSet<FbbTblListOfValue> FbbTblListOfValues { get; set; } = null!;
    public virtual DbSet<FbbTblLogging> FbbTblLoggings { get; set; } = null!;
    public virtual DbSet<FbbTblMappingExternal> FbbTblMappingExternals { get; set; } = null!;
    public virtual DbSet<FbbTblMappingId> FbbTblMappingIds { get; set; } = null!;
    public virtual DbSet<FbbTblMappingParameter> FbbTblMappingParameters { get; set; } = null!;
    public virtual DbSet<FbbTblMappingValidate> FbbTblMappingValidates { get; set; } = null!;
    public virtual DbSet<FbbTblMappingWo> FbbTblMappingWos { get; set; } = null!;
    public virtual DbSet<FbbTblWo> FbbTblWos { get; set; } = null!;
    public virtual DbSet<FbbTblWoAttribute> FbbTblWoAttributes { get; set; } = null!;
    public virtual DbSet<FbbTblWoBlame> FbbTblWoBlames { get; set; } = null!;
    public virtual DbSet<FbbTblWoErrorMessage> FbbTblWoErrorMessages { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaCompany> FbbTblWoSoaCompanies { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaCrm> FbbTblWoSoaCrms { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaFee> FbbTblWoSoaFees { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaHeader> FbbTblWoSoaHeaders { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaInstallOrder> FbbTblWoSoaInstallOrders { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaMaOrder> FbbTblWoSoaMaOrders { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaOntop> FbbTblWoSoaOntops { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaResource> FbbTblWoSoaResources { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaStaff> FbbTblWoSoaStaffs { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaTeam> FbbTblWoSoaTeams { get; set; } = null!;
    public virtual DbSet<FbbTblWoSoaWfm> FbbTblWoSoaWfms { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        ////if (!optionsBuilder.IsConfigured)
        ////{
        ////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        ////    optionsBuilder.UseSqlServer("#######");
        ////}
    }
}
