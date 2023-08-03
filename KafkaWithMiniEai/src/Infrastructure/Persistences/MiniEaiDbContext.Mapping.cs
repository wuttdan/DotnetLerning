using Application.Common.Core;
using Application.Common.Interfaces;
using Domain.Entities.Minieai;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistences;

public partial class MiniEaiDbContext : BaseDbContext, IPrimaryDbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_CI_AS");

        modelBuilder.Entity<FbbTblEvAuthorizationDetail>(entity =>
        {
            entity.ToTable("FBB_TBL_EVAUTHORIZATION_DETAIL");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");

            entity.Property(e => e.EndDate)
                .HasMaxLength(50)
                .HasColumnName("END_DATE");

            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("FIRST_NAME");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("LAST_NAME");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.LocationCode)
                .HasMaxLength(100)
                .HasColumnName("LOCATION_CODE");

            entity.Property(e => e.LocationName)
                .HasMaxLength(100)
                .HasColumnName("LOCATION_NAME");

            entity.Property(e => e.Period)
                .HasMaxLength(50)
                .HasColumnName("PERIOD");

            entity.Property(e => e.Role)
                .HasMaxLength(100)
                .HasColumnName("ROLE");

            entity.Property(e => e.RolePast)
                .HasMaxLength(100)
                .HasColumnName("ROLE_PAST");

            entity.Property(e => e.StartDate)
                .HasMaxLength(50)
                .HasColumnName("START_DATE");

            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("USERNAME");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvauthorizationDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVAUTHORIZATION_DETAIL_FBB_TBL_EVAUTHORIZATION_HEADER");
        });

        modelBuilder.Entity<FbbTblEvAuthorizationHeader>(entity =>
        {
            entity.ToTable("FBB_TBL_EVAUTHORIZATION_HEADER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.AcimAppname)
                .HasMaxLength(100)
                .HasColumnName("ACIM_APPNAME");

            entity.Property(e => e.AcimClientId)
                .HasMaxLength(100)
                .HasColumnName("ACIM_CLIENT_ID");

            entity.Property(e => e.AcimVersion)
                .HasMaxLength(10)
                .HasColumnName("ACIM_VERSION");

            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .HasColumnName("ACTION");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasColumnName("SERVER_NAME");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblEvAutoApproveHeader>(entity =>
        {
            entity.ToTable("FBB_TBL_EVAUTOAPPROVE_HEADER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasColumnName("SERVER_NAME");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.Timestamp)
                .HasMaxLength(50)
                .HasColumnName("TIMESTAMP");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblEvCustomerInfoDetail>(entity =>
        {
            entity.ToTable("FBB_TBL_EVCUSTOMERINFO_DETAIL");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .HasColumnName("FIELD_NAME");

            entity.Property(e => e.FieldValue)
                .HasMaxLength(1024)
                .HasColumnName("FIELD_VALUE");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.TypeGroup).HasColumnName("TYPE_GROUP");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvcustomerinfoDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVCUSTOMERINFO_DETAIL_FBB_TBL_EVCUSTOMERINFO_HEADER");
        });

        modelBuilder.Entity<FbbTblEvCustomerInfoHeader>(entity =>
        {
            entity.ToTable("FBB_TBL_EVCUSTOMERINFO_HEADER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.InternetId)
                .HasMaxLength(50)
                .HasColumnName("INTERNET_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .HasColumnName("ORDER_NO");

            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasColumnName("SERVER_NAME");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblEvJobApproveDetail>(entity =>
        {
            entity.ToTable("FBB_TBL_EVJOBAPPROVE_DETAIL");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.ApproveTime)
                .HasMaxLength(100)
                .HasColumnName("APPROVE_TIME");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvjobapproveDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVJOBAPPROVE_DETAIL_FBB_TBL_EVJOBAPPROVE_HEADER");
        });

        modelBuilder.Entity<FbbTblEvJobApproveHeader>(entity =>
        {
            entity.ToTable("FBB_TBL_EVJOBAPPROVE_HEADER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.InternetId)
                .HasMaxLength(50)
                .HasColumnName("INTERNET_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .HasColumnName("ORDER_NO");

            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasColumnName("SERVER_NAME");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblEvJobIncompleteDetail>(entity =>
        {
            entity.ToTable("FBB_TBL_EVJOBINCOMPLETE_DETAIL");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.AttributeDesc)
                .HasMaxLength(512)
                .HasColumnName("ATTRIBUTE_DESC");

            entity.Property(e => e.AttributeValue)
                .HasMaxLength(512)
                .HasColumnName("ATTRIBUTE_VALUE");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.IncompleteTime)
                .HasMaxLength(100)
                .HasColumnName("INCOMPLETE_TIME");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.Reason)
                .HasMaxLength(1024)
                .HasColumnName("REASON");

            entity.Property(e => e.Remark)
                .HasMaxLength(1024)
                .HasColumnName("REMARK");

            entity.Property(e => e.SubReason)
                .HasMaxLength(1024)
                .HasColumnName("SUB_REASON");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvjobincompleteDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVJOBINCOMPLETE_DETAIL_FBB_TBL_EVJOBINCOMPLETE_HEADER");
        });

        modelBuilder.Entity<FbbTblEvJobIncompleteHeader>(entity =>
        {
            entity.ToTable("FBB_TBL_EVJOBINCOMPLETE_HEADER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.InternetId)
                .HasMaxLength(50)
                .HasColumnName("INTERNET_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .HasColumnName("ORDER_NO");

            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasColumnName("SERVER_NAME");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblEvMicrositeDetail>(entity =>
        {
            entity.ToTable("FBB_TBL_EVMICROSITE_DETAIL");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Address)
                .HasMaxLength(1000)
                .HasColumnName("ADDRESS");

            entity.Property(e => e.Cid)
                .HasMaxLength(1000)
                .HasColumnName("CID");

            entity.Property(e => e.Complete)
                .HasMaxLength(10)
                .HasColumnName("COMPLETE");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.District)
                .HasMaxLength(1000)
                .HasColumnName("DISTRICT");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");

            entity.Property(e => e.Firstname)
                .HasMaxLength(1000)
                .HasColumnName("FIRSTNAME");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.Lastname)
                .HasMaxLength(1000)
                .HasColumnName("LASTNAME");

            entity.Property(e => e.MediaStreaming)
                .HasMaxLength(1000)
                .HasColumnName("MEDIA_STREAMING");

            entity.Property(e => e.NumberOfUser)
                .HasMaxLength(10)
                .HasColumnName("NUMBER_OF_USER");

            entity.Property(e => e.Package)
                .HasMaxLength(500)
                .HasColumnName("PACKAGE");

            entity.Property(e => e.PackageCode)
                .HasMaxLength(50)
                .HasColumnName("PACKAGE_CODE");

            entity.Property(e => e.PlayboxAddon)
                .HasMaxLength(100)
                .HasColumnName("PLAYBOX_ADDON");

            entity.Property(e => e.PlayboxBundle)
                .HasMaxLength(100)
                .HasColumnName("PLAYBOX_BUNDLE");

            entity.Property(e => e.Price)
                .HasMaxLength(10)
                .HasColumnName("PRICE");

            entity.Property(e => e.Province)
                .HasMaxLength(1000)
                .HasColumnName("PROVINCE");

            entity.Property(e => e.Residential)
                .HasMaxLength(100)
                .HasColumnName("RESIDENTIAL");

            entity.Property(e => e.RouterAddon)
                .HasMaxLength(100)
                .HasColumnName("ROUTER_ADDON");

            entity.Property(e => e.RouterBundle)
                .HasMaxLength(100)
                .HasColumnName("ROUTER_BUNDLE");

            entity.Property(e => e.Segment)
                .HasMaxLength(100)
                .HasColumnName("SEGMENT");

            entity.Property(e => e.Speed)
                .HasMaxLength(50)
                .HasColumnName("SPEED");

            entity.Property(e => e.Subdistrict)
                .HasMaxLength(1000)
                .HasColumnName("SUBDISTRICT");

            entity.Property(e => e.Telephone)
                .HasMaxLength(50)
                .HasColumnName("TELEPHONE");

            entity.Property(e => e.TypeOfUser)
                .HasMaxLength(500)
                .HasColumnName("TYPE_OF_USER");

            entity.Property(e => e.User)
                .HasMaxLength(1000)
                .HasColumnName("USER");

            entity.Property(e => e.UserJourney)
                .HasMaxLength(1000)
                .HasColumnName("USER_JOURNEY");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(50)
                .HasColumnName("ZIPCODE");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvmicrositeDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVMICROSITE_DETAIL_FBB_TBL_EVMICROSITE_HEADER");
        });

        modelBuilder.Entity<FbbTblEvMicrositeHeader>(entity =>
        {
            entity.ToTable("FBB_TBL_EVMICROSITE_HEADER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .HasColumnName("ORDER_NO");

            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasColumnName("SERVER_NAME");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblEvMicrositeUpdDetail>(entity =>
        {
            entity.ToTable("FBB_TBL_EVMICROSITEUPD_DETAIL");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.DateAction)
                .HasMaxLength(255)
                .HasColumnName("DATE_ACTION");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.IsContactCustomer)
                .HasMaxLength(50)
                .HasColumnName("IS_CONTACT_CUSTOMER");

            entity.Property(e => e.IsInCoverage)
                .HasMaxLength(50)
                .HasColumnName("IS_IN_COVERAGE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderChannel)
                .HasMaxLength(50)
                .HasColumnName("ORDER_CHANNEL");

            entity.Property(e => e.OrderPreRegister)
                .HasMaxLength(1000)
                .HasColumnName("ORDER_PRE_REGISTER");

            entity.Property(e => e.RemarkNote)
                .HasMaxLength(3000)
                .HasColumnName("REMARK_NOTE");

            entity.Property(e => e.StatusOrder)
                .HasMaxLength(50)
                .HasColumnName("STATUS_ORDER");

            entity.Property(e => e.UserAction)
                .HasMaxLength(100)
                .HasColumnName("USER_ACTION");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvmicrositeupdDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVMICROSITEUPD_DETAIL_FBB_TBL_EVMICROSITEUPD_HEADER");
        });

        modelBuilder.Entity<FbbTblEvMicrositeUpdHeader>(entity =>
        {
            entity.ToTable("FBB_TBL_EVMICROSITEUPD_HEADER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .HasColumnName("ORDER_NO");

            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasColumnName("SERVER_NAME");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblEvNotifyAppointmentCompany>(entity =>
        {
            entity.ToTable("FBB_TBL_EVNOTIFYAPPOINTMENT_COMPANIES");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("COMPANY_ID");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(512)
                .HasColumnName("COMPANY_NAME");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.LocationCode)
                .HasMaxLength(50)
                .HasColumnName("LOCATION_CODE");

            entity.Property(e => e.StaffId).HasColumnName("STAFF_ID");

            entity.Property(e => e.StorageLocation)
                .HasMaxLength(50)
                .HasColumnName("STORAGE_LOCATION");

            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .HasColumnName("VENDOR_CODE");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvnotifyappointmentCompanies)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVNOTIFYAPPOINTMENT_COMPANIES_FBB_TBL_EVNOTIFYAPPOINTMENT_HEADER");
        });

        modelBuilder.Entity<FbbTblEvNotifyAppointmentCrm>(entity =>
        {
            entity.ToTable("FBB_TBL_EVNOTIFYAPPOINTMENT_CRMS");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Author)
                .HasMaxLength(100)
                .HasColumnName("AUTHOR");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

            entity.Property(e => e.RemarkDate)
                .HasMaxLength(50)
                .HasColumnName("REMARK_DATE");

            entity.Property(e => e.SubcontractRemarks).HasColumnName("SUBCONTRACT_REMARKS");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.FbbTblEvnotifyappointmentCrms)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVNOTIFYAPPOINTMENT_CRMS_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER");
        });

        modelBuilder.Entity<FbbTblEvNotifyAppointmentFee>(entity =>
        {
            entity.ToTable("FBB_TBL_EVNOTIFYAPPOINTMENT_FEES");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Data)
                .HasMaxLength(512)
                .HasColumnName("DATA");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.FbbTblEvnotifyappointmentFees)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVNOTIFYAPPOINTMENT_FEES_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER");
        });

        modelBuilder.Entity<FbbTblEvNotifyAppointmentHeader>(entity =>
        {
            entity.ToTable("FBB_TBL_EVNOTIFYAPPOINTMENT_HEADER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.FibrenetId)
                .HasMaxLength(50)
                .HasColumnName("FIBRENET_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.MsgSeqId)
                .HasMaxLength(50)
                .HasColumnName("MSG_SEQ_ID");

            entity.Property(e => e.OrderType)
                .HasMaxLength(50)
                .HasColumnName("ORDER_TYPE");

            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasColumnName("SERVER_NAME");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");

            entity.Property(e => e.TypeOperDate)
                .HasMaxLength(50)
                .HasColumnName("TYPE_OPER_DATE");
        });

        modelBuilder.Entity<FbbTblEvNotifyAppointmentOntop>(entity =>
        {
            entity.ToTable("FBB_TBL_EVNOTIFYAPPOINTMENT_ONTOPS");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Data)
                .HasMaxLength(512)
                .HasColumnName("DATA");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.FbbTblEvnotifyappointmentOntops)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVNOTIFYAPPOINTMENT_ONTOPS_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER");
        });

        modelBuilder.Entity<FbbTblEvNotifyAppointmentOrder>(entity =>
        {
            entity.ToTable("FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.AcceptDate)
                .HasMaxLength(50)
                .HasColumnName("ACCEPT_DATE");

            entity.Property(e => e.AccessMode)
                .HasMaxLength(50)
                .HasColumnName("ACCESS_MODE");

            entity.Property(e => e.AppointmentDate)
                .HasMaxLength(50)
                .HasColumnName("APPOINTMENT_DATE");

            entity.Property(e => e.AppointmentTimeslot)
                .HasMaxLength(50)
                .HasColumnName("APPOINTMENT_TIMESLOT");

            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .HasColumnName("BRAND");

            entity.Property(e => e.CommitDate)
                .HasMaxLength(50)
                .HasColumnName("COMMIT_DATE");

            entity.Property(e => e.ComplaintDescription).HasColumnName("COMPLAINT_DESCRIPTION");

            entity.Property(e => e.ComplaintTitle)
                .HasMaxLength(512)
                .HasColumnName("COMPLAINT_TITLE");

            entity.Property(e => e.ContactMobilePhone1)
                .HasMaxLength(50)
                .HasColumnName("CONTACT_MOBILE_PHONE1");

            entity.Property(e => e.ContactMobilePhone2)
                .HasMaxLength(50)
                .HasColumnName("CONTACT_MOBILE_PHONE2");

            entity.Property(e => e.ContactMobilePhone3)
                .HasMaxLength(50)
                .HasColumnName("CONTACT_MOBILE_PHONE3");

            entity.Property(e => e.ContactPersonName)
                .HasMaxLength(255)
                .HasColumnName("CONTACT_PERSON_NAME");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.CustomerComplaintMobile)
                .HasMaxLength(50)
                .HasColumnName("CUSTOMER_COMPLAINT_MOBILE");

            entity.Property(e => e.CustomerComplaintName)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_COMPLAINT_NAME");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_NAME");

            entity.Property(e => e.CustomerOrderNo)
                .HasMaxLength(50)
                .HasColumnName("CUSTOMER_ORDER_NO");

            entity.Property(e => e.DetailsForResolved).HasColumnName("DETAILS_FOR_RESOLVED");

            entity.Property(e => e.DownlinkRate)
                .HasMaxLength(50)
                .HasColumnName("DOWNLINK_RATE");

            entity.Property(e => e.EventflowFlag)
                .HasMaxLength(50)
                .HasColumnName("EVENTFLOW_FLAG");

            entity.Property(e => e.FbssOrderNo)
                .HasMaxLength(50)
                .HasColumnName("FBSS_ORDER_NO");

            entity.Property(e => e.FibrenetId)
                .HasMaxLength(50)
                .HasColumnName("FIBRENET_ID");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.InstallationAddress)
                .HasMaxLength(4000)
                .HasColumnName("INSTALLATION_ADDRESS");

            entity.Property(e => e.InstallationLatitude)
                .HasMaxLength(50)
                .HasColumnName("INSTALLATION_LATITUDE");

            entity.Property(e => e.InstallationLongitude)
                .HasMaxLength(50)
                .HasColumnName("INSTALLATION_LONGITUDE");

            entity.Property(e => e.JobPriority)
                .HasMaxLength(100)
                .HasColumnName("JOB_PRIORITY");

            entity.Property(e => e.JobState)
                .HasMaxLength(50)
                .HasColumnName("JOB_STATE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.NocNumber)
                .HasMaxLength(50)
                .HasColumnName("NOC_NUMBER");

            entity.Property(e => e.NocRemark).HasColumnName("NOC_REMARK");

            entity.Property(e => e.OntopPack)
                .HasMaxLength(512)
                .HasColumnName("ONTOP_PACK");

            entity.Property(e => e.OrderType)
                .HasMaxLength(255)
                .HasColumnName("ORDER_TYPE");

            entity.Property(e => e.PlayboxContent)
                .HasMaxLength(512)
                .HasColumnName("PLAYBOX_CONTENT");

            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .HasColumnName("PRODUCT_NAME");

            entity.Property(e => e.ReplaceOntFlag)
                .HasMaxLength(255)
                .HasColumnName("REPLACE_ONT_FLAG");

            entity.Property(e => e.ReplaceRouterFlag)
                .HasMaxLength(255)
                .HasColumnName("REPLACE_ROUTER_FLAG");

            entity.Property(e => e.RouterNum)
                .HasMaxLength(10)
                .HasColumnName("ROUTER_NUM");

            entity.Property(e => e.Service)
                .HasMaxLength(50)
                .HasColumnName("SERVICE");

            entity.Property(e => e.ServiceLevel)
                .HasMaxLength(50)
                .HasColumnName("SERVICE_LEVEL");

            entity.Property(e => e.ServicePack)
                .HasMaxLength(512)
                .HasColumnName("SERVICE_PACK");

            entity.Property(e => e.SiebelRequestNo)
                .HasMaxLength(50)
                .HasColumnName("SIEBEL_REQUEST_NO");

            entity.Property(e => e.TaskOrderNo)
                .HasMaxLength(50)
                .HasColumnName("TASK_ORDER_NO");

            entity.Property(e => e.TotalFee)
                .HasMaxLength(512)
                .HasColumnName("TOTAL_FEE");

            entity.Property(e => e.TroubleSymptom)
                .HasMaxLength(512)
                .HasColumnName("TROUBLE_SYMPTOM");

            entity.Property(e => e.TroubleTicketNo)
                .HasMaxLength(50)
                .HasColumnName("TROUBLE_TICKET_NO");

            entity.Property(e => e.UplinkRate)
                .HasMaxLength(50)
                .HasColumnName("UPLINK_RATE");

            entity.Property(e => e.VoipNumber1)
                .HasMaxLength(50)
                .HasColumnName("VOIP_NUMBER1");

            entity.Property(e => e.VoipNumber2)
                .HasMaxLength(50)
                .HasColumnName("VOIP_NUMBER2");

            entity.Property(e => e.VoipPassword1)
                .HasMaxLength(50)
                .HasColumnName("VOIP_PASSWORD1");

            entity.Property(e => e.VoipPassword2)
                .HasMaxLength(50)
                .HasColumnName("VOIP_PASSWORD2");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvnotifyappointmentOrders)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER_FBB_TBL_EVNOTIFYAPPOINTMENT_HEADER");
        });

        modelBuilder.Entity<FbbTblEvNotifyAppointmentResource>(entity =>
        {
            entity.ToTable("FBB_TBL_EVNOTIFYAPPOINTMENT_RESOURCE");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.ActivationId)
                .HasMaxLength(50)
                .HasColumnName("ACTIVATION_ID");

            entity.Property(e => e.CpeInstallation)
                .HasMaxLength(50)
                .HasColumnName("CPE_INSTALLATION");

            entity.Property(e => e.CpeModel)
                .HasMaxLength(50)
                .HasColumnName("CPE_MODEL");

            entity.Property(e => e.CpeSn)
                .HasMaxLength(50)
                .HasColumnName("CPE_SN");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Cvlan)
                .HasMaxLength(255)
                .HasColumnName("CVLAN");

            entity.Property(e => e.DeviceModel)
                .HasMaxLength(50)
                .HasColumnName("DEVICE_MODEL");

            entity.Property(e => e.DownlinkRate)
                .HasMaxLength(50)
                .HasColumnName("DOWNLINK_RATE");

            entity.Property(e => e.DropWireDistance)
                .HasMaxLength(50)
                .HasColumnName("DROP_WIRE_DISTANCE");

            entity.Property(e => e.DslamManufacturer)
                .HasMaxLength(50)
                .HasColumnName("DSLAM_MANUFACTURER");

            entity.Property(e => e.DslamPort)
                .HasMaxLength(50)
                .HasColumnName("DSLAM_PORT");

            entity.Property(e => e.EndPointLatitude)
                .HasMaxLength(50)
                .HasColumnName("END_POINT_LATITUDE");

            entity.Property(e => e.EndPointLongitude)
                .HasMaxLength(50)
                .HasColumnName("END_POINT_LONGITUDE");

            entity.Property(e => e.ExistingDropWireId)
                .HasMaxLength(50)
                .HasColumnName("EXISTING_DROP_WIRE_ID");

            entity.Property(e => e.Gemport)
                .HasMaxLength(255)
                .HasColumnName("GEMPORT");

            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .HasColumnName("IP_ADDRESS");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.MdfOutPort)
                .HasMaxLength(255)
                .HasColumnName("MDF_OUT_PORT");

            entity.Property(e => e.NewDropWireId)
                .HasMaxLength(50)
                .HasColumnName("NEW_DROP_WIRE_ID");

            entity.Property(e => e.OdfFiberCore)
                .HasMaxLength(255)
                .HasColumnName("ODF_FIBER_CORE");

            entity.Property(e => e.OdfIn)
                .HasMaxLength(50)
                .HasColumnName("ODF_IN");

            entity.Property(e => e.OdfOut)
                .HasMaxLength(50)
                .HasColumnName("ODF_OUT");

            entity.Property(e => e.OltManufacturer)
                .HasMaxLength(50)
                .HasColumnName("OLT_MANUFACTURER");

            entity.Property(e => e.OltName)
                .HasMaxLength(50)
                .HasColumnName("OLT_NAME");

            entity.Property(e => e.OltPonPort)
                .HasMaxLength(255)
                .HasColumnName("OLT_PON_PORT");

            entity.Property(e => e.Onu)
                .HasMaxLength(50)
                .HasColumnName("ONU");

            entity.Property(e => e.OnuId)
                .HasMaxLength(50)
                .HasColumnName("ONU_ID");

            entity.Property(e => e.OnuModel)
                .HasMaxLength(50)
                .HasColumnName("ONU_MODEL");

            entity.Property(e => e.OnuUplinkPort)
                .HasMaxLength(50)
                .HasColumnName("ONU_UPLINK_PORT");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("PASSWORD");

            entity.Property(e => e.ReuseFlag)
                .HasMaxLength(255)
                .HasColumnName("REUSE_FLAG");

            entity.Property(e => e.Service)
                .HasMaxLength(50)
                .HasColumnName("SERVICE");

            entity.Property(e => e.Sp1FiberCore)
                .HasMaxLength(255)
                .HasColumnName("SP1_FIBER_CORE");

            entity.Property(e => e.Sp1InPort)
                .HasMaxLength(255)
                .HasColumnName("SP1_IN_PORT");

            entity.Property(e => e.Sp1Latitude)
                .HasMaxLength(50)
                .HasColumnName("SP1_LATITUDE");

            entity.Property(e => e.Sp1Longitude)
                .HasMaxLength(50)
                .HasColumnName("SP1_LONGITUDE");

            entity.Property(e => e.Sp1OutPort)
                .HasMaxLength(255)
                .HasColumnName("SP1_OUT_PORT");

            entity.Property(e => e.Sp1RunningState)
                .HasMaxLength(50)
                .HasColumnName("SP1_RUNNING_STATE");

            entity.Property(e => e.Sp2Distance)
                .HasMaxLength(50)
                .HasColumnName("SP2_DISTANCE");

            entity.Property(e => e.Sp2InPort)
                .HasMaxLength(255)
                .HasColumnName("SP2_IN_PORT");

            entity.Property(e => e.Sp2Latitude)
                .HasMaxLength(50)
                .HasColumnName("SP2_LATITUDE");

            entity.Property(e => e.Sp2Longitude)
                .HasMaxLength(50)
                .HasColumnName("SP2_LONGITUDE");

            entity.Property(e => e.Sp2OutPort)
                .HasMaxLength(255)
                .HasColumnName("SP2_OUT_PORT");

            entity.Property(e => e.Sp2RunningState)
                .HasMaxLength(50)
                .HasColumnName("SP2_RUNNING_STATE");

            entity.Property(e => e.SplitterDistance)
                .HasMaxLength(50)
                .HasColumnName("SPLITTER_DISTANCE");

            entity.Property(e => e.SplitterNamePrimary)
                .HasMaxLength(50)
                .HasColumnName("SPLITTER_NAME_PRIMARY");

            entity.Property(e => e.SplitterPort)
                .HasMaxLength(50)
                .HasColumnName("SPLITTER_PORT");

            entity.Property(e => e.StandardAddressName)
                .HasMaxLength(512)
                .HasColumnName("STANDARD_ADDRESS_NAME");

            entity.Property(e => e.Svlan)
                .HasMaxLength(255)
                .HasColumnName("SVLAN");

            entity.Property(e => e.Tcont)
                .HasMaxLength(255)
                .HasColumnName("TCONT");

            entity.Property(e => e.UplinkRate)
                .HasMaxLength(50)
                .HasColumnName("UPLINK_RATE");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.FbbTblEvnotifyappointmentResources)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVNOTIFYAPPOINTMENT_RESOURCE_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER");
        });

        modelBuilder.Entity<FbbTblEvNotifyAppointmentStaff>(entity =>
        {
            entity.ToTable("FBB_TBL_EVNOTIFYAPPOINTMENT_STAFFS");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.StaffCode)
                .HasMaxLength(50)
                .HasColumnName("STAFF_CODE");

            entity.Property(e => e.StaffEmail)
                .HasMaxLength(100)
                .HasColumnName("STAFF_EMAIL");

            entity.Property(e => e.StaffEndDayWorking)
                .HasMaxLength(50)
                .HasColumnName("STAFF_END_DAY_WORKING");

            entity.Property(e => e.StaffFirstDayWorking)
                .HasMaxLength(50)
                .HasColumnName("STAFF_FIRST_DAY_WORKING");

            entity.Property(e => e.StaffLatitude)
                .HasMaxLength(50)
                .HasColumnName("STAFF_LATITUDE");

            entity.Property(e => e.StaffLongitude)
                .HasMaxLength(50)
                .HasColumnName("STAFF_LONGITUDE");

            entity.Property(e => e.StaffName)
                .HasMaxLength(100)
                .HasColumnName("STAFF_NAME");

            entity.Property(e => e.StaffPhone)
                .HasMaxLength(20)
                .HasColumnName("STAFF_PHONE");

            entity.Property(e => e.StaffProfilePictureFilename)
                .HasMaxLength(255)
                .HasColumnName("STAFF_PROFILE_PICTURE_FILENAME");

            entity.Property(e => e.StaffRole)
                .HasMaxLength(100)
                .HasColumnName("STAFF_ROLE");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvnotifyappointmentStaffs)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVNOTIFYAPPOINTMENT_STAFFS_FBB_TBL_EVNOTIFYAPPOINTMENT_HEADER");
        });

        modelBuilder.Entity<FbbTblEvNotifyAppointmentTeam>(entity =>
        {
            entity.ToTable("FBB_TBL_EVNOTIFYAPPOINTMENT_TEAMS");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.LocationCode)
                .HasMaxLength(50)
                .HasColumnName("LOCATION_CODE");

            entity.Property(e => e.ShipTo)
                .HasMaxLength(50)
                .HasColumnName("SHIP_TO");

            entity.Property(e => e.StorageLocation)
                .HasMaxLength(50)
                .HasColumnName("STORAGE_LOCATION");

            entity.Property(e => e.TeamId)
                .HasMaxLength(50)
                .HasColumnName("TEAM_ID");

            entity.Property(e => e.TeamName)
                .HasMaxLength(255)
                .HasColumnName("TEAM_NAME");

            entity.Property(e => e.TeamService)
                .HasMaxLength(1024)
                .HasColumnName("TEAM_SERVICE");

            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .HasColumnName("VENDOR_CODE");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvnotifyappointmentTeams)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVNOTIFYAPPOINTMENT_TEAMS_FBB_TBL_EVNOTIFYAPPOINTMENT_HEADER");
        });

        modelBuilder.Entity<FbbTblEvNotifyAppointmentWfm>(entity =>
        {
            entity.ToTable("FBB_TBL_EVNOTIFYAPPOINTMENT_WFMS");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Author)
                .HasMaxLength(100)
                .HasColumnName("AUTHOR");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

            entity.Property(e => e.RemarkDate)
                .HasMaxLength(50)
                .HasColumnName("REMARK_DATE");

            entity.Property(e => e.SubcontractRemarks).HasColumnName("SUBCONTRACT_REMARKS");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.FbbTblEvnotifyappointmentWfms)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVNOTIFYAPPOINTMENT_WFMS_FBB_TBL_EVNOTIFYAPPOINTMENT_ORDER");
        });

        modelBuilder.Entity<FbbTblEvsendchecklateDetail>(entity =>
        {
            entity.ToTable("FBB_TBL_EVSENDCHECKLATE_DETAIL");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.FieldName)
                .HasMaxLength(50)
                .HasColumnName("FIELD_NAME");

            entity.Property(e => e.FieldValue)
                .HasMaxLength(1024)
                .HasColumnName("FIELD_VALUE");

            entity.Property(e => e.HeaderId).HasColumnName("HEADER_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.TypeGroup).HasColumnName("TYPE_GROUP");

            entity.HasOne(d => d.Header)
                .WithMany(p => p.FbbTblEvsendchecklateDetails)
                .HasForeignKey(d => d.HeaderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_EVSENDCHECKLATE_DETAIL_FBB_TBL_EVSENDCHECKLATE_HEADER");
        });

        modelBuilder.Entity<FbbTblEvsendchecklateHeader>(entity =>
        {
            entity.ToTable("FBB_TBL_EVSENDCHECKLATE_HEADER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.InternetId)
                .HasMaxLength(50)
                .HasColumnName("INTERNET_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .HasColumnName("ORDER_NO");

            entity.Property(e => e.OrderType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_TYPE");

            entity.Property(e => e.ServerName)
                .HasMaxLength(100)
                .HasColumnName("SERVER_NAME");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblExceptionError>(entity =>
        {
            entity.ToTable("FBB_TBL_EXCEPTION_ERROR");

            entity.HasIndex(e => e.TransactionId, "NonClusteredIndex-20210409-175036");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ErrorMessage)
                .HasColumnType("text")
                .HasColumnName("ERROR_MESSAGE");

            entity.Property(e => e.Fucntion)
                .HasMaxLength(50)
                .HasColumnName("FUCNTION");

            entity.Property(e => e.Service)
                .HasMaxLength(50)
                .HasColumnName("SERVICE");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblListOfValue>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FBB_TBL_LIST_OF_VALUE");

            entity.Property(e => e.ActiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_FLAG");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXTERNAL_ID");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.LovName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOV_NAME");

            entity.Property(e => e.LovValue1)
                .HasMaxLength(2048)
                .HasColumnName("LOV_VALUE1");

            entity.Property(e => e.LovValue2)
                .HasMaxLength(255)
                .HasColumnName("LOV_VALUE2");

            entity.Property(e => e.LovValue3)
                .HasMaxLength(255)
                .HasColumnName("LOV_VALUE3");
        });

        modelBuilder.Entity<FbbTblLogging>(entity =>
        {
            entity.ToTable("FBB_TBL_LOGGING");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.RequestDate)
                .HasColumnType("datetime")
                .HasColumnName("REQUEST_DATE");

            entity.Property(e => e.RequestEvent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REQUEST_EVENT");

            entity.Property(e => e.RequestMessage)
                .HasColumnType("text")
                .HasColumnName("REQUEST_MESSAGE");

            entity.Property(e => e.RequestMethod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REQUEST_METHOD");

            entity.Property(e => e.RequestPath)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REQUEST_PATH");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblMappingExternal>(entity =>
        {
            entity.ToTable("FBB_TBL_MAPPING_EXTERNAL");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.EndpointName)
                .HasMaxLength(100)
                .HasColumnName("ENDPOINT_NAME");

            entity.Property(e => e.EventName)
                .HasMaxLength(50)
                .HasColumnName("EVENT_NAME");

            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .HasColumnName("EXTERNAL_ID");

            entity.Property(e => e.IsOnline)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IS_ONLINE")
                .IsFixedLength();

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.MappingWo).HasColumnName("MAPPING_WO");

            entity.Property(e => e.RequestTimeout).HasColumnName("REQUEST_TIMEOUT");

            entity.Property(e => e.RetryCount).HasColumnName("RETRY_COUNT");

            entity.Property(e => e.SleepTimes).HasColumnName("SLEEP_TIMES");

            entity.Property(e => e.Typews)
                .HasMaxLength(50)
                .HasColumnName("TYPEWS");

            entity.Property(e => e.UrlEndpoint).HasColumnName("URL_ENDPOINT");

            entity.HasOne(d => d.MappingWoNavigation)
                .WithMany(p => p.FbbTblMappingExternals)
                .HasForeignKey(d => d.MappingWo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_MAPPING_EXTERNAL_FBB_TBL_MAPPING_WO");
        });

        modelBuilder.Entity<FbbTblMappingId>(entity =>
        {
            entity.ToTable("FBB_TBL_MAPPING_ID");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.AppSoucre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APP_SOUCRE");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.ResponseTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RESPONSE_TIME");

            entity.Property(e => e.TypeEvent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE_EVENT");
        });

        modelBuilder.Entity<FbbTblMappingParameter>(entity =>
        {
            entity.ToTable("FBB_TBL_MAPPING_PARAMETER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.ColumnName)
                .HasMaxLength(255)
                .HasColumnName("COLUMN_NAME");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.DefaultValue)
                .HasMaxLength(255)
                .HasColumnName("DEFAULT_VALUE");

            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .HasColumnName("EXTERNAL_ID");

            entity.Property(e => e.FieldNameValue)
                .HasMaxLength(255)
                .HasColumnName("FIELD_NAME_VALUE");

            entity.Property(e => e.FormatValue)
                .HasMaxLength(50)
                .HasColumnName("FORMAT_VALUE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.MappingWo).HasColumnName("MAPPING_WO");

            entity.Property(e => e.ParamXmlName)
                .HasMaxLength(255)
                .HasColumnName("PARAM_XML_NAME");

            entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

            entity.Property(e => e.SourceTable)
                .HasMaxLength(255)
                .HasColumnName("SOURCE_TABLE");

            entity.HasOne(d => d.MappingWoNavigation)
                .WithMany(p => p.FbbTblMappingParameters)
                .HasForeignKey(d => d.MappingWo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_MAPPING_PARAMETER_FBB_TBL_MAPPING_WO");
        });

        modelBuilder.Entity<FbbTblMappingValidate>(entity =>
        {
            entity.ToTable("FBB_TBL_MAPPING_VALIDATE");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.ActiveFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_FLAG")
                .IsFixedLength();

            entity.Property(e => e.AppSoucre)
                .HasMaxLength(50)
                .HasColumnName("APP_SOUCRE");

            entity.Property(e => e.ConstraintValidate)
                .HasMaxLength(50)
                .HasColumnName("CONSTRAINT_VALIDATE");

            entity.Property(e => e.MappingId).HasColumnName("MAPPING_ID");

            entity.Property(e => e.ParameterXml)
                .HasMaxLength(512)
                .HasColumnName("PARAMETER_XML");

            entity.HasOne(d => d.Mapping)
                .WithMany(p => p.FbbTblMappingValidates)
                .HasForeignKey(d => d.MappingId)
                .HasConstraintName("FK_FBB_TBL_MAPPING_VALIDATE_FBB_TBL_MAPPING_ID");
        });

        modelBuilder.Entity<FbbTblMappingWo>(entity =>
        {
            entity.ToTable("FBB_TBL_MAPPING_WO");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");

            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .HasColumnName("EXTERNAL_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.MappingId).HasColumnName("MAPPING_ID");

            entity.Property(e => e.SeqNum).HasColumnName("SEQ_NUM");

            entity.Property(e => e.TypeExternal)
                .HasMaxLength(50)
                .HasColumnName("TYPE_EXTERNAL");
        });

        modelBuilder.Entity<FbbTblWo>(entity =>
        {
            entity.ToTable("FBB_TBL_WO");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .HasColumnName("DESTINATION");

            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .HasColumnName("EXTERNAL_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .HasColumnName("ORDER_NO");

            entity.Property(e => e.RequestDate)
                .HasColumnType("datetime")
                .HasColumnName("REQUEST_DATE");

            entity.Property(e => e.ResponseDate)
                .HasColumnType("datetime")
                .HasColumnName("RESPONSE_DATE");

            entity.Property(e => e.RetryNo)
                .HasColumnName("RETRY_NO")
                .HasDefaultValueSql("((-1))");

            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("STATUS");

            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TRANSACTION_ID");
        });

        modelBuilder.Entity<FbbTblWoAttribute>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_ATTRIBUTE");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("NAME");

            entity.Property(e => e.TypeGroup).HasColumnName("TYPE_GROUP");

            entity.Property(e => e.Value)
                .HasMaxLength(1024)
                .HasColumnName("VALUE");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoAttributes)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_ATTRIBUTE_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoBlame>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_BLAME");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.FieldPath)
                .HasMaxLength(255)
                .HasColumnName("FIELD_PATH");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.ValueAfter).HasColumnName("VALUE_AFTER");

            entity.Property(e => e.ValueBefore).HasColumnName("VALUE_BEFORE");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoBlames)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_BLAME_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoErrorMessage>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_ERROR_MESSAGE");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.ErrorCode)
                .HasMaxLength(100)
                .HasColumnName("ERROR_CODE");

            entity.Property(e => e.ErrorDesc)
                .HasMaxLength(2048)
                .HasColumnName("ERROR_DESC");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.Remark)
                .HasMaxLength(2048)
                .HasColumnName("REMARK");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoErrorMessages)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_ERROR_MESSAGE_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaCompany>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_COMPANIES");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("COMPANY_ID");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(512)
                .HasColumnName("COMPANY_NAME");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.LocationCode)
                .HasMaxLength(50)
                .HasColumnName("LOCATION_CODE");

            entity.Property(e => e.StaffId).HasColumnName("STAFF_ID");

            entity.Property(e => e.StorageLocation)
                .HasMaxLength(50)
                .HasColumnName("STORAGE_LOCATION");

            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .HasColumnName("VENDOR_CODE");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaCompanies)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_COMPANIES_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaCrm>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_CRMS");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Author)
                .HasMaxLength(100)
                .HasColumnName("AUTHOR");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.RemarkDate)
                .HasMaxLength(50)
                .HasColumnName("REMARK_DATE");

            entity.Property(e => e.SubcontractRemarks).HasColumnName("SUBCONTRACT_REMARKS");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaCrms)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_CRMS_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaFee>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_FEES");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Data)
                .HasMaxLength(512)
                .HasColumnName("DATA");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaFees)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_FEES_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaHeader>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_HEADER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.FibrenetId)
                .HasMaxLength(50)
                .HasColumnName("FIBRENET_ID");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.MsgSeqId)
                .HasMaxLength(50)
                .HasColumnName("MSG_SEQ_ID");

            entity.Property(e => e.OrderType)
                .HasMaxLength(50)
                .HasColumnName("ORDER_TYPE");

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");

            entity.Property(e => e.TypeOperDate)
                .HasMaxLength(50)
                .HasColumnName("TYPE_OPER_DATE");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaHeaders)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_HEADER_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaInstallOrder>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_INSTALL_ORDER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.AccessMode)
                .HasMaxLength(50)
                .HasColumnName("ACCESS_MODE");

            entity.Property(e => e.AppointmentDate)
                .HasMaxLength(50)
                .HasColumnName("APPOINTMENT_DATE");

            entity.Property(e => e.AppointmentTimeslot)
                .HasMaxLength(50)
                .HasColumnName("APPOINTMENT_TIMESLOT");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .HasColumnName("AREA");

            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .HasColumnName("BRAND");

            entity.Property(e => e.BuildingName)
                .HasMaxLength(255)
                .HasColumnName("BUILDING_NAME");

            entity.Property(e => e.ContactMobilePhone1)
                .HasMaxLength(50)
                .HasColumnName("CONTACT_MOBILE_PHONE1");

            entity.Property(e => e.ContactMobilePhone2)
                .HasMaxLength(50)
                .HasColumnName("CONTACT_MOBILE_PHONE2");

            entity.Property(e => e.ContactMobilePhone3)
                .HasMaxLength(50)
                .HasColumnName("CONTACT_MOBILE_PHONE3");

            entity.Property(e => e.ContactPersonName)
                .HasMaxLength(255)
                .HasColumnName("CONTACT_PERSON_NAME");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.CsNote).HasColumnName("CS_NOTE");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_NAME");

            entity.Property(e => e.CustomerOrderNo)
                .HasMaxLength(50)
                .HasColumnName("CUSTOMER_ORDER_NO");

            entity.Property(e => e.EventflowFlag)
                .HasMaxLength(50)
                .HasColumnName("EVENTFLOW_FLAG");

            entity.Property(e => e.FbssOrderNo)
                .HasMaxLength(50)
                .HasColumnName("FBSS_ORDER_NO");

            entity.Property(e => e.FibrenetId)
                .HasMaxLength(50)
                .HasColumnName("FIBRENET_ID");

            entity.Property(e => e.InstallationAddress)
                .HasMaxLength(512)
                .HasColumnName("INSTALLATION_ADDRESS");

            entity.Property(e => e.InstallationLatitude)
                .HasMaxLength(50)
                .HasColumnName("INSTALLATION_LATITUDE");

            entity.Property(e => e.InstallationLongitude)
                .HasMaxLength(50)
                .HasColumnName("INSTALLATION_LONGITUDE");

            entity.Property(e => e.JobPriority)
                .HasMaxLength(100)
                .HasColumnName("JOB_PRIORITY");

            entity.Property(e => e.JobState)
                .HasMaxLength(50)
                .HasColumnName("JOB_STATE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.OntopPack)
                .HasMaxLength(512)
                .HasColumnName("ONTOP_PACK");

            entity.Property(e => e.OrderType)
                .HasMaxLength(255)
                .HasColumnName("ORDER_TYPE");

            entity.Property(e => e.PlayboxContent)
                .HasMaxLength(512)
                .HasColumnName("PLAYBOX_CONTENT");

            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .HasColumnName("PRODUCT_NAME");

            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .HasColumnName("REGION");

            entity.Property(e => e.ReplaceOntFlag)
                .HasMaxLength(255)
                .HasColumnName("REPLACE_ONT_FLAG");

            entity.Property(e => e.ReplaceRouterFlag)
                .HasMaxLength(255)
                .HasColumnName("REPLACE_ROUTER_FLAG");

            entity.Property(e => e.RouterNum)
                .HasMaxLength(10)
                .HasColumnName("ROUTER_NUM");

            entity.Property(e => e.ServiceLevel)
                .HasMaxLength(50)
                .HasColumnName("SERVICE_LEVEL");

            entity.Property(e => e.ServicePack)
                .HasMaxLength(512)
                .HasColumnName("SERVICE_PACK");

            entity.Property(e => e.TaskOrderNo)
                .HasMaxLength(50)
                .HasColumnName("TASK_ORDER_NO");

            entity.Property(e => e.TotalFee)
                .HasMaxLength(512)
                .HasColumnName("TOTAL_FEE");

            entity.Property(e => e.VoipNumber1)
                .HasMaxLength(50)
                .HasColumnName("VOIP_NUMBER1");

            entity.Property(e => e.VoipNumber2)
                .HasMaxLength(50)
                .HasColumnName("VOIP_NUMBER2");

            entity.Property(e => e.VoipPassword1)
                .HasMaxLength(50)
                .HasColumnName("VOIP_PASSWORD1");

            entity.Property(e => e.VoipPassword2)
                .HasMaxLength(50)
                .HasColumnName("VOIP_PASSWORD2");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaInstallOrders)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_INSTALL_ORDER_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaMaOrder>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_MA_ORDER");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.AcceptDate)
                .HasMaxLength(50)
                .HasColumnName("ACCEPT_DATE");

            entity.Property(e => e.AccessMode)
                .HasMaxLength(50)
                .HasColumnName("ACCESS_MODE");

            entity.Property(e => e.Address)
                .HasMaxLength(512)
                .HasColumnName("ADDRESS");

            entity.Property(e => e.AppointmentDate)
                .HasMaxLength(50)
                .HasColumnName("APPOINTMENT_DATE");

            entity.Property(e => e.AppointmentTimeslot)
                .HasMaxLength(50)
                .HasColumnName("APPOINTMENT_TIMESLOT");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .HasColumnName("AREA");

            entity.Property(e => e.BuildingName)
                .HasMaxLength(255)
                .HasColumnName("BUILDING_NAME");

            entity.Property(e => e.CommitDate)
                .HasMaxLength(50)
                .HasColumnName("COMMIT_DATE");

            entity.Property(e => e.ComplaintDescription).HasColumnName("COMPLAINT_DESCRIPTION");

            entity.Property(e => e.ComplaintTitle)
                .HasMaxLength(512)
                .HasColumnName("COMPLAINT_TITLE");

            entity.Property(e => e.ContactMobilePhone1)
                .HasMaxLength(50)
                .HasColumnName("CONTACT_MOBILE_PHONE1");

            entity.Property(e => e.ContactMobilePhone2)
                .HasMaxLength(50)
                .HasColumnName("CONTACT_MOBILE_PHONE2");

            entity.Property(e => e.ContactMobilePhone3)
                .HasMaxLength(50)
                .HasColumnName("CONTACT_MOBILE_PHONE3");

            entity.Property(e => e.ContactPersonName)
                .HasMaxLength(255)
                .HasColumnName("CONTACT_PERSON_NAME");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.CsNote).HasColumnName("CS_NOTE");

            entity.Property(e => e.CustomerComplaintMobile)
                .HasMaxLength(50)
                .HasColumnName("CUSTOMER_COMPLAINT_MOBILE");

            entity.Property(e => e.CustomerComplaintName)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_COMPLAINT_NAME");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("CUSTOMER_NAME");

            entity.Property(e => e.DetailsForResolved).HasColumnName("DETAILS_FOR_RESOLVED");

            entity.Property(e => e.DownlinkRate)
                .HasMaxLength(50)
                .HasColumnName("DOWNLINK_RATE");

            entity.Property(e => e.FibrenetId)
                .HasMaxLength(50)
                .HasColumnName("FIBRENET_ID");

            entity.Property(e => e.InstallationLatitude)
                .HasMaxLength(50)
                .HasColumnName("INSTALLATION_LATITUDE");

            entity.Property(e => e.InstallationLongitude)
                .HasMaxLength(50)
                .HasColumnName("INSTALLATION_LONGITUDE");

            entity.Property(e => e.JobPriority)
                .HasMaxLength(100)
                .HasColumnName("JOB_PRIORITY");

            entity.Property(e => e.JobState)
                .HasMaxLength(50)
                .HasColumnName("JOB_STATE");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.NocNumber)
                .HasMaxLength(50)
                .HasColumnName("NOC_NUMBER");

            entity.Property(e => e.NocRemark).HasColumnName("NOC_REMARK");

            entity.Property(e => e.OntopPack)
                .HasMaxLength(512)
                .HasColumnName("ONTOP_PACK");

            entity.Property(e => e.PlayboxContent)
                .HasMaxLength(512)
                .HasColumnName("PLAYBOX_CONTENT");

            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .HasColumnName("PRODUCT_NAME");

            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .HasColumnName("REGION");

            entity.Property(e => e.Service)
                .HasMaxLength(50)
                .HasColumnName("SERVICE");

            entity.Property(e => e.ServiceLevel)
                .HasMaxLength(50)
                .HasColumnName("SERVICE_LEVEL");

            entity.Property(e => e.ServicePack)
                .HasMaxLength(512)
                .HasColumnName("SERVICE_PACK");

            entity.Property(e => e.SiebelRequestNo)
                .HasMaxLength(50)
                .HasColumnName("SIEBEL_REQUEST_NO");

            entity.Property(e => e.TaskOrderNo)
                .HasMaxLength(50)
                .HasColumnName("TASK_ORDER_NO");

            entity.Property(e => e.TroubleSymptom)
                .HasMaxLength(512)
                .HasColumnName("TROUBLE_SYMPTOM");

            entity.Property(e => e.TroubleTicketNo)
                .HasMaxLength(50)
                .HasColumnName("TROUBLE_TICKET_NO");

            entity.Property(e => e.UplinkRate)
                .HasMaxLength(50)
                .HasColumnName("UPLINK_RATE");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaMaOrders)
                .HasForeignKey(d => d.WoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_MA_ORDER_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaOntop>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_ONTOPS");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Data)
                .HasMaxLength(512)
                .HasColumnName("DATA");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaOntops)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_ONTOPS_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaResource>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_RESOURCE");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.ActivationId)
                .HasMaxLength(50)
                .HasColumnName("ACTIVATION_ID");

            entity.Property(e => e.CpeInstallation)
                .HasMaxLength(50)
                .HasColumnName("CPE_INSTALLATION");

            entity.Property(e => e.CpeModel)
                .HasMaxLength(50)
                .HasColumnName("CPE_MODEL");

            entity.Property(e => e.CpeSn)
                .HasMaxLength(50)
                .HasColumnName("CPE_SN");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Cvlan)
                .HasMaxLength(255)
                .HasColumnName("CVLAN");

            entity.Property(e => e.DeviceModel)
                .HasMaxLength(50)
                .HasColumnName("DEVICE_MODEL");

            entity.Property(e => e.DownlinkRate)
                .HasMaxLength(50)
                .HasColumnName("DOWNLINK_RATE");

            entity.Property(e => e.DropWireDistance)
                .HasMaxLength(50)
                .HasColumnName("DROP_WIRE_DISTANCE");

            entity.Property(e => e.DslamManufacturer)
                .HasMaxLength(50)
                .HasColumnName("DSLAM_MANUFACTURER");

            entity.Property(e => e.DslamPort)
                .HasMaxLength(50)
                .HasColumnName("DSLAM_PORT");

            entity.Property(e => e.EndPointLatitude)
                .HasMaxLength(50)
                .HasColumnName("END_POINT_LATITUDE");

            entity.Property(e => e.EndPointLongitude)
                .HasMaxLength(50)
                .HasColumnName("END_POINT_LONGITUDE");

            entity.Property(e => e.ExistingDropWireId)
                .HasMaxLength(50)
                .HasColumnName("EXISTING_DROP_WIRE_ID");

            entity.Property(e => e.Gemport)
                .HasMaxLength(255)
                .HasColumnName("GEMPORT");

            entity.Property(e => e.IpAddress)
                .HasMaxLength(50)
                .HasColumnName("IP_ADDRESS");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.MdfOutPort)
                .HasMaxLength(255)
                .HasColumnName("MDF_OUT_PORT");

            entity.Property(e => e.NewDropWireId)
                .HasMaxLength(50)
                .HasColumnName("NEW_DROP_WIRE_ID");

            entity.Property(e => e.OdfFiberCore)
                .HasMaxLength(255)
                .HasColumnName("ODF_FIBER_CORE");

            entity.Property(e => e.OdfIn)
                .HasMaxLength(50)
                .HasColumnName("ODF_IN");

            entity.Property(e => e.OdfOut)
                .HasMaxLength(50)
                .HasColumnName("ODF_OUT");

            entity.Property(e => e.OltManufacturer)
                .HasMaxLength(50)
                .HasColumnName("OLT_MANUFACTURER");

            entity.Property(e => e.OltName)
                .HasMaxLength(50)
                .HasColumnName("OLT_NAME");

            entity.Property(e => e.OltPonPort)
                .HasMaxLength(255)
                .HasColumnName("OLT_PON_PORT");

            entity.Property(e => e.Onu)
                .HasMaxLength(50)
                .HasColumnName("ONU");

            entity.Property(e => e.OnuId)
                .HasMaxLength(50)
                .HasColumnName("ONU_ID");

            entity.Property(e => e.OnuModel)
                .HasMaxLength(50)
                .HasColumnName("ONU_MODEL");

            entity.Property(e => e.OnuUplinkPort)
                .HasMaxLength(50)
                .HasColumnName("ONU_UPLINK_PORT");

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("PASSWORD");

            entity.Property(e => e.ReuseFlag)
                .HasMaxLength(255)
                .HasColumnName("REUSE_FLAG");

            entity.Property(e => e.Service)
                .HasMaxLength(50)
                .HasColumnName("SERVICE");

            entity.Property(e => e.Sp1FiberCore)
                .HasMaxLength(255)
                .HasColumnName("SP1_FIBER_CORE");

            entity.Property(e => e.Sp1InPort)
                .HasMaxLength(255)
                .HasColumnName("SP1_IN_PORT");

            entity.Property(e => e.Sp1Latitude)
                .HasMaxLength(50)
                .HasColumnName("SP1_LATITUDE");

            entity.Property(e => e.Sp1Longitude)
                .HasMaxLength(50)
                .HasColumnName("SP1_LONGITUDE");

            entity.Property(e => e.Sp1OutPort)
                .HasMaxLength(255)
                .HasColumnName("SP1_OUT_PORT");

            entity.Property(e => e.Sp1RunningState)
                .HasMaxLength(50)
                .HasColumnName("SP1_RUNNING_STATE");

            entity.Property(e => e.Sp2Distance)
                .HasMaxLength(50)
                .HasColumnName("SP2_DISTANCE");

            entity.Property(e => e.Sp2InPort)
                .HasMaxLength(255)
                .HasColumnName("SP2_IN_PORT");

            entity.Property(e => e.Sp2Latitude)
                .HasMaxLength(50)
                .HasColumnName("SP2_LATITUDE");

            entity.Property(e => e.Sp2Longitude)
                .HasMaxLength(50)
                .HasColumnName("SP2_LONGITUDE");

            entity.Property(e => e.Sp2OutPort)
                .HasMaxLength(255)
                .HasColumnName("SP2_OUT_PORT");

            entity.Property(e => e.Sp2RunningState)
                .HasMaxLength(50)
                .HasColumnName("SP2_RUNNING_STATE");

            entity.Property(e => e.SplitterDistance)
                .HasMaxLength(50)
                .HasColumnName("SPLITTER_DISTANCE");

            entity.Property(e => e.SplitterNamePrimary)
                .HasMaxLength(50)
                .HasColumnName("SPLITTER_NAME_PRIMARY");

            entity.Property(e => e.SplitterPort)
                .HasMaxLength(50)
                .HasColumnName("SPLITTER_PORT");

            entity.Property(e => e.StandardAddressName)
                .HasMaxLength(512)
                .HasColumnName("STANDARD_ADDRESS_NAME");

            entity.Property(e => e.Svlan)
                .HasMaxLength(255)
                .HasColumnName("SVLAN");

            entity.Property(e => e.Tcont)
                .HasMaxLength(255)
                .HasColumnName("TCONT");

            entity.Property(e => e.UplinkRate)
                .HasMaxLength(50)
                .HasColumnName("UPLINK_RATE");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaResources)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_RESOURCE_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaStaff>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_STAFFS");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.StaffCode)
                .HasMaxLength(50)
                .HasColumnName("STAFF_CODE");

            entity.Property(e => e.StaffEmail)
                .HasMaxLength(100)
                .HasColumnName("STAFF_EMAIL");

            entity.Property(e => e.StaffEndDayWorking)
                .HasMaxLength(50)
                .HasColumnName("STAFF_END_DAY_WORKING");

            entity.Property(e => e.StaffFirstDayWorking)
                .HasMaxLength(50)
                .HasColumnName("STAFF_FIRST_DAY_WORKING");

            entity.Property(e => e.StaffLatitude)
                .HasMaxLength(50)
                .HasColumnName("STAFF_LATITUDE");

            entity.Property(e => e.StaffLongitude)
                .HasMaxLength(50)
                .HasColumnName("STAFF_LONGITUDE");

            entity.Property(e => e.StaffName)
                .HasMaxLength(100)
                .HasColumnName("STAFF_NAME");

            entity.Property(e => e.StaffPhone)
                .HasMaxLength(20)
                .HasColumnName("STAFF_PHONE");

            entity.Property(e => e.StaffProfilePictureFilename)
                .HasMaxLength(255)
                .HasColumnName("STAFF_PROFILE_PICTURE_FILENAME");

            entity.Property(e => e.StaffRole)
                .HasMaxLength(100)
                .HasColumnName("STAFF_ROLE");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaStaffs)
                .HasForeignKey(d => d.WoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_STAFFS_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaTeam>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_TEAMS");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CompanyId).HasColumnName("COMPANY_ID");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.LocationCode)
                .HasMaxLength(50)
                .HasColumnName("LOCATION_CODE");

            entity.Property(e => e.ShipTo)
                .HasMaxLength(50)
                .HasColumnName("SHIP_TO");

            entity.Property(e => e.StorageLocation)
                .HasMaxLength(50)
                .HasColumnName("STORAGE_LOCATION");

            entity.Property(e => e.TeamId)
                .HasMaxLength(50)
                .HasColumnName("TEAM_ID");

            entity.Property(e => e.TeamName)
                .HasMaxLength(255)
                .HasColumnName("TEAM_NAME");

            entity.Property(e => e.TeamService)
                .HasMaxLength(1024)
                .HasColumnName("TEAM_SERVICE");

            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .HasColumnName("VENDOR_CODE");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaTeams)
                .HasForeignKey(d => d.WoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_TEAMS_FBB_TBL_WO");
        });

        modelBuilder.Entity<FbbTblWoSoaWfm>(entity =>
        {
            entity.ToTable("FBB_TBL_WO_SOA_WFMS");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Author)
                .HasMaxLength(100)
                .HasColumnName("AUTHOR");

            entity.Property(e => e.Created)
                .HasMaxLength(50)
                .HasColumnName("CREATED");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");

            entity.Property(e => e.Group).HasColumnName("GROUP");

            entity.Property(e => e.LastUpd)
                .HasMaxLength(50)
                .HasColumnName("LAST_UPD");

            entity.Property(e => e.LastUpdDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD_DATE");

            entity.Property(e => e.RemarkDate)
                .HasMaxLength(50)
                .HasColumnName("REMARK_DATE");

            entity.Property(e => e.SubcontractRemarks).HasColumnName("SUBCONTRACT_REMARKS");

            entity.Property(e => e.WoId).HasColumnName("WO_ID");

            entity.HasOne(d => d.Wo)
                .WithMany(p => p.FbbTblWoSoaWfms)
                .HasForeignKey(d => d.WoId)
                .HasConstraintName("FK_FBB_TBL_WO_SOA_WFMS_FBB_TBL_WO");
        });

        modelBuilder.HasSequence("HEADERID_SEQ").HasMin(1);

        modelBuilder.HasSequence("REFID_SEQ").HasMin(1);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
