using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Inspection_Outcome.Models;

public partial class ErpDataContext : DbContext
{
    public ErpDataContext()
    {
    }

    public ErpDataContext(DbContextOptions<ErpDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountPayeeDetail> AccountPayeeDetails { get; set; }

    public virtual DbSet<Buyer> Buyers { get; set; }

    public virtual DbSet<Buyercodedesign> Buyercodedesigns { get; set; }

    public virtual DbSet<ChequeTemplatePosition> ChequeTemplatePositions { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<TblAcceesRight> TblAcceesRights { get; set; }

    public virtual DbSet<TblAreaMst> TblAreaMsts { get; set; }

    public virtual DbSet<TblBuyer> TblBuyers { get; set; }

    public virtual DbSet<TblCarpetDispatch> TblCarpetDispatches { get; set; }

    public virtual DbSet<TblCarpetInspection> TblCarpetInspections { get; set; }

    public virtual DbSet<TblCarvingMst> TblCarvingMsts { get; set; }

    public virtual DbSet<TblCategoryTufterMst> TblCategoryTufterMsts { get; set; }

    public virtual DbSet<TblCheque> TblCheques { get; set; }

    public virtual DbSet<TblChequeBookMaster> TblChequeBookMasters { get; set; }

    public virtual DbSet<TblClient> TblClients { get; set; }

    public virtual DbSet<TblClientCodeMaster> TblClientCodeMasters { get; set; }

    public virtual DbSet<TblClientold> TblClientolds { get; set; }

    public virtual DbSet<TblColor> TblColors { get; set; }

    public virtual DbSet<TblCompanyinfo> TblCompanyinfos { get; set; }

    public virtual DbSet<TblContact> TblContacts { get; set; }

    public virtual DbSet<TblCourierNameMst> TblCourierNameMsts { get; set; }

    public virtual DbSet<TblCurrency> TblCurrencies { get; set; }

    public virtual DbSet<TblCustShipAddress> TblCustShipAddresses { get; set; }

    public virtual DbSet<TblDailyProduction> TblDailyProductions { get; set; }

    public virtual DbSet<TblDesign> TblDesigns { get; set; }

    public virtual DbSet<TblDesignLog> TblDesignLogs { get; set; }

    public virtual DbSet<TblDesignMaster> TblDesignMasters { get; set; }

    public virtual DbSet<TblDesignReqDtl> TblDesignReqDtls { get; set; }

    public virtual DbSet<TblDesignReqDtlOld> TblDesignReqDtlOlds { get; set; }

    public virtual DbSet<TblDesignReqDtlTemp> TblDesignReqDtlTemps { get; set; }

    public virtual DbSet<TblDesignReqMst> TblDesignReqMsts { get; set; }

    public virtual DbSet<TblDesignStudio> TblDesignStudios { get; set; }

    public virtual DbSet<TblDesignStudioCancellation> TblDesignStudioCancellations { get; set; }

    public virtual DbSet<TblDesignStudioLog> TblDesignStudioLogs { get; set; }

    public virtual DbSet<TblDesignStudioOther> TblDesignStudioOthers { get; set; }

    public virtual DbSet<TblDesignStudioSecond> TblDesignStudioSeconds { get; set; }

    public virtual DbSet<TblDesignerMaster> TblDesignerMasters { get; set; }

    public virtual DbSet<TblDesignerOtherTask> TblDesignerOtherTasks { get; set; }

    public virtual DbSet<TblDesignerProc> TblDesignerProcs { get; set; }

    public virtual DbSet<TblDesignerProcLog> TblDesignerProcLogs { get; set; }

    public virtual DbSet<TblDirectSampleProc> TblDirectSampleProcs { get; set; }

    public virtual DbSet<TblEmailQueue> TblEmailQueues { get; set; }

    public virtual DbSet<TblEmployeeMst> TblEmployeeMsts { get; set; }

    public virtual DbSet<TblFibreMst> TblFibreMsts { get; set; }

    public virtual DbSet<TblFinalEntry> TblFinalEntries { get; set; }

    public virtual DbSet<TblFinalReceiveEntry> TblFinalReceiveEntries { get; set; }

    public virtual DbSet<TblHandtuftOrderMst> TblHandtuftOrderMsts { get; set; }

    public virtual DbSet<TblHtProdnBooking> TblHtProdnBookings { get; set; }

    public virtual DbSet<TblHtprodnPlanning> TblHtprodnPlannings { get; set; }

    public virtual DbSet<TblHtproductionRateMst> TblHtproductionRateMsts { get; set; }

    public virtual DbSet<TblIthardwareMst> TblIthardwareMsts { get; set; }

    public virtual DbSet<TblItuserSystemInfo> TblItuserSystemInfos { get; set; }

    public virtual DbSet<TblLead> TblLeads { get; set; }

    public virtual DbSet<TblLocationMaster> TblLocationMasters { get; set; }

    public virtual DbSet<TblLoginDetail> TblLoginDetails { get; set; }

    public virtual DbSet<TblLoomMst> TblLoomMsts { get; set; }

    public virtual DbSet<TblLoomProductionMst> TblLoomProductionMsts { get; set; }

    public virtual DbSet<TblLoomProductionMstLog> TblLoomProductionMstLogs { get; set; }

    public virtual DbSet<TblMachinProdnMst> TblMachinProdnMsts { get; set; }

    public virtual DbSet<TblMachinSpeedRateMst> TblMachinSpeedRateMsts { get; set; }

    public virtual DbSet<TblMaterialLabel> TblMaterialLabels { get; set; }

    public virtual DbSet<TblMicroTuftMst> TblMicroTuftMsts { get; set; }

    public virtual DbSet<TblMiscellaneou> TblMiscellaneous { get; set; }

    public virtual DbSet<TblMmenu> TblMmenus { get; set; }

    public virtual DbSet<TblNetworkInfoMst> TblNetworkInfoMsts { get; set; }

    public virtual DbSet<TblNotice> TblNotices { get; set; }

    public virtual DbSet<TblNotification> TblNotifications { get; set; }

    public virtual DbSet<TblPacking> TblPackings { get; set; }

    public virtual DbSet<TblPermmenu> TblPermmenus { get; set; }

    public virtual DbSet<TblProdnBooking> TblProdnBookings { get; set; }

    public virtual DbSet<TblProdnPlanning> TblProdnPlannings { get; set; }

    public virtual DbSet<TblProdnPlanningMultiPart> TblProdnPlanningMultiParts { get; set; }

    public virtual DbSet<TblProductionAck> TblProductionAcks { get; set; }

    public virtual DbSet<TblProductionAcktemp> TblProductionAcktemps { get; set; }

    public virtual DbSet<TblProductionMst> TblProductionMsts { get; set; }

    public virtual DbSet<TblProductionMstLog> TblProductionMstLogs { get; set; }

    public virtual DbSet<TblProductionRateMst> TblProductionRateMsts { get; set; }

    public virtual DbSet<TblProjectMst> TblProjectMsts { get; set; }

    public virtual DbSet<TblQualityMaster> TblQualityMasters { get; set; }

    public virtual DbSet<TblQuotation> TblQuotations { get; set; }

    public virtual DbSet<TblQuotationRateMaster> TblQuotationRateMasters { get; set; }

    public virtual DbSet<TblReceiveEntry> TblReceiveEntries { get; set; }

    public virtual DbSet<TblRemitterMaster> TblRemitterMasters { get; set; }

    public virtual DbSet<TblRndcmplPer> TblRndcmplPers { get; set; }

    public virtual DbSet<TblRobotuftOrderMst> TblRobotuftOrderMsts { get; set; }

    public virtual DbSet<TblRtgsapplication> TblRtgsapplications { get; set; }

    public virtual DbSet<TblSamProdOrder> TblSamProdOrders { get; set; }

    public virtual DbSet<TblSampleAck> TblSampleAcks { get; set; }

    public virtual DbSet<TblSampleFailMst> TblSampleFailMsts { get; set; }

    public virtual DbSet<TblSampleGodownDtl> TblSampleGodownDtls { get; set; }

    public virtual DbSet<TblSampleLable> TblSampleLables { get; set; }

    public virtual DbSet<TblSampleNoMst> TblSampleNoMsts { get; set; }

    public virtual DbSet<TblSampleNoReEtdMst> TblSampleNoReEtdMsts { get; set; }

    public virtual DbSet<TblSampleRackNo> TblSampleRackNos { get; set; }

    public virtual DbSet<TblSampleStatusMst> TblSampleStatusMsts { get; set; }

    public virtual DbSet<TblSerialMaster> TblSerialMasters { get; set; }

    public virtual DbSet<TblShape> TblShapes { get; set; }

    public virtual DbSet<TblShareGroup> TblShareGroups { get; set; }

    public virtual DbSet<TblSmenu> TblSmenus { get; set; }

    public virtual DbSet<TblSubClientMaster> TblSubClientMasters { get; set; }

    public virtual DbSet<TblSubClientMst> TblSubClientMsts { get; set; }

    public virtual DbSet<TblSubQuality> TblSubQualities { get; set; }

    public virtual DbSet<TblTicket> TblTickets { get; set; }

    public virtual DbSet<TblTraceBooking> TblTraceBookings { get; set; }

    public virtual DbSet<TblTraceDispatched> TblTraceDispatcheds { get; set; }

    public virtual DbSet<TblTraceMachinMst> TblTraceMachinMsts { get; set; }

    public virtual DbSet<TblTraceMachineSpeedMst> TblTraceMachineSpeedMsts { get; set; }

    public virtual DbSet<TblTracePlanning> TblTracePlannings { get; set; }

    public virtual DbSet<TblTraceProce> TblTraceProces { get; set; }

    public virtual DbSet<TblTracerMst> TblTracerMsts { get; set; }

    public virtual DbSet<TblTufterMst> TblTufterMsts { get; set; }

    public virtual DbSet<TblTwistReceiveEntry> TblTwistReceiveEntries { get; set; }

    public virtual DbSet<TblTwistingEntry> TblTwistingEntries { get; set; }

    public virtual DbSet<TblUnitMaster> TblUnitMasters { get; set; }

    public virtual DbSet<TblUserAccee> TblUserAccees { get; set; }

    public virtual DbSet<TblUserDetail> TblUserDetails { get; set; }

    public virtual DbSet<TblUserMaster> TblUserMasters { get; set; }

    public virtual DbSet<TblUserlog> TblUserlogs { get; set; }

    public virtual DbSet<TblVendarMonEntry> TblVendarMonEntries { get; set; }

    public virtual DbSet<TblVendarReceiveEntry> TblVendarReceiveEntries { get; set; }

    public virtual DbSet<TblWinderMonEntry> TblWinderMonEntries { get; set; }

    public virtual DbSet<Tblbuyerdesigncolor> Tblbuyerdesigncolors { get; set; }

    public virtual DbSet<TblbuyerdesigncolorOld> TblbuyerdesigncolorOlds { get; set; }

    public virtual DbSet<Tblchat> Tblchats { get; set; }

    public virtual DbSet<TblcountPcsMst> TblcountPcsMsts { get; set; }

    public virtual DbSet<TblorderqntyProcess> TblorderqntyProcesses { get; set; }

    public virtual DbSet<TblwindingRateLog> TblwindingRateLogs { get; set; }

    public virtual DbSet<TblwindingRateMst> TblwindingRateMsts { get; set; }

    public virtual DbSet<Vendarmaster> Vendarmasters { get; set; }

    public virtual DbSet<Winder> Winders { get; set; }

    public virtual DbSet<WinderShiftMaster> WinderShiftMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=AKASH\\SQLEXPRESS;Database=ErpData;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountPayeeDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AccountP__3214EC070EA1DE80");

            entity.ToTable("AccountPayeeDetail");

            entity.Property(e => e.AccountCategory).HasMaxLength(30);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.BranchName).HasMaxLength(150);
            entity.Property(e => e.Centre).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(20)
                .HasColumnName("IFSCCode");
            entity.Property(e => e.PayeeCode).HasMaxLength(30);
            entity.Property(e => e.PayeeName).HasMaxLength(200);
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Buyer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("buyer");

            entity.Property(e => e.Address1)
                .HasMaxLength(300)
                .HasColumnName("address1");
            entity.Property(e => e.Auto)
                .ValueGeneratedOnAdd()
                .HasColumnName("auto");
            entity.Property(e => e.Bankadd1)
                .HasMaxLength(300)
                .HasColumnName("bankadd1");
            entity.Property(e => e.Bankname)
                .HasMaxLength(35)
                .HasColumnName("bankname");
            entity.Property(e => e.Bno)
                .HasMaxLength(20)
                .HasColumnName("bno");
            entity.Property(e => e.Buyercode)
                .HasMaxLength(4)
                .HasColumnName("buyercode");
            entity.Property(e => e.Companycode)
                .HasMaxLength(5)
                .HasColumnName("companycode");
            entity.Property(e => e.Consigneeadd)
                .HasMaxLength(300)
                .HasColumnName("consigneeadd");
            entity.Property(e => e.Consigneename)
                .HasMaxLength(50)
                .HasColumnName("consigneename");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Datetime)
                .HasColumnType("smalldatetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Destination)
                .HasMaxLength(20)
                .HasColumnName("destination");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .HasColumnName("fax");
            entity.Property(e => e.Finaldestination)
                .HasMaxLength(20)
                .HasColumnName("finaldestination");
            entity.Property(e => e.Itemno).HasColumnName("itemno");
            entity.Property(e => e.Measureunit)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("measureunit");
            entity.Property(e => e.Name)
                .HasMaxLength(35)
                .HasColumnName("name");
            entity.Property(e => e.Notifyadd1)
                .HasMaxLength(300)
                .HasColumnName("notifyadd1");
            entity.Property(e => e.Notifyname)
                .HasMaxLength(35)
                .HasColumnName("notifyname");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .HasColumnName("phone");
            entity.Property(e => e.Portdessea)
                .HasMaxLength(20)
                .HasColumnName("portdessea");
            entity.Property(e => e.Portdischarge)
                .HasMaxLength(20)
                .HasColumnName("portdischarge");
            entity.Property(e => e.Portload)
                .HasMaxLength(20)
                .HasColumnName("portload");
            entity.Property(e => e.Portloadsea)
                .HasMaxLength(20)
                .HasColumnName("portloadsea");
            entity.Property(e => e.Ratetype)
                .HasMaxLength(6)
                .HasColumnName("ratetype");
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Buyercodedesign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("buyercodedesign");

            entity.Property(e => e.Binding).HasColumnName("binding");
            entity.Property(e => e.Buyercode)
                .HasMaxLength(10)
                .HasColumnName("buyercode");
            entity.Property(e => e.Clipping).HasColumnName("clipping");
            entity.Property(e => e.Cloth).HasColumnName("cloth");
            entity.Property(e => e.Clothnewar).HasColumnName("clothnewar");
            entity.Property(e => e.Colour)
                .HasMaxLength(40)
                .HasColumnName("colour");
            entity.Property(e => e.Designno)
                .HasMaxLength(40)
                .HasColumnName("designno");
            entity.Property(e => e.Finishing).HasColumnName("finishing");
            entity.Property(e => e.Latexing).HasColumnName("latexing");
            entity.Property(e => e.Newar).HasColumnName("newar");
            entity.Property(e => e.Quality)
                .HasMaxLength(35)
                .HasColumnName("quality");
            entity.Property(e => e.Streching).HasColumnName("streching");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .HasColumnName("type");
            entity.Property(e => e.Viscose).HasColumnName("viscose");
            entity.Property(e => e.Washing).HasColumnName("washing");
            entity.Property(e => e.Wool).HasColumnName("wool");
        });

        modelBuilder.Entity<ChequeTemplatePosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChequeTe__3214EC07EDFAE4C9");

            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.FieldName).HasMaxLength(50);
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Events__3214EC07F99A44B9");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<TblAcceesRight>(entity =>
        {
            entity.ToTable("tblAcceesRight");

            entity.Property(e => e.AccessRightName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblAreaMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblArea___3214EC0712B79EED");

            entity.ToTable("tblArea_mst");

            entity.Property(e => e.Area).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AreaName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AreaNameIfOth)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("AreaNameIf_Oth");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Construction)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustomAreaUnit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CustomArea_Unit");
            entity.Property(e => e.Deliverydt).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountPerArea).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountedAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InstallationType)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LengthSubUnit).HasColumnName("Length_SubUnit");
            entity.Property(e => e.LengthUnit).HasColumnName("Length_Unit");
            entity.Property(e => e.Material)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MaterialIfOth)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MaterialIf_Oth");
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.OtherDetails).IsUnicode(false);
            entity.Property(e => e.ProductImage).IsUnicode(false);
            entity.Property(e => e.ProductName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ProjectName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Quality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePerSqFeet)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RatePer_SqFeet");
            entity.Property(e => e.RatePerSqMeter)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RatePer_SqMeter");
            entity.Property(e => e.SubUnit)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Sub_Unit");
            entity.Property(e => e.Texture)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WidthSubUnit).HasColumnName("Width_SubUnit");
            entity.Property(e => e.WidthUnit).HasColumnName("Width_Unit");
        });

        modelBuilder.Entity<TblBuyer>(entity =>
        {
            entity.ToTable("tblBuyer");

            entity.Property(e => e.Address1)
                .HasMaxLength(300)
                .HasColumnName("address1");
            entity.Property(e => e.Bankadd1)
                .HasMaxLength(300)
                .HasColumnName("bankadd1");
            entity.Property(e => e.Bankname)
                .HasMaxLength(35)
                .HasColumnName("bankname");
            entity.Property(e => e.Bno)
                .HasMaxLength(20)
                .HasColumnName("bno");
            entity.Property(e => e.Buyercode)
                .HasMaxLength(4)
                .HasColumnName("buyercode");
            entity.Property(e => e.Companycode)
                .HasMaxLength(5)
                .HasColumnName("companycode");
            entity.Property(e => e.Consigneeadd)
                .HasMaxLength(300)
                .HasColumnName("consigneeadd");
            entity.Property(e => e.Consigneename)
                .HasMaxLength(50)
                .HasColumnName("consigneename");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("currency");
            entity.Property(e => e.Datetime)
                .HasColumnType("smalldatetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Destination)
                .HasMaxLength(20)
                .HasColumnName("destination");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .HasColumnName("fax");
            entity.Property(e => e.Finaldestination)
                .HasMaxLength(20)
                .HasColumnName("finaldestination");
            entity.Property(e => e.Itemno).HasColumnName("itemno");
            entity.Property(e => e.Measureunit)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("measureunit");
            entity.Property(e => e.Name)
                .HasMaxLength(35)
                .HasColumnName("name");
            entity.Property(e => e.Notifyadd1)
                .HasMaxLength(300)
                .HasColumnName("notifyadd1");
            entity.Property(e => e.Notifyname)
                .HasMaxLength(35)
                .HasColumnName("notifyname");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .HasColumnName("phone");
            entity.Property(e => e.Portdessea)
                .HasMaxLength(20)
                .HasColumnName("portdessea");
            entity.Property(e => e.Portdischarge)
                .HasMaxLength(20)
                .HasColumnName("portdischarge");
            entity.Property(e => e.Portload)
                .HasMaxLength(20)
                .HasColumnName("portload");
            entity.Property(e => e.Portloadsea)
                .HasMaxLength(20)
                .HasColumnName("portloadsea");
            entity.Property(e => e.Ratetype)
                .HasMaxLength(6)
                .HasColumnName("ratetype");
            entity.Property(e => e.ShortCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sku).HasColumnName("sku");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TblCarpetDispatch>(entity =>
        {
            entity.ToTable("TblCarpetDispatch");

            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.ColorName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DesignName).HasMaxLength(200);
            entity.Property(e => e.DispatchDate).HasColumnType("datetime");
            entity.Property(e => e.LnthFt).HasColumnName("Lnth_ft");
            entity.Property(e => e.LnthInch).HasColumnName("Lnth_inch");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProjectName).HasMaxLength(100);
            entity.Property(e => e.Quality).HasMaxLength(50);
            entity.Property(e => e.RejectDate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime");
            entity.Property(e => e.RejectRemark)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ShipMode).HasMaxLength(15);
            entity.Property(e => e.SrNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Uom).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.WdthFt).HasColumnName("Wdth_ft");
            entity.Property(e => e.WdthInch).HasColumnName("Wdth_inch");
        });

        modelBuilder.Entity<TblCarpetInspection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblCarpe__3214EC077894E3DF");

            entity.ToTable("TblCarpetInspection");

            entity.Property(e => e.ColorName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DesignName).HasMaxLength(200);
            entity.Property(e => e.DispatchDate).HasColumnType("datetime");
            entity.Property(e => e.LnthFt).HasColumnName("Lnth_ft");
            entity.Property(e => e.LnthInch).HasColumnName("Lnth_inch");
            entity.Property(e => e.PassDt).HasColumnType("datetime");
            entity.Property(e => e.ProjectName).HasMaxLength(200);
            entity.Property(e => e.Quality).HasMaxLength(50);
            entity.Property(e => e.RejectDt).HasColumnType("datetime");
            entity.Property(e => e.RejectReason).HasMaxLength(500);
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.SrNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Uom).HasMaxLength(10);
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.WdthFt).HasColumnName("Wdth_ft");
            entity.Property(e => e.WdthInch).HasColumnName("Wdth_inch");
        });

        modelBuilder.Entity<TblCarvingMst>(entity =>
        {
            entity.ToTable("TblCarving_mst");

            entity.Property(e => e.Carving).HasMaxLength(150);
            entity.Property(e => e.Category).HasMaxLength(10);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quality).HasMaxLength(15);
            entity.Property(e => e.Quantity).HasMaxLength(20);
            entity.Property(e => e.Unit).HasMaxLength(10);
        });

        modelBuilder.Entity<TblCategoryTufterMst>(entity =>
        {
            entity.HasKey(e => e.CatTufterid).HasName("PK__tblCateg__FBD53203E1833487");

            entity.ToTable("tblCategoryTufter_mst");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblCheque>(entity =>
        {
            entity.HasKey(e => e.ChequeId).HasName("PK__TblChequ__B816D9F07F101C93");

            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.ChequeNo).HasMaxLength(50);
            entity.Property(e => e.ChequeType).HasMaxLength(50);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.PayeeCode).HasMaxLength(30);
            entity.Property(e => e.PayeeName).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<TblChequeBookMaster>(entity =>
        {
            entity.HasKey(e => e.ChequeBookId).HasName("PK__TblChequ__07EEC1BF6D73DD77");

            entity.ToTable("TblChequeBookMaster");

            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.ChequeFromNo).HasMaxLength(50);
            entity.Property(e => e.ChequeToNo).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Active");
        });

        modelBuilder.Entity<TblClient>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_TblClient_1")
                .HasFillFactor(90);

            entity.ToTable("TblClient");

            entity.Property(e => e.BillingCity).HasMaxLength(255);
            entity.Property(e => e.BillingCountry).HasMaxLength(255);
            entity.Property(e => e.BillingState).HasMaxLength(255);
            entity.Property(e => e.BillingStreet).HasMaxLength(255);
            entity.Property(e => e.Brand).HasMaxLength(255);
            entity.Property(e => e.BusinessGstnno)
                .HasMaxLength(255)
                .HasColumnName("BusinessGSTNNo");
            entity.Property(e => e.ClientCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClientName).HasMaxLength(255);
            entity.Property(e => e.ClientRecordsType).HasMaxLength(255);
            entity.Property(e => e.ClientSource).HasMaxLength(255);
            entity.Property(e => e.ClientSourceOth)
                .HasMaxLength(255)
                .HasColumnName("ClientSource_oth");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Industry).HasMaxLength(255);
            entity.Property(e => e.OwnerShip).HasMaxLength(255);
            entity.Property(e => e.ParentClient).HasMaxLength(255);
            entity.Property(e => e.PriorityStatus).HasMaxLength(255);
            entity.Property(e => e.Rating).HasMaxLength(255);
            entity.Property(e => e.ShippingCity).HasMaxLength(255);
            entity.Property(e => e.ShippingCountry).HasMaxLength(255);
            entity.Property(e => e.ShippingState).HasMaxLength(255);
            entity.Property(e => e.ShippingStreet).HasMaxLength(255);
            entity.Property(e => e.ShortName).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Website).HasMaxLength(255);
        });

        modelBuilder.Entity<TblClientCodeMaster>(entity =>
        {
            entity.ToTable("TblClientCodeMaster");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblClientold>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_TblClient")
                .HasFillFactor(90);

            entity.ToTable("TblClientold");

            entity.Property(e => e.BillingCity).HasMaxLength(255);
            entity.Property(e => e.BillingCountry).HasMaxLength(255);
            entity.Property(e => e.BillingState).HasMaxLength(255);
            entity.Property(e => e.BillingStreet).HasMaxLength(255);
            entity.Property(e => e.Brand).HasMaxLength(255);
            entity.Property(e => e.BusinessGstnno)
                .HasMaxLength(255)
                .HasColumnName("BusinessGSTNNo");
            entity.Property(e => e.ClientCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClientName).HasMaxLength(255);
            entity.Property(e => e.ClientRecordsType).HasMaxLength(255);
            entity.Property(e => e.ClientSource).HasMaxLength(255);
            entity.Property(e => e.ClientSourceOth)
                .HasMaxLength(255)
                .HasColumnName("ClientSource_oth");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Industry).HasMaxLength(255);
            entity.Property(e => e.OwnerShip).HasMaxLength(255);
            entity.Property(e => e.ParentClient).HasMaxLength(255);
            entity.Property(e => e.PriorityStatus).HasMaxLength(255);
            entity.Property(e => e.Rating).HasMaxLength(255);
            entity.Property(e => e.ShippingCity).HasMaxLength(255);
            entity.Property(e => e.ShippingCountry).HasMaxLength(255);
            entity.Property(e => e.ShippingState).HasMaxLength(255);
            entity.Property(e => e.ShippingStreet).HasMaxLength(255);
            entity.Property(e => e.ShortName).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Website).HasMaxLength(255);
        });

        modelBuilder.Entity<TblColor>(entity =>
        {
            entity.ToTable("tblColor");

            entity.Property(e => e.Colour).HasMaxLength(40);
            entity.Property(e => e.Companycode)
                .HasMaxLength(5)
                .HasColumnName("companycode");
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Excolour).HasMaxLength(40);
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TblCompanyinfo>(entity =>
        {
            entity.ToTable("tblCompanyinfo");

            entity.Property(e => e.Accountno)
                .HasMaxLength(25)
                .HasColumnName("accountno");
            entity.Property(e => e.Adcode)
                .HasMaxLength(25)
                .HasColumnName("adcode");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .HasColumnName("address");
            entity.Property(e => e.Address1)
                .HasMaxLength(200)
                .HasColumnName("address1");
            entity.Property(e => e.Bankbranch)
                .HasMaxLength(25)
                .HasColumnName("bankbranch");
            entity.Property(e => e.Bankname)
                .HasMaxLength(25)
                .HasColumnName("bankname");
            entity.Property(e => e.BrandName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Carpetno)
                .HasMaxLength(8)
                .HasColumnName("carpetno");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.City1)
                .HasMaxLength(100)
                .HasColumnName("city1");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Companycode)
                .HasMaxLength(5)
                .HasColumnName("companycode");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("creationdate");
            entity.Property(e => e.Cst)
                .HasMaxLength(15)
                .HasColumnName("cst");
            entity.Property(e => e.Cstdate)
                .HasMaxLength(10)
                .HasColumnName("cstdate");
            entity.Property(e => e.Datefrom)
                .HasColumnType("datetime")
                .HasColumnName("datefrom");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Dateto)
                .HasColumnType("datetime")
                .HasColumnName("dateto");
            entity.Property(e => e.Dbkaccountno)
                .HasMaxLength(25)
                .HasColumnName("dbkaccountno");
            entity.Property(e => e.Dbkbank)
                .HasMaxLength(25)
                .HasColumnName("dbkbank");
            entity.Property(e => e.Email1)
                .HasMaxLength(50)
                .HasColumnName("email1");
            entity.Property(e => e.Email2)
                .HasMaxLength(50)
                .HasColumnName("email2");
            entity.Property(e => e.Fax)
                .HasMaxLength(25)
                .HasColumnName("fax");
            entity.Property(e => e.Gstin)
                .HasMaxLength(20)
                .HasColumnName("gstin");
            entity.Property(e => e.Ieccode)
                .HasMaxLength(25)
                .HasColumnName("ieccode");
            entity.Property(e => e.Incometaxno)
                .HasMaxLength(25)
                .HasColumnName("incometaxno");
            entity.Property(e => e.Mark)
                .HasMaxLength(15)
                .HasColumnName("MARK");
            entity.Property(e => e.Mobileno).HasColumnName("mobileno");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.Panno)
                .HasMaxLength(25)
                .HasColumnName("panno");
            entity.Property(e => e.Pcno)
                .HasMaxLength(25)
                .HasColumnName("pcno");
            entity.Property(e => e.Phone)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Pin).HasMaxLength(6);
            entity.Property(e => e.Rbicode)
                .HasMaxLength(25)
                .HasColumnName("rbicode");
            entity.Property(e => e.Rcmc)
                .HasMaxLength(30)
                .HasColumnName("RCMC");
            entity.Property(e => e.Rcmcvailidity)
                .HasMaxLength(30)
                .HasColumnName("rcmcvailidity");
            entity.Property(e => e.Representative)
                .HasMaxLength(50)
                .HasColumnName("representative");
            entity.Property(e => e.Rollno).HasColumnName("rollno");
            entity.Property(e => e.Signature)
                .HasMaxLength(20)
                .HasColumnName("signature");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
            entity.Property(e => e.Superpass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("superpass");
            entity.Property(e => e.Superpass1)
                .HasMaxLength(30)
                .HasColumnName("superpass1");
            entity.Property(e => e.Tin)
                .HasMaxLength(25)
                .HasColumnName("tin");
            entity.Property(e => e.Tindate)
                .HasMaxLength(10)
                .HasColumnName("tindate");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("username");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .HasColumnName("website");
        });

        modelBuilder.Entity<TblContact>(entity =>
        {
            entity.ToTable("TblContact");

            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactTypeOth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ContactType_Oth");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntrdyDt).HasColumnType("datetime");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MailingCity)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MailingCountry)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MailingState)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MailingStreets)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Salutation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Suffix)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Updatedt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblCourierNameMst>(entity =>
        {
            entity.ToTable("tblCourierName_mst");

            entity.Property(e => e.CourierName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EntryBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Website).IsUnicode(false);
        });

        modelBuilder.Entity<TblCurrency>(entity =>
        {
            entity.ToTable("TblCurrency");

            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCustShipAddress>(entity =>
        {
            entity.ToTable("TblCustShipAddress");

            entity.Property(e => e.BillTo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BillingCity).HasMaxLength(150);
            entity.Property(e => e.BillingCountry).HasMaxLength(150);
            entity.Property(e => e.BillingState).HasMaxLength(150);
            entity.Property(e => e.BillingStreet).HasMaxLength(150);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ShipTo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ShippingCity).HasMaxLength(150);
            entity.Property(e => e.ShippingCountry).HasMaxLength(150);
            entity.Property(e => e.ShippingState).HasMaxLength(150);
            entity.Property(e => e.ShippingStreet).HasMaxLength(250);
            entity.Property(e => e.Srno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRNo");
            entity.Property(e => e.TelNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDailyProduction>(entity =>
        {
            entity.HasKey(e => e.Dailyprodnid).HasName("PK__tblDaily__598FCB0E19880680");

            entity.ToTable("tblDailyProduction");

            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.DalyProdnDate).HasColumnType("datetime");
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.ProdnCompletedSqm).HasColumnName("ProdnCompleted_sqm");
            entity.Property(e => e.ProdnRemainingSqm).HasColumnName("ProdnRemaining_sqm");
            entity.Property(e => e.PurchaseNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TufterName1)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TufterName2)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TufterName3)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TufterName4)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TufterName5)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDesign>(entity =>
        {
            entity.HasKey(e => e.DesignId);

            entity.ToTable("tblDesign");

            entity.Property(e => e.Areawall)
                .HasMaxLength(50)
                .HasColumnName("areawall");
            entity.Property(e => e.Bindingyn)
                .HasMaxLength(25)
                .HasColumnName("bindingyn");
            entity.Property(e => e.Collection)
                .HasMaxLength(20)
                .HasColumnName("collection");
            entity.Property(e => e.Colour).HasMaxLength(40);
            entity.Property(e => e.Composition)
                .HasMaxLength(60)
                .HasColumnName("composition");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Design).HasMaxLength(40);
            entity.Property(e => e.DesignNo).HasMaxLength(40);
            entity.Property(e => e.Dyeing)
                .HasMaxLength(30)
                .HasColumnName("dyeing");
            entity.Property(e => e.Finish)
                .HasMaxLength(80)
                .HasColumnName("finish");
            entity.Property(e => e.Fringes)
                .HasMaxLength(25)
                .HasColumnName("fringes");
            entity.Property(e => e.Heightfinish)
                .IsUnicode(false)
                .HasColumnName("heightfinish");
            entity.Property(e => e.Heightprod)
                .IsUnicode(false)
                .HasColumnName("heightprod");
            entity.Property(e => e.Hsn)
                .HasMaxLength(20)
                .HasColumnName("hsn");
            entity.Property(e => e.Iiird)
                .HasMaxLength(25)
                .HasColumnName("iiird");
            entity.Property(e => e.Jalli)
                .HasMaxLength(25)
                .HasColumnName("jalli");
            entity.Property(e => e.Latex)
                .HasMaxLength(50)
                .HasColumnName("latex");
            entity.Property(e => e.Loss).HasDefaultValue(0f);
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.Newar)
                .HasMaxLength(25)
                .HasColumnName("newar");
            entity.Property(e => e.Othermaterial).HasMaxLength(80);
            entity.Property(e => e.Path)
                .HasMaxLength(25)
                .HasColumnName("path");
            entity.Property(e => e.Ply)
                .HasMaxLength(250)
                .HasColumnName("ply");
            entity.Property(e => e.Plytwist)
                .HasMaxLength(250)
                .HasColumnName("plytwist");
            entity.Property(e => e.Quality)
                .HasMaxLength(30)
                .HasColumnName("quality");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Washing)
                .HasMaxLength(25)
                .HasColumnName("washing");
            entity.Property(e => e.Woolquality)
                .HasMaxLength(80)
                .HasColumnName("woolquality");
            entity.Property(e => e.Woolquality1).HasMaxLength(80);
            entity.Property(e => e.Woolquality2).HasMaxLength(80);
            entity.Property(e => e.Woolquality3).HasMaxLength(80);
        });

        modelBuilder.Entity<TblDesignLog>(entity =>
        {
            entity.HasKey(e => e.DesignId);

            entity.ToTable("tblDesignLog");

            entity.Property(e => e.Areawall)
                .HasMaxLength(50)
                .HasColumnName("areawall");
            entity.Property(e => e.Bindingyn)
                .HasMaxLength(25)
                .HasColumnName("bindingyn");
            entity.Property(e => e.Collection)
                .HasMaxLength(20)
                .HasColumnName("collection");
            entity.Property(e => e.Colour).HasMaxLength(40);
            entity.Property(e => e.Composition)
                .HasMaxLength(60)
                .HasColumnName("composition");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Design).HasMaxLength(40);
            entity.Property(e => e.DesignNo).HasMaxLength(40);
            entity.Property(e => e.Dyeing)
                .HasMaxLength(30)
                .HasColumnName("dyeing");
            entity.Property(e => e.Finish)
                .HasMaxLength(80)
                .HasColumnName("finish");
            entity.Property(e => e.Fringes)
                .HasMaxLength(25)
                .HasColumnName("fringes");
            entity.Property(e => e.Heightfinish)
                .IsUnicode(false)
                .HasColumnName("heightfinish");
            entity.Property(e => e.Heightprod)
                .IsUnicode(false)
                .HasColumnName("heightprod");
            entity.Property(e => e.Hsn)
                .HasMaxLength(20)
                .HasColumnName("hsn");
            entity.Property(e => e.Iiird)
                .HasMaxLength(25)
                .HasColumnName("iiird");
            entity.Property(e => e.Jalli)
                .HasMaxLength(25)
                .HasColumnName("jalli");
            entity.Property(e => e.Latex)
                .HasMaxLength(50)
                .HasColumnName("latex");
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.Newar)
                .HasMaxLength(25)
                .HasColumnName("newar");
            entity.Property(e => e.Othermaterial).HasMaxLength(80);
            entity.Property(e => e.Path)
                .HasMaxLength(25)
                .HasColumnName("path");
            entity.Property(e => e.Ply)
                .HasMaxLength(250)
                .HasColumnName("ply");
            entity.Property(e => e.Plytwist)
                .HasMaxLength(250)
                .HasColumnName("plytwist");
            entity.Property(e => e.Quality)
                .HasMaxLength(30)
                .HasColumnName("quality");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .HasColumnName("reference");
            entity.Property(e => e.Washing)
                .HasMaxLength(25)
                .HasColumnName("washing");
            entity.Property(e => e.Woolquality)
                .HasMaxLength(80)
                .HasColumnName("woolquality");
            entity.Property(e => e.Woolquality1).HasMaxLength(80);
            entity.Property(e => e.Woolquality2).HasMaxLength(80);
            entity.Property(e => e.Woolquality3).HasMaxLength(80);
        });

        modelBuilder.Entity<TblDesignMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDesignMaster");

            entity.Property(e => e.Areawall).HasMaxLength(50);
            entity.Property(e => e.Auto)
                .ValueGeneratedOnAdd()
                .HasColumnName("auto");
            entity.Property(e => e.Bindingyn).HasMaxLength(25);
            entity.Property(e => e.Collection).HasMaxLength(20);
            entity.Property(e => e.Colour).HasMaxLength(40);
            entity.Property(e => e.Companycode).HasMaxLength(5);
            entity.Property(e => e.Composition).HasMaxLength(60);
            entity.Property(e => e.Design).HasMaxLength(40);
            entity.Property(e => e.DesignNo).HasMaxLength(40);
            entity.Property(e => e.Dyeing).HasMaxLength(30);
            entity.Property(e => e.Finish).HasMaxLength(80);
            entity.Property(e => e.Fringes).HasMaxLength(25);
            entity.Property(e => e.Heightfinish).IsUnicode(false);
            entity.Property(e => e.Heightprod).IsUnicode(false);
            entity.Property(e => e.Hsn).HasMaxLength(20);
            entity.Property(e => e.Jalli).HasMaxLength(25);
            entity.Property(e => e.Latex).HasMaxLength(50);
            entity.Property(e => e.MapRate).HasColumnName("Map Rate");
            entity.Property(e => e.Newar).HasMaxLength(25);
            entity.Property(e => e.Newartype).HasMaxLength(30);
            entity.Property(e => e.Othermaterial).HasMaxLength(80);
            entity.Property(e => e.Path)
                .HasMaxLength(25)
                .HasColumnName("path");
            entity.Property(e => e.Ply).HasMaxLength(250);
            entity.Property(e => e.Plytwist).HasMaxLength(250);
            entity.Property(e => e.Quality).HasMaxLength(30);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.Safaic).HasColumnName("safaic");
            entity.Property(e => e.Third).HasMaxLength(25);
            entity.Property(e => e.TraceRate).HasColumnName("Trace Rate");
            entity.Property(e => e.Username).HasMaxLength(20);
            entity.Property(e => e.Washing).HasMaxLength(25);
            entity.Property(e => e.Woolquality)
                .HasMaxLength(80)
                .HasColumnName("woolquality");
            entity.Property(e => e.Woolquality1).HasMaxLength(80);
            entity.Property(e => e.Woolquality2).HasMaxLength(80);
            entity.Property(e => e.Woolquality3).HasMaxLength(80);
        });

        modelBuilder.Entity<TblDesignReqDtl>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblDesignReqDtl");

            entity.Property(e => e.Allocateddt).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ArtworkNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AttachmentFile)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AwComments)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CancelBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancleRemark).IsUnicode(false);
            entity.Property(e => e.Color)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ConvertToPd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ConvertToPD");
            entity.Property(e => e.CstmArea).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustApproveddt).HasColumnType("datetime");
            entity.Property(e => e.CustInstruction)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CustPoNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustSubmitdt).HasColumnType("datetime");
            entity.Property(e => e.DesignName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Entryby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoldBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoldDt).HasColumnType("datetime");
            entity.Property(e => e.HoldRealesedt).HasColumnType("datetime");
            entity.Property(e => e.HoldRemark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvArea).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JobWorkType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LnthFt)
                .HasDefaultValue(0)
                .HasColumnName("Lnth_ft");
            entity.Property(e => e.LnthInch).HasColumnName("Lnth_inch");
            entity.Property(e => e.Material)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PreHoldStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Qlty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Receiveddt).HasColumnType("datetime");
            entity.Property(e => e.RefArtworkNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReturndtToHod).HasColumnType("datetime");
            entity.Property(e => e.ReturndtbyHod).HasColumnType("datetime");
            entity.Property(e => e.Revisedt).HasColumnType("datetime");
            entity.Property(e => e.Reviseemaildt).HasColumnType("datetime");
            entity.Property(e => e.Shape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShapeArea).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.SubQlty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Texture)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalArea).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UrgentAppby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UrgentAppdt).HasColumnType("datetime");
            entity.Property(e => e.WdthFt)
                .HasDefaultValue(0)
                .HasColumnName("Wdth_ft");
            entity.Property(e => e.WdthInch).HasColumnName("Wdth_inch");
        });

        modelBuilder.Entity<TblDesignReqDtlOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDesignReqDtlOLD");

            entity.Property(e => e.Allocateddt).HasColumnType("datetime");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ArtworkNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AwComments)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancleRemark).IsUnicode(false);
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CstmArea).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustApproveddt).HasColumnType("datetime");
            entity.Property(e => e.CustInstruction)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CustPoNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustSubmitdt).HasColumnType("datetime");
            entity.Property(e => e.DesignName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Entryby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoldDt).HasColumnType("datetime");
            entity.Property(e => e.HoldRemark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LnthFt).HasColumnName("Lnth_ft");
            entity.Property(e => e.LnthInch).HasColumnName("Lnth_inch");
            entity.Property(e => e.Qlty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Receiveddt).HasColumnType("datetime");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReturndtToHod).HasColumnType("datetime");
            entity.Property(e => e.ReturndtbyHod).HasColumnType("datetime");
            entity.Property(e => e.Revisedt).HasColumnType("datetime");
            entity.Property(e => e.Shape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.SubQlty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UrgentAppby)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UrgentAppdt).HasColumnType("datetime");
            entity.Property(e => e.WdthFt).HasColumnName("Wdth_ft");
            entity.Property(e => e.WdthInch).HasColumnName("Wdth_inch");
        });

        modelBuilder.Entity<TblDesignReqDtlTemp>(entity =>
        {
            entity.ToTable("tblDesignReqDtlTemp");

            entity.Property(e => e.Allocateddt).HasColumnType("datetime");
            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ArtworkNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AwComments)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CstmArea).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustApproveddt).HasColumnType("datetime");
            entity.Property(e => e.CustInstruction)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CustPoNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustSubmitdt).HasColumnType("datetime");
            entity.Property(e => e.DesignName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Entryby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoldDt).HasColumnType("datetime");
            entity.Property(e => e.HoldRemark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvArea).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LastStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LnthFt).HasColumnName("Lnth_ft");
            entity.Property(e => e.LnthInch).HasColumnName("Lnth_inch");
            entity.Property(e => e.Material)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProjectName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Qlty)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Receiveddt).HasColumnType("datetime");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReturndtbyHod).HasColumnType("datetime");
            entity.Property(e => e.Shape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.SubQlty)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Texture)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WdthFt).HasColumnName("Wdth_ft");
            entity.Property(e => e.WdthInch).HasColumnName("Wdth_inch");
        });

        modelBuilder.Entity<TblDesignReqMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblDesignReqMst");

            entity.Property(e => e.AttachmentFile)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CheckAddress).HasDefaultValue(false);
            entity.Property(e => e.Consignee)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Currency)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CustPodt).HasColumnName("CustPODt");
            entity.Property(e => e.CustPono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CustPONo");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DesignType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Design_type");
            entity.Property(e => e.Designer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entry_by");
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("Entry_dt");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quality)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StdType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Update_by");
            entity.Property(e => e.UpdateDt)
                .HasColumnType("datetime")
                .HasColumnName("Update_dt");
            entity.Property(e => e.UserBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDesignStudio>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblDesignStudio");

            entity.HasIndex(e => e.SrNo, "SrNo")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.AdisnEstHrsDate).HasColumnType("datetime");
            entity.Property(e => e.Allocatedt).HasColumnType("datetime");
            entity.Property(e => e.AttachmentFile)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.DesignerAllocation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Designer_allocation");
            entity.Property(e => e.EmailRecievedDt).HasColumnType("datetime");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entry_by");
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("Entry_dt");
            entity.Property(e => e.EstimatedComplDate)
                .HasColumnType("datetime")
                .HasColumnName("EstimatedCompl_Date");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FilePath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InProgressDt).HasColumnType("datetime");
            entity.Property(e => e.LastStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldDesigner)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OldEtd)
                .HasColumnType("datetime")
                .HasColumnName("OldETD");
            entity.Property(e => e.OldSystemEtd)
                .HasColumnType("datetime")
                .HasColumnName("OldSystemETD");
            entity.Property(e => e.PreHoldStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Recalldt).HasColumnType("datetime");
            entity.Property(e => e.Receiveddt).HasColumnType("datetime");
            entity.Property(e => e.RefSrno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rejectdt).HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDtbysales).HasColumnType("datetime");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReturndtbyDesigner).HasColumnType("datetime");
            entity.Property(e => e.ReviseEtd)
                .HasColumnType("datetime")
                .HasColumnName("ReviseETD");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Submitdt).HasColumnType("datetime");
            entity.Property(e => e.SystemEtd)
                .HasColumnType("datetime")
                .HasColumnName("SystemETD");
            entity.Property(e => e.SystemRecdt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("System_recdt");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Update_by");
            entity.Property(e => e.UpdateDt)
                .HasColumnType("datetime")
                .HasColumnName("Update_dt");
        });

        modelBuilder.Entity<TblDesignStudioCancellation>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("TblDesignStudioCancellation");

            entity.Property(e => e.AssignDt).HasColumnType("datetime");
            entity.Property(e => e.CancelBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CancelDt).HasColumnType("datetime");
            entity.Property(e => e.Designer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Remark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SystemEtd)
                .HasColumnType("datetime")
                .HasColumnName("SystemETD");
        });

        modelBuilder.Entity<TblDesignStudioLog>(entity =>
        {
            entity.ToTable("tblDesignStudioLogs");

            entity.Property(e => e.CratedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CratedDate).HasColumnType("datetime");
            entity.Property(e => e.Designer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDesignStudioOther>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblDesignStudioOther");

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A90BA84CB1")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A92604D64B")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A9363618CD")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A937654DF3")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A943944504")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A986C4477A")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A9A67840EF")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.AdisnEstHrsDate).HasColumnType("datetime");
            entity.Property(e => e.Allocatedt).HasColumnType("datetime");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.DesignType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DesignerAllocation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Designer_allocation");
            entity.Property(e => e.EmailRecievedDt).HasColumnType("datetime");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entry_by");
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("Entry_dt");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FilePath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InProgressDt).HasColumnType("datetime");
            entity.Property(e => e.LastStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Recalldt).HasColumnType("datetime");
            entity.Property(e => e.Receiveddt).HasColumnType("datetime");
            entity.Property(e => e.RefSrno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rejectdt).HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDtbysales).HasColumnType("datetime");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReviseEtd).HasColumnType("datetime");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Submitdt).HasColumnType("datetime");
            entity.Property(e => e.SystemEtd)
                .HasColumnType("datetime")
                .HasColumnName("SystemETD");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Update_by");
            entity.Property(e => e.UpdateDt)
                .HasColumnType("datetime")
                .HasColumnName("Update_dt");
            entity.Property(e => e.WorkType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDesignStudioSecond>(entity =>
        {
            entity.ToTable("tblDesignStudioSecond");

            entity.HasIndex(e => e.SrNo, "UQ__tblDesig__C3A4D3ADAB9B51BC").IsUnique();

            entity.Property(e => e.Allocatedt).HasColumnType("datetime");
            entity.Property(e => e.AttachmentFile)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.DesignType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DesignerAllocation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Designer_allocation");
            entity.Property(e => e.EmailRecievedDt).HasColumnType("datetime");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entry_by");
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("Entry_dt");
            entity.Property(e => e.EstimatedComplDate)
                .HasColumnType("datetime")
                .HasColumnName("EstimatedCompl_Date");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FilePath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InProgressDt).HasColumnType("datetime");
            entity.Property(e => e.LastStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreHoldStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Recalldt).HasColumnType("datetime");
            entity.Property(e => e.Receiveddt).HasColumnType("datetime");
            entity.Property(e => e.Rejectdt).HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDtbysales).HasColumnType("datetime");
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReturndtbyDesigner).HasColumnType("datetime");
            entity.Property(e => e.ReviseEtd)
                .HasColumnType("datetime")
                .HasColumnName("ReviseETD");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Submitdt).HasColumnType("datetime");
            entity.Property(e => e.SystemEtd)
                .HasColumnType("datetime")
                .HasColumnName("SystemETD");
            entity.Property(e => e.SystemRecdt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("System_recdt");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Update_by");
            entity.Property(e => e.UpdateDt)
                .HasColumnType("datetime")
                .HasColumnName("Update_dt");
            entity.Property(e => e.WorkType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDesignerMaster>(entity =>
        {
            entity.ToTable("tblDesignerMaster");

            entity.Property(e => e.Acno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACNO");
            entity.Property(e => e.Addresh)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Companycode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Guarantor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAN");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDesignerOtherTask>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblDesignerOtherTask");

            entity.Property(e => e.Allocatedt).HasColumnType("datetime");
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.DesignType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DesignerAllocation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Designer_allocation");
            entity.Property(e => e.EmailRecievedDt).HasColumnType("datetime");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entry_by");
            entity.Property(e => e.EntryDt)
                .HasColumnType("datetime")
                .HasColumnName("Entry_dt");
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InProgressDt).HasColumnType("datetime");
            entity.Property(e => e.LastStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Receiveddt).HasColumnType("datetime");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReturnRemark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Submitdt).HasColumnType("datetime");
            entity.Property(e => e.SystemEtd)
                .HasColumnType("datetime")
                .HasColumnName("SystemETD");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Update_by");
            entity.Property(e => e.UpdateDt)
                .HasColumnType("datetime")
                .HasColumnName("Update_dt");
            entity.Property(e => e.WorkType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDesignerProc>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblDesignerProc");

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A945167FAE")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A95C84F703")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A975B154A6")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A9760493F9")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A986B9254D")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A9AC87AF7E")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.SrNo, e.SrNoPart }, "UQ__tblDesig__3FEC07A9F916080C")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.FilePath)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Holddt).HasColumnType("datetime");
            entity.Property(e => e.LastStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LnthFt).HasColumnName("Lnth_ft");
            entity.Property(e => e.LnthInch).HasColumnName("Lnth_inch");
            entity.Property(e => e.Productionarea).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.RejectDt).HasColumnType("datetime");
            entity.Property(e => e.ReleaseDt).HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RndprogPer).HasColumnName("RNDProgPer");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusDate).HasColumnType("datetime");
            entity.Property(e => e.Submitdt).HasColumnType("datetime");
            entity.Property(e => e.WdthFt).HasColumnName("Wdth_ft");
            entity.Property(e => e.WdthInch).HasColumnName("Wdth_inch");
        });

        modelBuilder.Entity<TblDesignerProcLog>(entity =>
        {
            entity.ToTable("tblDesignerProcLogs");

            entity.Property(e => e.CratedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CratedDate).HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDirectSampleProc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblDirec__3214EC07521B55DA");

            entity.ToTable("tblDirectSampleProc");

            entity.Property(e => e.Clientno)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Colorno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Designno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.ExportBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExportDt).HasColumnType("datetime");
            entity.Property(e => e.Quality)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sampleno)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Shape)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UOM");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblEmailQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblEmail__3214EC073177F742");

            entity.ToTable("TblEmailQueue");

            entity.Property(e => e.Bccemails).HasColumnName("BCCEmails");
            entity.Property(e => e.Ccemails).HasColumnName("CCEmails");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FromUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsSent).HasDefaultValueSql("('Pending')");
            entity.Property(e => e.RecipientEmail).HasMaxLength(255);
            entity.Property(e => e.SentAt).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(500);
        });

        modelBuilder.Entity<TblEmployeeMst>(entity =>
        {
            entity.ToTable("TblEmployee_mst");

            entity.Property(e => e.Companycode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.FilePath).IsUnicode(false);
            entity.Property(e => e.Fullname)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Photo).IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblFibreMst>(entity =>
        {
            entity.ToTable("TblFibre_mst");

            entity.Property(e => e.Category).HasMaxLength(10);
            entity.Property(e => e.Fibre).HasMaxLength(150);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quality).HasMaxLength(15);
            entity.Property(e => e.Quantity).HasMaxLength(20);
            entity.Property(e => e.Unit).HasMaxLength(10);
        });

        modelBuilder.Entity<TblFinalEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblFinal__3214EC076C2DE25E");

            entity.ToTable("TblFinalEntry");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.EntryType).HasMaxLength(50);
            entity.Property(e => e.Entryby).HasMaxLength(100);
            entity.Property(e => e.FinalIssueQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalReturnQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinaltRcptQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GatePassNo).HasMaxLength(50);
            entity.Property(e => e.Material).HasMaxLength(20);
            entity.Property(e => e.OrderNumber).HasMaxLength(20);
            entity.Property(e => e.Rcptid).HasColumnName("RCPTId");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.TwistQnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Updateby).HasMaxLength(100);
            entity.Property(e => e.VendarName).HasMaxLength(200);
        });

        modelBuilder.Entity<TblFinalReceiveEntry>(entity =>
        {
            entity.ToTable("TblFinalReceiveEntry");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Entryby).HasMaxLength(50);
            entity.Property(e => e.FinalIssueQnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalReceiveQnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GatePassNo).HasMaxLength(20);
            entity.Property(e => e.LossQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderNumber).HasMaxLength(50);
            entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Updateby).HasMaxLength(50);
        });

        modelBuilder.Entity<TblHandtuftOrderMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblHandt__3214EC073F621B8C");

            entity.ToTable("TblHandtuftOrder_mst");

            entity.Property(e => e.EntryBy).HasMaxLength(250);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.OrderNo).HasMaxLength(50);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .HasColumnName("Sr_No");
            entity.Property(e => e.UpdateBy).HasMaxLength(250);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblHtProdnBooking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblHtProdnBooking__3214EC076E6DB821");

            entity.ToTable("TblHtProdnBooking");

            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Entryby)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProdnRateSqmhr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shifting)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.ToalProdnSqm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalQntySqm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblHtprodnPlanning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblHTPro__3214EC075762984A");

            entity.ToTable("TblHTProdnPlanning");

            entity.Property(e => e.Color)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DesignName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Entryby)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Entrydate).HasColumnType("datetime");
            entity.Property(e => e.FactoryNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Isexit).HasColumnName("isexit");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PlanningDate).HasColumnType("datetime");
            entity.Property(e => e.Quality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.TotalProdnAreaSqm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TuftEndDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblHtproductionRateMst>(entity =>
        {
            entity.HasKey(e => e.Prdratid).HasName("PK__tblHTPro__A41A9F8CEB8F1D08");

            entity.ToTable("tblHTProductionRate_mst");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.PerHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Per_Hr");
            entity.Property(e => e.Quality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<TblIthardwareMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblITHar__3214EC07310EF2D9");

            entity.ToTable("TblITHardware_mst");

            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EntryBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ItemType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MachineName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModelNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remark).IsUnicode(false);
            entity.Property(e => e.SystemStatus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Warranty)
                .HasColumnType("datetime")
                .HasColumnName("WARRANTY");
            entity.Property(e => e.WarrantyAmc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WarrantyAMC");
        });

        modelBuilder.Entity<TblItuserSystemInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblITUse__3214EC07B31B179C");

            entity.ToTable("tblITUserSystemInfo");

            entity.Property(e => e.Antivirus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Cabinet)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cpu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CPU");
            entity.Property(e => e.DataDriveUsb)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DataDrive_USB");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DisplayCard)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Dvdcombo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DVDCombo");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.FileName).IsUnicode(false);
            entity.Property(e => e.FilePath).IsUnicode(false);
            entity.Property(e => e.HardDisk)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.KeyBoard)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LanCard)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModelNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Monitor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MonitorSrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MonitorWarranty).HasColumnType("datetime");
            entity.Property(e => e.MotherBoard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mouse)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OperatingSystem)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Other)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PrinterScanner)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PrinterScannerSrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ram)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RAM");
            entity.Property(e => e.Remark).IsUnicode(false);
            entity.Property(e => e.ScreenSize)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SoundCard)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Speaker)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SystemStatus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Ups)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UPS");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Warranty)
                .HasColumnType("datetime")
                .HasColumnName("WARRANTY");
            entity.Property(e => e.WarrantyAmc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WarrantyAMC");
        });

        modelBuilder.Entity<TblLead>(entity =>
        {
            entity.HasKey(e => e.Leadid).HasName("PK__tblLeads__73EC7D22AE72F733");

            entity.ToTable("tblLeads");

            entity.Property(e => e.Brand)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Business)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Contrycode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Desicription).IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FollowupDate).HasColumnType("datetime");
            entity.Property(e => e.HoldReason)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Industries)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LeadNo)
                .HasMaxLength(52)
                .IsUnicode(false)
                .HasComputedColumnSql("('L-'+CONVERT([varchar](50),[Leadid]))", true);
            entity.Property(e => e.LeadSource)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.LeadStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadType)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.LeadsourceOth)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Leadsource_oth");
            entity.Property(e => e.LostReason)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Rating)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Referrer)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Solutation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Streets)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Website)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblLocationMaster>(entity =>
        {
            entity.ToTable("TblLocationMaster");

            entity.Property(e => e.Holiday)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LunchTimeFrom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LunchTimeTo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutTime)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblLoginDetail>(entity =>
        {
            entity.ToTable("tblLoginDetail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LastLogindate)
                .HasColumnType("datetime")
                .HasColumnName("last_logindate");
            entity.Property(e => e.LastLoginip)
                .HasMaxLength(50)
                .HasColumnName("last_loginip");
            entity.Property(e => e.LogOutTime).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(150)
                .HasColumnName("User_id");
        });

        modelBuilder.Entity<TblLoomMst>(entity =>
        {
            entity.HasKey(e => e.Loomid).HasName("PK__tblLoom___F26D516F5D4E071A");

            entity.ToTable("tblLoom_mst");

            entity.Property(e => e.CreateDat).HasColumnType("datetime");
            entity.Property(e => e.LoomName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblLoomProductionMst>(entity =>
        {
            entity.HasKey(e => e.Loomprodnid).HasName("PK__tblLoomP__C5FFD4D4921B4828");

            entity.ToTable("tblLoomProduction_mst");

            entity.Property(e => e.ActualOffloomDate)
                .HasColumnType("datetime")
                .HasColumnName("Actual_offloomDate");
            entity.Property(e => e.CarpetEtd)
                .HasColumnType("datetime")
                .HasColumnName("Carpet_ETD");
            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.ChangeoverTimeHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ChangeoverTime_hr");
            entity.Property(e => e.Customer)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DaysNeeded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.NoofTufterAssigned).HasColumnName("NoofTufter_Assigned");
            entity.Property(e => e.ProdnCompletedSqm).HasColumnName("ProdnCompleted_sqm");
            entity.Property(e => e.ProdnRateSqmhr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ProdnRate_sqmhr");
            entity.Property(e => e.ProdnRemainingSqm).HasColumnName("ProdnRemaining_sqm");
            entity.Property(e => e.Quality)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.QuantitySqm).HasColumnName("Quantity_sqm");
            entity.Property(e => e.SystemRecordEtd)
                .HasColumnType("datetime")
                .HasColumnName("SystemRecord_ETD");
            entity.Property(e => e.TotalHoursNeeded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TufterCat)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TuftingEtd)
                .HasColumnType("datetime")
                .HasColumnName("Tufting_ETD");
            entity.Property(e => e.TuftingTimeHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TuftingTime_Hr");
        });

        modelBuilder.Entity<TblLoomProductionMstLog>(entity =>
        {
            entity.HasKey(e => e.Loomprodnid).HasName("PK__tblLoomP__C5FFD4D4E27AAEE8");

            entity.ToTable("tblLoomProduction_mstLog");

            entity.Property(e => e.ActualOffloomDate)
                .HasColumnType("datetime")
                .HasColumnName("Actual_offloomDate");
            entity.Property(e => e.CarpetEtd)
                .HasColumnType("datetime")
                .HasColumnName("Carpet_ETD");
            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.ChangeoverTimeHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ChangeoverTime_hr");
            entity.Property(e => e.Customer)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DaysNeeded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.NoofTufterAssigned).HasColumnName("NoofTufter_Assigned");
            entity.Property(e => e.ProdnCompletedSqm).HasColumnName("ProdnCompleted_sqm");
            entity.Property(e => e.ProdnRateSqmhr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ProdnRate_sqmhr");
            entity.Property(e => e.ProdnRemainingSqm).HasColumnName("ProdnRemaining_sqm");
            entity.Property(e => e.Quality)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.QuantitySqm).HasColumnName("Quantity_sqm");
            entity.Property(e => e.SystemRecordEtd)
                .HasColumnType("datetime")
                .HasColumnName("SystemRecord_ETD");
            entity.Property(e => e.TotalHoursNeeded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TufterCat)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TuftingEtd)
                .HasColumnType("datetime")
                .HasColumnName("Tufting_ETD");
            entity.Property(e => e.TuftingTimeHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TuftingTime_Hr");
        });

        modelBuilder.Entity<TblMachinProdnMst>(entity =>
        {
            entity.HasKey(e => e.Prodnid).HasName("PK__TblMachi__A9643CA9CEE831CF");

            entity.ToTable("TblMachinProdn_Mst");

            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.ChangeoverTimeHr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerPono).HasMaxLength(255);
            entity.Property(e => e.LengthM).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MachinNo).HasMaxLength(255);
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.NoofPcs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OffLoomDate).HasColumnType("datetime");
            entity.Property(e => e.OrderQntySqm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdnRateSqmhr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quality).HasMaxLength(255);
            entity.Property(e => e.RequireDate).HasColumnType("datetime");
            entity.Property(e => e.SrNo).HasMaxLength(255);
            entity.Property(e => e.StartedDate).HasColumnType("datetime");
            entity.Property(e => e.TotalProdnTimeHr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TufterTimeHr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WidthM).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblMachinSpeedRateMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblMachi__3214EC07E2E0FEA3");

            entity.ToTable("TblMachinSpeedRate_mst");

            entity.Property(e => e.EnterBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.MachinNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MachinSpeed)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Machin_Speed");
            entity.Property(e => e.Quality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePerHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Rate_PerHr");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMaterialLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblMater__3214EC27B6CFD969");

            entity.ToTable("TblMaterialLabel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaterialType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ToLabel)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMicroTuftMst>(entity =>
        {
            entity.ToTable("TblMicroTuft_mst");

            entity.Property(e => e.Category).HasMaxLength(10);
            entity.Property(e => e.Microtuft).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quality).HasMaxLength(15);
            entity.Property(e => e.Quantity).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(10);
        });

        modelBuilder.Entity<TblMiscellaneou>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblMisce__3214EC07E87273E7");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Detail)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sno).HasColumnName("SNo");
        });

        modelBuilder.Entity<TblMmenu>(entity =>
        {
            entity.HasKey(e => e.Mmnuid);

            entity.ToTable("tblMmenu");

            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mmnuname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Msequence).HasColumnName("msequence");
        });

        modelBuilder.Entity<TblNetworkInfoMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblNetwo__3214EC073753615F");

            entity.ToTable("TblNetworkInfo_mst");

            entity.Property(e => e.AlternetDns)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AlternetDNS");
            entity.Property(e => e.ComputerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EmailClient)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Gateway)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InternetAccess)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PreferredDns)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PreferredDNS");
            entity.Property(e => e.SubnetMask)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UserLoginName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UserRight)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.WorkGroupDomain)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("WorkGroup_Domain");
        });

        modelBuilder.Entity<TblNotice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblNotic__3214EC07FC95D8B6");

            entity.ToTable("TblNotice");

            entity.Property(e => e.Notice).IsUnicode(false);
        });

        modelBuilder.Entity<TblNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblNotif__3214EC07CE2BF3BD");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FromUser)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IsRead).HasDefaultValue(false);
            entity.Property(e => e.Message).IsUnicode(false);
            entity.Property(e => e.NotificationType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReadDate).HasColumnType("datetime");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ToUser)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblPacking>(entity =>
        {
            entity.ToTable("TblPacking");

            entity.Property(e => e.CustomerCode).HasMaxLength(150);
            entity.Property(e => e.DespDate).HasColumnType("datetime");
            entity.Property(e => e.EntryBy).HasMaxLength(150);
            entity.Property(e => e.EntryByDate).HasColumnType("datetime");
            entity.Property(e => e.Mode).HasMaxLength(50);
            entity.Property(e => e.OrderNo).HasMaxLength(50);
            entity.Property(e => e.Packing).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(30);
            entity.Property(e => e.UpdateBy).HasMaxLength(150);
            entity.Property(e => e.UpdateByDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPermmenu>(entity =>
        {
            entity.HasKey(e => e.Pmid);

            entity.ToTable("tblPermmenu");

            entity.Property(e => e.Pmid).HasColumnName("pmid");
            entity.Property(e => e.Addperm).HasColumnName("addperm");
            entity.Property(e => e.Delperm).HasColumnName("delperm");
            entity.Property(e => e.Ediperm).HasColumnName("ediperm");
            entity.Property(e => e.Mmnuid).HasColumnName("mmnuid");
            entity.Property(e => e.Permission)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Viewperm).HasColumnName("viewperm");
        });

        modelBuilder.Entity<TblProdnBooking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblProdn__3214EC076E6DB821");

            entity.ToTable("TblProdnBooking");

            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Entryby)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MachineNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OneTimeDown).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdnRateSqmhr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remark).IsUnicode(false);
            entity.Property(e => e.Shifting)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.ToalProdnSqm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalQntySqm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TufterName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WeavingCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblProdnPlanning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblProdn__3214EC07DC5EF705");

            entity.ToTable("TblProdnPlanning");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entryby)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Entrydate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Isexit).HasColumnName("isexit");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PartNo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PieceSrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlanningDate).HasColumnType("datetime");
            entity.Property(e => e.SireealNo).HasColumnName("sireealNo");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.TotalHr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalProdnAreaSqm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TuftEndDate).HasColumnType("datetime");
            entity.Property(e => e.TuftingDirection)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.WeavingCategory)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblProdnPlanningMultiPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblProdn__3214EC075AC6CFF9");

            entity.ToTable("TblProdnPlanningMultiPart");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entryby)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Entrydate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Isexit).HasColumnName("isexit");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PartNo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PieceSrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlanningDate).HasColumnType("datetime");
            entity.Property(e => e.SireealNo).HasColumnName("sireealNo");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.TotalHr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalProdnAreaSqm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TuftEndDate).HasColumnType("datetime");
            entity.Property(e => e.TuftingDirection)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.WeavingCategory)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblProductionAck>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("TblProductionAck");

            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDt).HasColumnType("datetime");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Etd).HasColumnName("ETD");
            entity.Property(e => e.FileName).IsUnicode(false);
            entity.Property(e => e.FilePath).IsUnicode(false);
            entity.Property(e => e.Flage)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.FlageDate).HasColumnType("datetime");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RemarkFactory)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RemarkSale)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Srno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updatedt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblProductionAcktemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblProductionAcktemp");

            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDt).HasColumnType("datetime");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Etd).HasColumnName("ETD");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.RemarkFactory)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RemarkSale)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Srno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updatedt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblProductionMst>(entity =>
        {
            entity.HasKey(e => e.Prodnid).HasName("PK__tblProdu__52EB05F29C128522");

            entity.ToTable("tblProduction_mst");

            entity.Property(e => e.Prodnid).HasColumnName("prodnid");
            entity.Property(e => e.ActualLoomDate)
                .HasColumnType("datetime")
                .HasColumnName("Actual_loomDate");
            entity.Property(e => e.CarpetEtd)
                .HasColumnType("datetime")
                .HasColumnName("Carpet_ETD");
            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.ChangeoverTimeHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ChangeoverTime_hr");
            entity.Property(e => e.Customer)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CustomerPono)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CustomerPONo");
            entity.Property(e => e.DaysNeeded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EstimatedFloomDate)
                .HasColumnType("datetime")
                .HasColumnName("Estimated_floomDate");
            entity.Property(e => e.LoomAllocation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.NoofTufterAssigned).HasColumnName("NoofTufter_Assigned");
            entity.Property(e => e.OrderQntySqm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OrderQnty_sqm");
            entity.Property(e => e.ProdnCompletedSqm).HasColumnName("ProdnCompleted_sqm");
            entity.Property(e => e.ProdnRateSqmhr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ProdnRate_sqmhr");
            entity.Property(e => e.ProdnRemainingSqm).HasColumnName("ProdnRemaining_sqm");
            entity.Property(e => e.Quality)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SuggestedLoomNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Suggested_LoomNo");
            entity.Property(e => e.TotalHoursNeeded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TufterCat)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TuftingEtd)
                .HasColumnType("datetime")
                .HasColumnName("Tufting_ETD");
            entity.Property(e => e.TuftingStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Tufting_StartDate");
            entity.Property(e => e.TuftingTimeHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TuftingTime_Hr");
        });

        modelBuilder.Entity<TblProductionMstLog>(entity =>
        {
            entity.HasKey(e => e.Prodnid).HasName("PK__tblProdu__52EB05F2004E1AA7");

            entity.ToTable("tblProduction_mstLog");

            entity.Property(e => e.Prodnid).HasColumnName("prodnid");
            entity.Property(e => e.ActualLoomDate)
                .HasColumnType("datetime")
                .HasColumnName("Actual_loomDate");
            entity.Property(e => e.CarpetEtd)
                .HasColumnType("datetime")
                .HasColumnName("Carpet_ETD");
            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.ChangeoverTimeHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ChangeoverTime_hr");
            entity.Property(e => e.Customer)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CustomerPono)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CustomerPONo");
            entity.Property(e => e.DaysNeeded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EstimatedFloomDate)
                .HasColumnType("datetime")
                .HasColumnName("Estimated_floomDate");
            entity.Property(e => e.LoomAllocation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.NoofTufterAssigned).HasColumnName("NoofTufter_Assigned");
            entity.Property(e => e.OrderQntySqm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OrderQnty_sqm");
            entity.Property(e => e.ProdnCompletedSqm).HasColumnName("ProdnCompleted_sqm");
            entity.Property(e => e.ProdnRateSqmhr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ProdnRate_sqmhr");
            entity.Property(e => e.ProdnRemainingSqm).HasColumnName("ProdnRemaining_sqm");
            entity.Property(e => e.Quality)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SuggestedLoomNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Suggested_LoomNo");
            entity.Property(e => e.TotalHoursNeeded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TufterCat)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TuftingEtd)
                .HasColumnType("datetime")
                .HasColumnName("Tufting_ETD");
            entity.Property(e => e.TuftingStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Tufting_StartDate");
            entity.Property(e => e.TuftingTimeHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TuftingTime_Hr");
        });

        modelBuilder.Entity<TblProductionRateMst>(entity =>
        {
            entity.HasKey(e => e.Prdratid).HasName("PK__tblProdu__A41A9F8CB7185904");

            entity.ToTable("tblProductionRate_mst");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.PerHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Per_Hr");
            entity.Property(e => e.Quality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UOM");
            entity.Property(e => e.WeavingCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblProjectMst>(entity =>
        {
            entity.HasKey(e => e.Projectid).HasName("PK__tblProje__7611CEA86C275B00");

            entity.ToTable("tblProject_mst");

            entity.Property(e => e.BillingCity)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BillingState)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BillingStreet)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Business)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ClientName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Contact)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Corrency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryInstallationStatus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LeadSource)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.LeadSourceOth)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LeadSource_Oth");
            entity.Property(e => e.LostReason).IsUnicode(false);
            entity.Property(e => e.ProjectCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProjectName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ProjectStatus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Referrer)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShippingCity)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ShippingCountry)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ShippingState)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ShippingStreet)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UoM)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblQualityMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblQualityMaster");

            entity.Property(e => e.Alias).HasMaxLength(25);
            entity.Property(e => e.ExQuality).HasMaxLength(35);
            entity.Property(e => e.Prefix).HasMaxLength(3);
            entity.Property(e => e.Quality)
                .HasMaxLength(30)
                .HasColumnName("quality");
            entity.Property(e => e.Username).HasMaxLength(20);
        });

        modelBuilder.Entity<TblQuotation>(entity =>
        {
            entity.HasKey(e => e.Quoteid);

            entity.ToTable("tblQuotation");

            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BillCity)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BillCountry)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BillName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BillState)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BillStreets)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BillZip)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactName).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountPerc).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Email).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FreightCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.OverAllDiscount).HasColumnName("overAllDiscount");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.QuotationName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShipCity)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShipCountry)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShipName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShipState)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShipStreets)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShipZip)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxInPercantage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TermCondition).IsUnicode(false);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblQuotationRateMaster>(entity =>
        {
            entity.ToTable("tblQuotationRateMaster");

            entity.Property(e => e.Area).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Carving)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Construction)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstallationType)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MarketSegment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MicroTufting)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PcsBand)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Price1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price5).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quality)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SpecialPileHeightMm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SpecialPileHeight_mm");
            entity.Property(e => e.Texture)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.YarnType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblReceiveEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblRecei__3214EC077F7A0BE8");

            entity.ToTable("TblReceiveEntry");

            entity.Property(e => e.EntryDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Entryby).HasMaxLength(50);
            entity.Property(e => e.IssueId).HasColumnName("issueId");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Updateby).HasMaxLength(50);
            entity.Property(e => e.WinderIssueQnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WinderReceiveQnty).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblRemitterMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblRemit__3214EC076E028721");

            entity.ToTable("TblRemitterMaster");

            entity.Property(e => e.AccountName).HasMaxLength(200);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.AccountType).HasMaxLength(50);
            entity.Property(e => e.Branch).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(50);
            entity.Property(e => e.Group).HasMaxLength(50);
            entity.Property(e => e.RemitterName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblRndcmplPer>(entity =>
        {
            entity.ToTable("TblRNDCmplPer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ComplPer).HasColumnName("Compl_per");
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Entryby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblRobotuftOrderMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblRobot__3214EC07A38819AF");

            entity.ToTable("TblRobotuftOrder_mst");

            entity.Property(e => e.EntryBy).HasMaxLength(250);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.IsMapping).HasDefaultValue(false);
            entity.Property(e => e.OrderNo).HasMaxLength(50);
            entity.Property(e => e.Purjano).HasMaxLength(50);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .HasColumnName("Sr_No");
            entity.Property(e => e.UpdateBy).HasMaxLength(250);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblRtgsapplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblRTGSA__3214EC072BAF674D");

            entity.ToTable("TblRTGSApplication");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BankCharges).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BeneficiaryAccount).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.RemitterName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblSamProdOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("TblSam_ProdOrder");

            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDt).HasColumnType("datetime");
            entity.Property(e => e.CancelBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.Category)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodeHk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CodeHK");
            entity.Property(e => e.ColorName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Composition)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustEmailAppDt).HasColumnType("datetime");
            entity.Property(e => e.CustomerReference)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ddp)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DDP");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DyeingDueDt).HasColumnType("datetime");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Etd).HasColumnName("ETD");
            entity.Property(e => e.Freight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HoldRealesedt).HasColumnType("datetime");
            entity.Property(e => e.Hsn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("HSN");
            entity.Property(e => e.InvoiceType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IrregularArea).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.LastStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PreHoldStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriceCaculation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProjectNo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Rate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.RegularArea).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReqDate).HasColumnType("datetime");
            entity.Property(e => e.ShipMode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SideMark)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.SubclientName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TraceDueDt)
                .HasColumnType("datetime")
                .HasColumnName("TraceDueDT");
        });

        modelBuilder.Entity<TblSampleAck>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblSampleAck");

            entity.HasIndex(e => e.Srno, "UQ_SrNo")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDt).HasColumnType("datetime");
            entity.Property(e => e.Courier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DispatchBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DispatchDt).HasColumnType("datetime");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Etd).HasColumnName("ETD");
            entity.Property(e => e.FileName).IsUnicode(false);
            entity.Property(e => e.FilePath).IsUnicode(false);
            entity.Property(e => e.Flage)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.FlageDate).HasColumnType("datetime");
            entity.Property(e => e.LabelDt).HasColumnType("datetime");
            entity.Property(e => e.PreHoldStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProcessingDt).HasColumnType("datetime");
            entity.Property(e => e.RefSampleNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RemarkFactory)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RemarkSale)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Srno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrackNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Updateby)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Updatedt).HasColumnType("datetime");
            entity.Property(e => e.Weaver)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSampleFailMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("TblSampleFail_mst");

            entity.Property(e => e.ClientNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Csname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CSName");
            entity.Property(e => e.DesignerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DyerName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.SampleRefNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WeaverName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSampleGodownDtl>(entity =>
        {
            entity.ToTable("TblSampleGodown_Dtl");

            entity.HasIndex(e => new { e.GodownNo, e.RackNo, e.BaleNo }, "UX_Godown_Rack_Bale").IsUnique();

            entity.Property(e => e.BaleNo).HasMaxLength(50);
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerNo).HasMaxLength(150);
            entity.Property(e => e.Design).HasMaxLength(250);
            entity.Property(e => e.EntryBy).HasMaxLength(150);
            entity.Property(e => e.EntryByDate).HasColumnType("datetime");
            entity.Property(e => e.EntryByUpdate).HasMaxLength(150);
            entity.Property(e => e.EntryByUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.GodownNo).HasMaxLength(150);
            entity.Property(e => e.Matrial).HasMaxLength(150);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.Quality).HasMaxLength(150);
            entity.Property(e => e.RackNo).HasMaxLength(150);
            entity.Property(e => e.SampleNo).HasMaxLength(150);
        });

        modelBuilder.Entity<TblSampleLable>(entity =>
        {
            entity.ToTable("TblSampleLable");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasMaxLength(150);
            entity.Property(e => e.Color).HasMaxLength(150);
            entity.Property(e => e.CustomerNo).HasMaxLength(50);
            entity.Property(e => e.Design).HasMaxLength(250);
            entity.Property(e => e.EntryBy).HasMaxLength(150);
            entity.Property(e => e.EntryByDate).HasColumnType("datetime");
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.LnthFt).HasColumnName("Lnth_ft");
            entity.Property(e => e.LnthInch).HasColumnName("Lnth_inch");
            entity.Property(e => e.Matrial).HasMaxLength(150);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.Quality).HasMaxLength(150);
            entity.Property(e => e.SrNo).HasMaxLength(50);
            entity.Property(e => e.SubQuality).HasMaxLength(150);
            entity.Property(e => e.Texture).HasMaxLength(150);
            entity.Property(e => e.Uom).HasMaxLength(20);
            entity.Property(e => e.UpdateBy).HasMaxLength(150);
            entity.Property(e => e.UpdateByDate).HasColumnType("datetime");
            entity.Property(e => e.WdthFt).HasColumnName("Wdth_ft");
            entity.Property(e => e.WdthInch).HasColumnName("Wdth_inch");
        });

        modelBuilder.Entity<TblSampleNoMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("TblSampleNo_mst");

            entity.Property(e => e.ClientName).HasMaxLength(250);
            entity.Property(e => e.ClientNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.CsreqDate).HasColumnName("CSReqDate");
            entity.Property(e => e.CustPono)
                .HasMaxLength(50)
                .HasColumnName("CustPONO");
            entity.Property(e => e.DispRemark).HasColumnName("Disp_Remark");
            entity.Property(e => e.DispStatuseDate)
                .HasColumnType("datetime")
                .HasColumnName("Disp_StatuseDate");
            entity.Property(e => e.DispatchBy).HasMaxLength(250);
            entity.Property(e => e.Etd).HasColumnName("ETD");
            entity.Property(e => e.HandleBy).HasMaxLength(150);
            entity.Property(e => e.ProjectName).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SampleRefNo).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(150);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(150);
        });

        modelBuilder.Entity<TblSampleNoReEtdMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblSampl__3214EC0718B069E8");

            entity.ToTable("TblSampleNoReETD_mst");

            entity.Property(e => e.EntryBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.SampleEtd).HasColumnName("SampleETD");
        });

        modelBuilder.Entity<TblSampleRackNo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblSampl__3214EC071558D330");

            entity.ToTable("TblSampleRackNo");

            entity.HasIndex(e => new { e.GodownNo, e.RackNo, e.BaleNo }, "UX_Godown_Rack_Bale").IsUnique();

            entity.Property(e => e.BaleNo).HasMaxLength(50);
            entity.Property(e => e.GodownNo).HasMaxLength(50);
            entity.Property(e => e.RackNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSampleStatusMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblSampl__3214EC0772F0AAD7");

            entity.ToTable("TblSampleStatus_mst");

            entity.Property(e => e.StatusName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.StatusValue)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSerialMaster>(entity =>
        {
            entity.ToTable("TblSerialMaster");

            entity.Property(e => e.Fy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FY");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrNo).HasColumnName("Sr_No");
        });

        modelBuilder.Entity<TblShape>(entity =>
        {
            entity.ToTable("tblShape");

            entity.Property(e => e.Carpetno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carpetno");
            entity.Property(e => e.Companycode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("companycode");
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Process)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("process");
            entity.Property(e => e.Shape)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHAPE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblShareGroup>(entity =>
        {
            entity.ToTable("TblShareGroup");

            entity.Property(e => e.ShareGroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SharePerson)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSmenu>(entity =>
        {
            entity.HasKey(e => e.Smnuid);

            entity.ToTable("tblSmenu");

            entity.Property(e => e.Action).IsUnicode(false);
            entity.Property(e => e.Addmode).HasColumnName("addmode");
            entity.Property(e => e.Controller).IsUnicode(false);
            entity.Property(e => e.Delmode).HasColumnName("delmode");
            entity.Property(e => e.Edimode).HasColumnName("edimode");
            entity.Property(e => e.Iconfile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("iconfile");
            entity.Property(e => e.Msequence).HasColumnName("msequence");
            entity.Property(e => e.Smnuname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Viewmode).HasColumnName("viewmode");
        });

        modelBuilder.Entity<TblSubClientMaster>(entity =>
        {
            entity.ToTable("TblSubClientMaster");

            entity.Property(e => e.CustomeCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ShortCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubClientCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubClientName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSubClientMst>(entity =>
        {
            entity.ToTable("TblSubClient_mst");

            entity.Property(e => e.BillingCity).HasMaxLength(255);
            entity.Property(e => e.BillingCountry).HasMaxLength(255);
            entity.Property(e => e.BillingState).HasMaxLength(255);
            entity.Property(e => e.BillingStreet).HasMaxLength(255);
            entity.Property(e => e.Brand).HasMaxLength(255);
            entity.Property(e => e.BusinessGstnno)
                .HasMaxLength(255)
                .HasColumnName("BusinessGSTNNo");
            entity.Property(e => e.ClientRecordsType).HasMaxLength(255);
            entity.Property(e => e.ClientSource).HasMaxLength(255);
            entity.Property(e => e.ClientSourceOth)
                .HasMaxLength(255)
                .HasColumnName("ClientSource_oth");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Industry).HasMaxLength(255);
            entity.Property(e => e.OwnerShip).HasMaxLength(255);
            entity.Property(e => e.ParentClientCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriorityStatus).HasMaxLength(255);
            entity.Property(e => e.Rating).HasMaxLength(255);
            entity.Property(e => e.ShippingCity).HasMaxLength(255);
            entity.Property(e => e.ShippingCountry).HasMaxLength(255);
            entity.Property(e => e.ShippingState).HasMaxLength(255);
            entity.Property(e => e.ShippingStreet).HasMaxLength(255);
            entity.Property(e => e.ShortName).HasMaxLength(255);
            entity.Property(e => e.SubClientName)
                .HasMaxLength(255)
                .HasColumnName("subClientName");
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Website).HasMaxLength(255);
        });

        modelBuilder.Entity<TblSubQuality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblSubQu__3214EC07BE744341");

            entity.ToTable("TblSubQuality");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Quality)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SubQuality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblTicket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblTicke__3213E83F0D4C777D");

            entity.ToTable("TblTicket");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CaptchaText).HasColumnName("Captcha_Text");
            entity.Property(e => e.CloseTicketDate).HasColumnType("datetime");
            entity.Property(e => e.ClosedTicketByName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Domain).HasMaxLength(50);
            entity.Property(e => e.Emailaddress).HasMaxLength(400);
            entity.Property(e => e.Etd)
                .HasColumnType("datetime")
                .HasColumnName("ETD");
            entity.Property(e => e.Fallow)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fullname)
                .HasMaxLength(80)
                .HasColumnName("fullname");
            entity.Property(e => e.GenerateTicketBy).HasColumnType("datetime");
            entity.Property(e => e.HelpTopic)
                .HasMaxLength(150)
                .HasColumnName("Help_topic");
            entity.Property(e => e.Img)
                .HasMaxLength(150)
                .HasDefaultValue("~/icone/isactive.png")
                .HasColumnName("img");
            entity.Property(e => e.Isactive)
                .HasDefaultValue(true)
                .HasColumnName("isactive");
            entity.Property(e => e.Lastupdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("lastupdate");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(50)
                .HasColumnName("mobileno");
            entity.Property(e => e.Priority).HasMaxLength(100);
            entity.Property(e => e.Status)
                .HasMaxLength(150)
                .HasDefaultValue("Active")
                .HasColumnName("status");
            entity.Property(e => e.Subject).HasMaxLength(150);
            entity.Property(e => e.Tooltip)
                .HasMaxLength(150)
                .HasDefaultValue("DeActive This Record")
                .HasColumnName("tooltip");
            entity.Property(e => e.Uploadfile).HasColumnName("uploadfile");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<TblTraceBooking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblTraceBooking__3214EC076E6DB821");

            entity.ToTable("TblTraceBooking");

            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Entryby)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.MachineNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PendingQnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shifting)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.TotalQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TraceName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Uom)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblTraceDispatched>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblTrace__3214EC0798714FAA");

            entity.ToTable("tblTraceDispatched");

            entity.Property(e => e.BarcodeBase64)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.BarcodeBase641)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.EntryBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.GatePassNo).HasDefaultValue(50001);
            entity.Property(e => e.LastStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ReceiveDt).HasColumnType("datetime");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblTraceMachinMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblTrace__3214EC076C8494E0");

            entity.ToTable("TblTraceMachin_mst");

            entity.Property(e => e.EnterBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.MachinName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MachinNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MachinSpeed)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Machin_Speed");
            entity.Property(e => e.Quality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePerHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Rate_PerHr");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTraceMachineSpeedMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblTrace__3214EC07F6A75168");

            entity.ToTable("tblTraceMachineSpeed_mst");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.PerHr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Per_Hr");
            entity.Property(e => e.Quality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TraceCategory).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<TblTracePlanning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblTrace__3214EC0701268C81");

            entity.ToTable("TblTracePlanning");

            entity.Property(e => e.DesignCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entryby)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Entrydate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Isexit).HasColumnName("isexit");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PieceSrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlanningDate).HasColumnType("datetime");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
            entity.Property(e => e.TotalHr).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalProdnAreaSqm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TraceEndDate).HasColumnType("datetime");
            entity.Property(e => e.TraceNo).HasDefaultValue(1);
        });

        modelBuilder.Entity<TblTraceProce>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__TblTrace__3214EC07907E54DA")
                .HasFillFactor(90);

            entity.ToTable("TblTraceProce");

            entity.Property(e => e.AllocateDt).HasColumnType("datetime");
            entity.Property(e => e.AllocatedBy)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ApprovedDt).HasColumnType("datetime");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BookingBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BookingDt).HasColumnType("datetime");
            entity.Property(e => e.DesignerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Entryby)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Etd).HasColumnType("datetime");
            entity.Property(e => e.HoldDt).HasColumnType("datetime");
            entity.Property(e => e.InProgressDt).HasColumnType("datetime");
            entity.Property(e => e.LastStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MachineNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Map).HasDefaultValue(false);
            entity.Property(e => e.OrderNo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ReceveDt).HasColumnType("datetime");
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmitBy)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDt).HasColumnType("datetime");
            entity.Property(e => e.SystemEtd).HasColumnType("datetime");
            entity.Property(e => e.Trace).HasDefaultValue(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Updateby)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblTracerMst>(entity =>
        {
            entity.HasKey(e => e.Tufterid).HasName("PK__tblTrace__8A64790ABA259553");

            entity.ToTable("tblTracer_mst");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.DateOccupied).HasColumnType("datetime");
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.TufterCat)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblTufterMst>(entity =>
        {
            entity.HasKey(e => e.Tufterid).HasName("PK__tblTufte__8A64790A2903E57A");

            entity.ToTable("tblTufter_mst");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CerateDate).HasColumnType("datetime");
            entity.Property(e => e.DateOccupied).HasColumnType("datetime");
            entity.Property(e => e.Modifydate).HasColumnType("datetime");
            entity.Property(e => e.TufterCat)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblTwistReceiveEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblTwist__3214EC0713D66075");

            entity.ToTable("TblTwistReceiveEntry");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Entryby).HasMaxLength(50);
            entity.Property(e => e.GatePassNo).HasMaxLength(20);
            entity.Property(e => e.IssId).HasColumnName("issId");
            entity.Property(e => e.LossQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderNo).HasMaxLength(50);
            entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TwistIssueQnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TwistReceiveQnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Updateby).HasMaxLength(50);
        });

        modelBuilder.Entity<TblTwistingEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblTwist__3214EC07D21E2992");

            entity.ToTable("TblTwistingEntry");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Entryby).HasMaxLength(100);
            entity.Property(e => e.GatePassNo).HasMaxLength(50);
            entity.Property(e => e.MixtureQnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderNumber).HasMaxLength(20);
            entity.Property(e => e.Rcptid).HasColumnName("RCPTId");
            entity.Property(e => e.Remarks).HasMaxLength(200);
            entity.Property(e => e.TwistIssueQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TwistRcptQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Updateby).HasMaxLength(100);
            entity.Property(e => e.VendarName).HasMaxLength(300);
        });

        modelBuilder.Entity<TblUnitMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UnitMaster");

            entity.ToTable("TblUnitMaster");

            entity.Property(e => e.Companycode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("companycode");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Decimalplace).HasColumnName("decimalplace");
            entity.Property(e => e.Fullname)
                .HasMaxLength(15)
                .HasColumnName("fullname");
            entity.Property(e => e.Symbol)
                .HasMaxLength(10)
                .HasColumnName("symbol");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TblUserAccee>(entity =>
        {
            entity.ToTable("tblUserAccees");

            entity.Property(e => e.AccessRightName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblUserDetail>(entity =>
        {
            entity.ToTable("TblUserDetail");

            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblUserMaster>(entity =>
        {
            entity.ToTable("tblUserMaster");

            entity.Property(e => e.Accounttype)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Companycode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Heading1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Heading2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LockoutEndTime).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Photo).IsUnicode(false);
            entity.Property(e => e.Secondname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SharedUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShortCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubOrdinate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ugroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UGroup");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblUserlog>(entity =>
        {
            entity.HasKey(e => e.Userlogid).HasName("PK__TblUserl__4052DA29478BEF87");

            entity.ToTable("TblUserlog");

            entity.Property(e => e.Activitydatetime)
                .HasColumnType("datetime")
                .HasColumnName("activitydatetime");
            entity.Property(e => e.Eventname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fieldname)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryFieldname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Smenu)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblVendarMonEntry>(entity =>
        {
            entity.ToTable("TblVendarMonEntry");

            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Designno).HasMaxLength(50);
            entity.Property(e => e.EntryBy).HasMaxLength(50);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.EntryType).HasMaxLength(20);
            entity.Property(e => e.FactIssueQnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GatePassNo).HasMaxLength(20);
            entity.Property(e => e.Material).HasMaxLength(100);
            entity.Property(e => e.OrderNumber).HasMaxLength(50);
            entity.Property(e => e.Prodate).HasColumnType("datetime");
            entity.Property(e => e.Purzano).HasMaxLength(50);
            entity.Property(e => e.QuantityFinal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivedFinal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shade).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDt).HasColumnType("datetime");
            entity.Property(e => e.VendarName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblVendarReceiveEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("TblVendarReceiveEntry");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Entryby).HasMaxLength(50);
            entity.Property(e => e.GetPassNo).HasMaxLength(20);
            entity.Property(e => e.IssueId).HasColumnName("issueId");
            entity.Property(e => e.LossQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderNo).HasMaxLength(50);
            entity.Property(e => e.ReturnQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Updateby).HasMaxLength(50);
            entity.Property(e => e.VendarIssueQnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VendarReceiveQnty).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblWinderMonEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TblWinde__3214EC0749E7802F");

            entity.ToTable("TblWinderMonEntry");

            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Designno).HasMaxLength(50);
            entity.Property(e => e.EntryBy).HasMaxLength(50);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.FactIssueQnty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("fact_issue_qnty");
            entity.Property(e => e.Material).HasMaxLength(100);
            entity.Property(e => e.OrderNumber).HasMaxLength(50);
            entity.Property(e => e.Prodate).HasColumnType("datetime");
            entity.Property(e => e.Purzano).HasMaxLength(50);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.QuantityFinal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceiveQnty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("receive_qnty");
            entity.Property(e => e.ReceivedFinal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.Shade).HasMaxLength(50);
            entity.Property(e => e.Shift)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Temp).HasDefaultValue(true);
            entity.Property(e => e.Unit).HasMaxLength(20);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDt).HasColumnType("datetime");
            entity.Property(e => e.WinderName)
                .HasMaxLength(100)
                .HasColumnName("Winder_Name");
        });

        modelBuilder.Entity<Tblbuyerdesigncolor>(entity =>
        {
            entity.ToTable("Tblbuyerdesigncolor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bno).HasMaxLength(55);
            entity.Property(e => e.Buyercode)
                .HasMaxLength(55)
                .HasColumnName("buyercode");
            entity.Property(e => e.Collection).HasMaxLength(255);
            entity.Property(e => e.Colour)
                .HasMaxLength(255)
                .HasColumnName("colour");
            entity.Property(e => e.Designno)
                .HasMaxLength(255)
                .HasColumnName("designno");
            entity.Property(e => e.EntryBy).HasMaxLength(150);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Iiibacking).HasColumnName("IIIBacking");
            entity.Property(e => e.Pdesign)
                .HasMaxLength(255)
                .HasColumnName("PDesign");
            entity.Property(e => e.Quality)
                .HasMaxLength(255)
                .HasColumnName("quality");
        });

        modelBuilder.Entity<TblbuyerdesigncolorOld>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Tblbuyerdesigncolor_1");

            entity.ToTable("Tblbuyerdesigncolor_old");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Binding).HasColumnName("binding");
            entity.Property(e => e.Bno).HasMaxLength(10);
            entity.Property(e => e.Buyercode)
                .HasMaxLength(10)
                .HasColumnName("buyercode");
            entity.Property(e => e.Clipping).HasColumnName("clipping");
            entity.Property(e => e.Cloth).HasColumnName("cloth");
            entity.Property(e => e.Clothnewar).HasColumnName("clothnewar");
            entity.Property(e => e.Collection).HasMaxLength(100);
            entity.Property(e => e.Colour)
                .HasMaxLength(40)
                .HasColumnName("colour");
            entity.Property(e => e.Designno)
                .HasMaxLength(40)
                .HasColumnName("designno");
            entity.Property(e => e.Finishing).HasColumnName("finishing");
            entity.Property(e => e.Latexing).HasColumnName("latexing");
            entity.Property(e => e.Newar).HasColumnName("newar");
            entity.Property(e => e.Quality)
                .HasMaxLength(35)
                .HasColumnName("quality");
            entity.Property(e => e.Streching).HasColumnName("streching");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .HasColumnName("type");
            entity.Property(e => e.Viscose).HasColumnName("viscose");
            entity.Property(e => e.Washing).HasColumnName("washing");
            entity.Property(e => e.Wool).HasColumnName("wool");
        });

        modelBuilder.Entity<Tblchat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblchat__3214EC07153D940E");

            entity.ToTable("tblchat");

            entity.Property(e => e.ChatDate).HasColumnType("datetime");
            entity.Property(e => e.RattachDoc)
                .IsUnicode(false)
                .HasColumnName("RAttachDoc");
            entity.Property(e => e.ReceiverChat).IsUnicode(false);
            entity.Property(e => e.ReceiverName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SattachDoc)
                .IsUnicode(false)
                .HasColumnName("SAttachDoc");
            entity.Property(e => e.SenderChat).IsUnicode(false);
            entity.Property(e => e.SenderName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblcountPcsMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tblcount__3214EC0776308BB6");

            entity.ToTable("TblcountPcs_mst");

            entity.Property(e => e.PieceSrNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SrNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sr_No");
        });

        modelBuilder.Entity<TblorderqntyProcess>(entity =>
        {
            entity.ToTable("TblorderqntyProcess");

            entity.Property(e => e.Cdate).HasColumnName("CDate");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblwindingRateLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tblwindi__3214EC07D44FEEA8");

            entity.ToTable("TblwindingRateLog");

            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.ApprovedDt).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.DocType).HasMaxLength(50);
            entity.Property(e => e.EntryBy).HasMaxLength(50);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Material).HasMaxLength(100);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(250);
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblwindingRateMst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tblwindi__3214EC07949588EF");

            entity.ToTable("TblwindingRateMst");

            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.ApprovedDt).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.DocType).HasMaxLength(50);
            entity.Property(e => e.Material).HasMaxLength(100);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remarks).HasMaxLength(250);
        });

        modelBuilder.Entity<Vendarmaster>(entity =>
        {
            entity.ToTable("Vendarmaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SecondName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unit)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Winder>(entity =>
        {
            entity.ToTable("Winder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EntryDt).HasColumnType("datetime");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDt).HasColumnType("datetime");
        });

        modelBuilder.Entity<WinderShiftMaster>(entity =>
        {
            entity.ToTable("WinderShiftMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ShifToTime)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ShiftFromTime)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ShiftHrs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShiftName)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
