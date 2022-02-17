using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace punto_venta.Models
{
    public partial class db_a81d65_bitzerobdContext : DbContext
    {
        public db_a81d65_bitzerobdContext()
        {
        }

        public db_a81d65_bitzerobdContext(DbContextOptions<db_a81d65_bitzerobdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CAccessprivilege> CAccessprivileges { get; set; }
        public virtual DbSet<CAccessprivilegetype> CAccessprivilegetypes { get; set; }
        public virtual DbSet<CCashmovementstatus> CCashmovementstatuses { get; set; }
        public virtual DbSet<CCashtype> CCashtypes { get; set; }
        public virtual DbSet<CCreditnotestatus> CCreditnotestatuses { get; set; }
        public virtual DbSet<CCustomertype> CCustomertypes { get; set; }
        public virtual DbSet<CDocumenttype> CDocumenttypes { get; set; }
        public virtual DbSet<CEnterprise> CEnterprises { get; set; }
        public virtual DbSet<CEnterprisebranch> CEnterprisebranches { get; set; }
        public virtual DbSet<CEnterprisebranchcash> CEnterprisebranchcashes { get; set; }
        public virtual DbSet<CEnterprisebranchproduct> CEnterprisebranchproducts { get; set; }
        public virtual DbSet<CEnterprisebranchuser> CEnterprisebranchusers { get; set; }
        public virtual DbSet<CEnterprisebranchuseraccessprivilege> CEnterprisebranchuseraccessprivileges { get; set; }
        public virtual DbSet<CEnterprisebusinesscustomer> CEnterprisebusinesscustomers { get; set; }
        public virtual DbSet<CEnterprisebusinessprovider> CEnterprisebusinessproviders { get; set; }
        public virtual DbSet<CEnterprisecustomer> CEnterprisecustomers { get; set; }
        public virtual DbSet<CEnterpriseindividualcustomer> CEnterpriseindividualcustomers { get; set; }
        public virtual DbSet<CEnterpriseindividualprovider> CEnterpriseindividualproviders { get; set; }
        public virtual DbSet<CEnterpriseproduct> CEnterpriseproducts { get; set; }
        public virtual DbSet<CEnterpriseprovider> CEnterpriseproviders { get; set; }
        public virtual DbSet<CMunicipality> CMunicipalities { get; set; }
        public virtual DbSet<COutputtype> COutputtypes { get; set; }
        public virtual DbSet<CPasswordresetstatus> CPasswordresetstatuses { get; set; }
        public virtual DbSet<CPaymentmethod> CPaymentmethods { get; set; }
        public virtual DbSet<CPaymentstatus> CPaymentstatuses { get; set; }
        public virtual DbSet<CPaymenttype> CPaymenttypes { get; set; }
        public virtual DbSet<CPersontype> CPersontypes { get; set; }
        public virtual DbSet<CProductmeasureunit> CProductmeasureunits { get; set; }
        public virtual DbSet<CProducttype> CProducttypes { get; set; }
        public virtual DbSet<CSalestatus> CSalestatuses { get; set; }
        public virtual DbSet<CState> CStates { get; set; }
        public virtual DbSet<CTransferstatus> CTransferstatuses { get; set; }
        public virtual DbSet<CTransfertype> CTransfertypes { get; set; }
        public virtual DbSet<CUsecfdi> CUsecfdis { get; set; }
        public virtual DbSet<CUser> CUsers { get; set; }
        public virtual DbSet<CUserstatus> CUserstatuses { get; set; }
        public virtual DbSet<CUsertype> CUsertypes { get; set; }
        public virtual DbSet<PEnterprisebranchcashcount> PEnterprisebranchcashcounts { get; set; }
        public virtual DbSet<PEnterprisebranchcashcountcash> PEnterprisebranchcashcountcashes { get; set; }
        public virtual DbSet<PEnterprisebranchcashcountdocument> PEnterprisebranchcashcountdocuments { get; set; }
        public virtual DbSet<PEnterprisebranchcashmovement> PEnterprisebranchcashmovements { get; set; }
        public virtual DbSet<PEnterprisebranchoutput> PEnterprisebranchoutputs { get; set; }
        public virtual DbSet<PEnterprisebranchoutputproduct> PEnterprisebranchoutputproducts { get; set; }
        public virtual DbSet<PEnterprisebranchpurchase> PEnterprisebranchpurchases { get; set; }
        public virtual DbSet<PEnterprisebranchpurchasedetail> PEnterprisebranchpurchasedetails { get; set; }
        public virtual DbSet<PEnterprisebranchquote> PEnterprisebranchquotes { get; set; }
        public virtual DbSet<PEnterprisebranchquoteproduct> PEnterprisebranchquoteproducts { get; set; }
        public virtual DbSet<PEnterprisebranchsale> PEnterprisebranchsales { get; set; }
        public virtual DbSet<PEnterprisebranchsaledelivery> PEnterprisebranchsaledeliveries { get; set; }
        public virtual DbSet<PEnterprisebranchsalepayment> PEnterprisebranchsalepayments { get; set; }
        public virtual DbSet<PEnterprisebranchsaleproduct> PEnterprisebranchsaleproducts { get; set; }
        public virtual DbSet<PEnterprisecreditnote> PEnterprisecreditnotes { get; set; }
        public virtual DbSet<PEnterprisetransfer> PEnterprisetransfers { get; set; }
        public virtual DbSet<PEnterprisetransferproduct> PEnterprisetransferproducts { get; set; }
        public virtual DbSet<PPasswordreset> PPasswordresets { get; set; }
        public virtual DbSet<sp_InsertUser> Sp_InsertUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=sql5097.site4now.net;Database=db_a81d65_bitzerobd;user=db_a81d65_bitzerobd_admin;password=Bitzerodb14");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CAccessprivilege>(entity =>
            {
                entity.HasKey(e => e.IdAccessPrivilege)
                    .HasName("PK_c_accessprivilege_id_accessPrivilege");

                entity.ToTable("c_accessprivilege");

                entity.Property(e => e.IdAccessPrivilege)
                    .ValueGeneratedNever()
                    .HasColumnName("id_accessPrivilege");

                entity.Property(e => e.FldaccessPrivilege)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fldaccessPrivilege");

                entity.Property(e => e.FldiconName)
                    .HasMaxLength(30)
                    .HasColumnName("fldiconName");

                entity.Property(e => e.Fldlevel1)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("fldlevel1")
                    .HasDefaultValueSql("(N'00')");

                entity.Property(e => e.Fldlevel2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("fldlevel2")
                    .HasDefaultValueSql("(N'00')");

                entity.Property(e => e.Fldlevel3)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("fldlevel3")
                    .HasDefaultValueSql("(N'00')");

                entity.Property(e => e.Fldlevel4)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("fldlevel4")
                    .HasDefaultValueSql("(N'00')");

                entity.Property(e => e.Fldurl)
                    .HasMaxLength(255)
                    .HasColumnName("fldurl");

                entity.Property(e => e.IdAccessPrivilegeType).HasColumnName("id_accessPrivilegeType");

                entity.HasOne(d => d.IdAccessPrivilegeTypeNavigation)
                    .WithMany(p => p.CAccessprivileges)
                    .HasForeignKey(d => d.IdAccessPrivilegeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_accessprivilege$c_accessPrivilege_fk01");
            });

            modelBuilder.Entity<CAccessprivilegetype>(entity =>
            {
                entity.HasKey(e => e.IdAccessPrivilegeType)
                    .HasName("PK_c_accessprivilegetype_id_accessPrivilegeType");

                entity.ToTable("c_accessprivilegetype");

                entity.Property(e => e.IdAccessPrivilegeType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_accessPrivilegeType");

                entity.Property(e => e.FldaccessPrivilegeType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldaccessPrivilegeType");
            });

            modelBuilder.Entity<CCashmovementstatus>(entity =>
            {
                entity.HasKey(e => e.IdCashMovementStatus)
                    .HasName("PK_c_cashmovementstatus_id_cashMovementStatus");

                entity.ToTable("c_cashmovementstatus");

                entity.Property(e => e.IdCashMovementStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("id_cashMovementStatus");

                entity.Property(e => e.FldcashMovementStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldcashMovementStatus");
            });

            modelBuilder.Entity<CCashtype>(entity =>
            {
                entity.HasKey(e => e.IdCashType)
                    .HasName("PK_c_cashtype_id_cashType");

                entity.ToTable("c_cashtype");

                entity.Property(e => e.IdCashType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_cashType");

                entity.Property(e => e.FldcashType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldcashType");
            });

            modelBuilder.Entity<CCreditnotestatus>(entity =>
            {
                entity.HasKey(e => e.IdCreditNoteStatus)
                    .HasName("PK_c_creditnotestatus_id_creditNoteStatus");

                entity.ToTable("c_creditnotestatus");

                entity.Property(e => e.IdCreditNoteStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("id_creditNoteStatus");

                entity.Property(e => e.FldcreditNoteStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldcreditNoteStatus");
            });

            modelBuilder.Entity<CCustomertype>(entity =>
            {
                entity.HasKey(e => e.IdCustomerType)
                    .HasName("PK_c_customertype_id_customerType");

                entity.ToTable("c_customertype");

                entity.Property(e => e.IdCustomerType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_customerType");

                entity.Property(e => e.FldcustomerType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldcustomerType");
            });

            modelBuilder.Entity<CDocumenttype>(entity =>
            {
                entity.HasKey(e => e.IdDocumentType)
                    .HasName("PK_c_documenttype_id_documentType");

                entity.ToTable("c_documenttype");

                entity.Property(e => e.IdDocumentType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_documentType");

                entity.Property(e => e.FlddocumentType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("flddocumentType");
            });

            modelBuilder.Entity<CEnterprise>(entity =>
            {
                entity.HasKey(e => e.IdEnterprise)
                    .HasName("PK_c_enterprise_id_enterprise");

                entity.ToTable("c_enterprise");

                entity.Property(e => e.IdEnterprise)
                    .ValueGeneratedNever()
                    .HasColumnName("id_enterprise");

                entity.Property(e => e.Fldemail)
                    .HasMaxLength(50)
                    .HasColumnName("fldemail");

                entity.Property(e => e.Fldlocality)
                    .IsRequired()
                    .HasColumnName("fldlocality");

                entity.Property(e => e.Fldname)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("fldname");

                entity.Property(e => e.Fldnumber)
                    .IsRequired()
                    .HasColumnName("fldnumber");

                entity.Property(e => e.FldpageWeb)
                    .HasMaxLength(255)
                    .HasColumnName("fldpageWeb");

                entity.Property(e => e.FldphoneNumber)
                    .IsRequired()
                    .HasColumnName("fldphoneNumber");

                entity.Property(e => e.FldpostCode)
                    .IsRequired()
                    .HasColumnName("fldpostCode");

                entity.Property(e => e.Fldstreet)
                    .IsRequired()
                    .HasColumnName("fldstreet");

                entity.Property(e => e.IdMunicipality).HasColumnName("id_municipality");

                entity.Property(e => e.IdState).HasColumnName("id_state");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.CEnterprises)
                    .HasForeignKey(d => new { d.IdState, d.IdMunicipality })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprise$c_enterprise_fk01");
            });

            modelBuilder.Entity<CEnterprisebranch>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch })
                    .HasName("PK_c_enterprisebranch_id_enterprise");

                entity.ToTable("c_enterprisebranch");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.Fldemail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fldemail");

                entity.Property(e => e.FldfiscalName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("fldfiscalName");

                entity.Property(e => e.Fldhomoclave)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("fldhomoclave");

                entity.Property(e => e.Fldlocality)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("fldlocality");

                entity.Property(e => e.FldmovilNumber)
                    .HasMaxLength(13)
                    .HasColumnName("fldmovilNumber");

                entity.Property(e => e.Fldname)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("fldname");

                entity.Property(e => e.Fldnumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("fldnumber");

                entity.Property(e => e.FldpasswordFiel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldpasswordFiel");

                entity.Property(e => e.FldpasswordInvoice)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldpasswordInvoice");

                entity.Property(e => e.FldphoneNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldphoneNumber");

                entity.Property(e => e.FldpostCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("fldpostCode");

                entity.Property(e => e.Fldrfc)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("fldrfc");

                entity.Property(e => e.Fldstreet)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("fldstreet");

                entity.Property(e => e.IdMunicipality).HasColumnName("id_municipality");

                entity.Property(e => e.IdState).HasColumnName("id_state");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.CEnterprisebranches)
                    .HasForeignKey(d => d.IdEnterprise)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebranch$c_enterpriseBranch_fk01");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.CEnterprisebranches)
                    .HasForeignKey(d => new { d.IdState, d.IdMunicipality })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebranch$c_enterpriseBranch_fk02");
            });

            modelBuilder.Entity<CEnterprisebranchcash>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchCash })
                    .HasName("PK_c_enterprisebranchcash_id_enterprise");

                entity.ToTable("c_enterprisebranchcash");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchCash).HasColumnName("id_enterpriseBranchCash");

                entity.Property(e => e.Fldname)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("fldname");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.CEnterprisebranchcashes)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebranchcash$c_enterpriseBranchCash_fk01");
            });

            modelBuilder.Entity<CEnterprisebranchproduct>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseProduct })
                    .HasName("PK_c_enterprisebranchproduct_id_enterprise");

                entity.ToTable("c_enterprisebranchproduct");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseProduct).HasColumnName("id_enterpriseProduct");

                entity.Property(e => e.FldmaximumStock)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldmaximumStock")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FldminimumStock)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldminimumStock")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FldretailSellingPrice).HasColumnName("fldretailSellingPrice");

                entity.Property(e => e.Fldstock)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldstock")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FldwholesaleSellingPrice).HasColumnName("fldwholesaleSellingPrice");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.CEnterprisebranchproducts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebranchproduct$c_enterpriseBranchProduct_fk01");

                entity.HasOne(d => d.IdEnterprise1)
                    .WithMany(p => p.CEnterprisebranchproducts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseProduct })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebranchproduct$c_enterpriseBranchProduct_fk02");
            });

            modelBuilder.Entity<CEnterprisebranchuser>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK_c_enterprisebranchuser_id_user");

                entity.ToTable("c_enterprisebranchuser");

                entity.Property(e => e.IdUser)
                    .ValueGeneratedNever()
                    .HasColumnName("id_user");

                entity.Property(e => e.Fldworkstation)
                    .HasMaxLength(80)
                    .HasColumnName("fldworkstation");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithOne(p => p.CEnterprisebranchuser)
                    .HasForeignKey<CEnterprisebranchuser>(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebranchuser$c_enterpriseBranchUser_fk01");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.CEnterprisebranchusers)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebranchuser$c_enterpriseBranchUser_fk02");
            });

            modelBuilder.Entity<CEnterprisebranchuseraccessprivilege>(entity =>
            {
                entity.HasKey(e => new { e.IdUser, e.IdAccessPrivilege })
                    .HasName("PK_c_enterprisebranchuseraccessprivilege_id_user");

                entity.ToTable("c_enterprisebranchuseraccessprivilege");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IdAccessPrivilege).HasColumnName("id_accessPrivilege");

                entity.HasOne(d => d.IdAccessPrivilegeNavigation)
                    .WithMany(p => p.CEnterprisebranchuseraccessprivileges)
                    .HasForeignKey(d => d.IdAccessPrivilege)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebranchuseraccessprivilege$c_enterpriseBranchUserAccessPrivilege_fk02");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.CEnterprisebranchuseraccessprivileges)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebranchuseraccessprivilege$c_enterpriseBranchUserAccessPrivilege_fk01");
            });

            modelBuilder.Entity<CEnterprisebusinesscustomer>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseCustomer })
                    .HasName("PK_c_enterprisebusinesscustomer_id_enterprise");

                entity.ToTable("c_enterprisebusinesscustomer");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseCustomer).HasColumnName("id_enterpriseCustomer");

                entity.Property(e => e.FldbusinessName)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("fldbusinessName");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithOne(p => p.CEnterprisebusinesscustomer)
                    .HasForeignKey<CEnterprisebusinesscustomer>(d => new { d.IdEnterprise, d.IdEnterpriseCustomer })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebusinesscustomer$c_enterpiseBusinessCustomer_fk01");
            });

            modelBuilder.Entity<CEnterprisebusinessprovider>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseProvider })
                    .HasName("PK_c_enterprisebusinessprovider_id_enterprise");

                entity.ToTable("c_enterprisebusinessprovider");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseProvider).HasColumnName("id_enterpriseProvider");

                entity.Property(e => e.FldbusinessName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("fldbusinessName");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithOne(p => p.CEnterprisebusinessprovider)
                    .HasForeignKey<CEnterprisebusinessprovider>(d => new { d.IdEnterprise, d.IdEnterpriseProvider })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisebusinessprovider$c_enterpriseBusinessProvider_fk01");
            });

            modelBuilder.Entity<CEnterprisecustomer>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseCustomer })
                    .HasName("PK_c_enterprisecustomer_id_enterprise");

                entity.ToTable("c_enterprisecustomer");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseCustomer).HasColumnName("id_enterpriseCustomer");

                entity.Property(e => e.Fldactive)
                    .HasColumnName("fldactive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fldemail)
                    .HasMaxLength(50)
                    .HasColumnName("fldemail");

                entity.Property(e => e.Fldhomoclave)
                    .HasMaxLength(3)
                    .HasColumnName("fldhomoclave");

                entity.Property(e => e.Fldkey)
                    .HasMaxLength(10)
                    .HasColumnName("fldkey");

                entity.Property(e => e.Fldlocality)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("fldlocality");

                entity.Property(e => e.Fldnumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("fldnumber");

                entity.Property(e => e.FldphoneNumber)
                    .HasMaxLength(12)
                    .HasColumnName("fldphoneNumber");

                entity.Property(e => e.FldpostCode)
                    .HasMaxLength(5)
                    .HasColumnName("fldpostCode");

                entity.Property(e => e.Fldrfc)
                    .HasMaxLength(10)
                    .HasColumnName("fldrfc");

                entity.Property(e => e.Fldstreet)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("fldstreet");

                entity.Property(e => e.IdCustomerType).HasColumnName("id_customerType");

                entity.Property(e => e.IdMunicipality).HasColumnName("id_municipality");

                entity.Property(e => e.IdPersonType).HasColumnName("id_personType");

                entity.Property(e => e.IdState).HasColumnName("id_state");

                entity.HasOne(d => d.IdCustomerTypeNavigation)
                    .WithMany(p => p.CEnterprisecustomers)
                    .HasForeignKey(d => d.IdCustomerType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisecustomer$c_enterpriseCustomer_fk03");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.CEnterprisecustomers)
                    .HasForeignKey(d => d.IdEnterprise)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisecustomer$c_enterpriseCustomer_fk01");

                entity.HasOne(d => d.IdPersonTypeNavigation)
                    .WithMany(p => p.CEnterprisecustomers)
                    .HasForeignKey(d => d.IdPersonType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisecustomer$c_enterpriseCustomer_fk02");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.CEnterprisecustomers)
                    .HasForeignKey(d => new { d.IdState, d.IdMunicipality })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterprisecustomer$c_enterpriseCustomer_fk04");
            });

            modelBuilder.Entity<CEnterpriseindividualcustomer>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseCustomer })
                    .HasName("PK_c_enterpriseindividualcustomer_id_enterprise");

                entity.ToTable("c_enterpriseindividualcustomer");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseCustomer).HasColumnName("id_enterpriseCustomer");

                entity.Property(e => e.FldfirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldfirstName");

                entity.Property(e => e.FldlastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldlastName");

                entity.Property(e => e.Fldname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldname");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithOne(p => p.CEnterpriseindividualcustomer)
                    .HasForeignKey<CEnterpriseindividualcustomer>(d => new { d.IdEnterprise, d.IdEnterpriseCustomer })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterpriseindividualcustomer$c_enterpriseIndividualCustomer_fk01");
            });

            modelBuilder.Entity<CEnterpriseindividualprovider>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseProvider })
                    .HasName("PK_c_enterpriseindividualprovider_id_enterprise");

                entity.ToTable("c_enterpriseindividualprovider");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseProvider).HasColumnName("id_enterpriseProvider");

                entity.Property(e => e.FldfirstName)
                    .HasMaxLength(30)
                    .HasColumnName("fldfirstName");

                entity.Property(e => e.FldlastName)
                    .HasMaxLength(30)
                    .HasColumnName("fldlastName");

                entity.Property(e => e.Fldname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldname");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithOne(p => p.CEnterpriseindividualprovider)
                    .HasForeignKey<CEnterpriseindividualprovider>(d => new { d.IdEnterprise, d.IdEnterpriseProvider })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterpriseindividualprovider$c_enterpriseIndividualProvider_fk01");
            });

            modelBuilder.Entity<CEnterpriseproduct>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseProduct })
                    .HasName("PK_c_enterpriseproduct_id_enterprise");

                entity.ToTable("c_enterpriseproduct");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseProduct).HasColumnName("id_enterpriseProduct");

                entity.Property(e => e.Fldactive)
                    .HasColumnName("fldactive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Flddescription).HasColumnName("flddescription");

                entity.Property(e => e.Fldimage)
                    .HasMaxLength(20)
                    .HasColumnName("fldimage");

                entity.Property(e => e.Fldkey)
                    .HasMaxLength(10)
                    .HasColumnName("fldkey");

                entity.Property(e => e.FldkeySat)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("fldkeySAT");

                entity.Property(e => e.Fldname)
                    .IsRequired()
                    .HasColumnName("fldname");

                entity.Property(e => e.IdProductMeasureUnit).HasColumnName("id_productMeasureUnit");

                entity.Property(e => e.IdProductType).HasColumnName("id_productType");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.CEnterpriseproducts)
                    .HasForeignKey(d => d.IdEnterprise)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterpriseproduct$c_enterpriseProduct_fk01");

                entity.HasOne(d => d.IdProductMeasureUnitNavigation)
                    .WithMany(p => p.CEnterpriseproducts)
                    .HasForeignKey(d => d.IdProductMeasureUnit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterpriseproduct$c_enterpriseProduct_fk03");

                entity.HasOne(d => d.IdProductTypeNavigation)
                    .WithMany(p => p.CEnterpriseproducts)
                    .HasForeignKey(d => d.IdProductType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterpriseproduct$c_enterpriseProduct_fk02");
            });

            modelBuilder.Entity<CEnterpriseprovider>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseProvider })
                    .HasName("PK_c_enterpriseprovider_id_enterprise");

                entity.ToTable("c_enterpriseprovider");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseProvider).HasColumnName("id_enterpriseProvider");

                entity.Property(e => e.Fldactive)
                    .HasColumnName("fldactive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fldemail)
                    .HasMaxLength(50)
                    .HasColumnName("fldemail");

                entity.Property(e => e.Fldhomoclave)
                    .HasMaxLength(3)
                    .HasColumnName("fldhomoclave");

                entity.Property(e => e.Fldkey)
                    .HasMaxLength(10)
                    .HasColumnName("fldkey");

                entity.Property(e => e.Fldlocality)
                    .HasMaxLength(80)
                    .HasColumnName("fldlocality");

                entity.Property(e => e.Fldnumber)
                    .HasMaxLength(10)
                    .HasColumnName("fldnumber");

                entity.Property(e => e.FldphoneNumber)
                    .HasMaxLength(12)
                    .HasColumnName("fldphoneNumber");

                entity.Property(e => e.FldpostCode)
                    .HasMaxLength(5)
                    .HasColumnName("fldpostCode");

                entity.Property(e => e.Fldrfc)
                    .HasMaxLength(10)
                    .HasColumnName("fldrfc");

                entity.Property(e => e.Fldstreet)
                    .HasMaxLength(80)
                    .HasColumnName("fldstreet");

                entity.Property(e => e.IdMunicipality).HasColumnName("id_municipality");

                entity.Property(e => e.IdPersonType).HasColumnName("id_personType");

                entity.Property(e => e.IdState).HasColumnName("id_state");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.CEnterpriseproviders)
                    .HasForeignKey(d => d.IdEnterprise)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterpriseprovider$c_enterpriseProvider_fk01");

                entity.HasOne(d => d.IdPersonTypeNavigation)
                    .WithMany(p => p.CEnterpriseproviders)
                    .HasForeignKey(d => d.IdPersonType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterpriseprovider$c_enterpriseProvider_fk02");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.CEnterpriseproviders)
                    .HasForeignKey(d => new { d.IdState, d.IdMunicipality })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_enterpriseprovider$c_enterpriseProvider_fk03");
            });

            modelBuilder.Entity<CMunicipality>(entity =>
            {
                entity.HasKey(e => new { e.IdState, e.IdMunicipality })
                    .HasName("PK_c_municipality_id_state");

                entity.ToTable("c_municipality");

                entity.Property(e => e.IdState).HasColumnName("id_state");

                entity.Property(e => e.IdMunicipality).HasColumnName("id_municipality");

                entity.Property(e => e.Fldmunicipality)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fldmunicipality");

                entity.HasOne(d => d.IdStateNavigation)
                    .WithMany(p => p.CMunicipalities)
                    .HasForeignKey(d => d.IdState)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_municipality$c_municipality_fk01");
            });

            modelBuilder.Entity<COutputtype>(entity =>
            {
                entity.HasKey(e => e.IdOutputType)
                    .HasName("PK_c_outputtype_id_outputType");

                entity.ToTable("c_outputtype");

                entity.Property(e => e.IdOutputType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_outputType");

                entity.Property(e => e.FldoutputType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldoutputType");
            });

            modelBuilder.Entity<CPasswordresetstatus>(entity =>
            {
                entity.HasKey(e => e.IdPasswordResetStatus)
                    .HasName("PK_c_passwordresetstatus_id_passwordResetStatus");

                entity.ToTable("c_passwordresetstatus");

                entity.Property(e => e.IdPasswordResetStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("id_passwordResetStatus");

                entity.Property(e => e.FldpasswordResetStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldpasswordResetStatus");
            });

            modelBuilder.Entity<CPaymentmethod>(entity =>
            {
                entity.HasKey(e => e.IdPaymentMethod)
                    .HasName("PK_c_paymentmethod_id_paymentMethod");

                entity.ToTable("c_paymentmethod");

                entity.Property(e => e.IdPaymentMethod)
                    .ValueGeneratedNever()
                    .HasColumnName("id_paymentMethod");

                entity.Property(e => e.Fldkey)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("fldkey");

                entity.Property(e => e.FldpaymentMethod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fldpaymentMethod");
            });

            modelBuilder.Entity<CPaymentstatus>(entity =>
            {
                entity.HasKey(e => e.IdPaymentStatus)
                    .HasName("PK_c_paymentstatus_id_paymentStatus");

                entity.ToTable("c_paymentstatus");

                entity.Property(e => e.IdPaymentStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("id_paymentStatus");

                entity.Property(e => e.FldpaymentStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldpaymentStatus");
            });

            modelBuilder.Entity<CPaymenttype>(entity =>
            {
                entity.HasKey(e => e.IdPaymentType)
                    .HasName("PK_c_paymenttype_id_paymentType");

                entity.ToTable("c_paymenttype");

                entity.Property(e => e.IdPaymentType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_paymentType");

                entity.Property(e => e.Fldkey)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("fldkey");

                entity.Property(e => e.FldpaymentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fldpaymentType");
            });

            modelBuilder.Entity<CPersontype>(entity =>
            {
                entity.HasKey(e => e.IdPersonType)
                    .HasName("PK_c_persontype_id_personType");

                entity.ToTable("c_persontype");

                entity.Property(e => e.IdPersonType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_personType");

                entity.Property(e => e.FldpersonType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldpersonType");
            });

            modelBuilder.Entity<CProductmeasureunit>(entity =>
            {
                entity.HasKey(e => e.IdProductMeasureUnit)
                    .HasName("PK_c_productmeasureunit_id_productMeasureUnit");

                entity.ToTable("c_productmeasureunit");

                entity.Property(e => e.IdProductMeasureUnit)
                    .ValueGeneratedNever()
                    .HasColumnName("id_productMeasureUnit");

                entity.Property(e => e.FldproductMeasureUnit)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldproductMeasureUnit");

                entity.Property(e => e.FldunitKeySat)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("fldunitKeySAT");
            });

            modelBuilder.Entity<CProducttype>(entity =>
            {
                entity.HasKey(e => e.IdProductType)
                    .HasName("PK_c_producttype_id_productType");

                entity.ToTable("c_producttype");

                entity.Property(e => e.IdProductType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_productType");

                entity.Property(e => e.FldproductType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldproductType");
            });

            modelBuilder.Entity<CSalestatus>(entity =>
            {
                entity.HasKey(e => e.IdSaleStatus)
                    .HasName("PK_c_salestatus_id_saleStatus");

                entity.ToTable("c_salestatus");

                entity.Property(e => e.IdSaleStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("id_saleStatus");

                entity.Property(e => e.FldsaleStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fldsaleStatus");
            });

            modelBuilder.Entity<CState>(entity =>
            {
                entity.HasKey(e => e.IdState)
                    .HasName("PK_c_state_id_state");

                entity.ToTable("c_state");

                entity.Property(e => e.IdState)
                    .ValueGeneratedNever()
                    .HasColumnName("id_state");

                entity.Property(e => e.Fldstate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fldstate");
            });

            modelBuilder.Entity<CTransferstatus>(entity =>
            {
                entity.HasKey(e => e.IdTransferStatus)
                    .HasName("PK_c_transferstatus_id_transferStatus");

                entity.ToTable("c_transferstatus");

                entity.Property(e => e.IdTransferStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("id_transferStatus");

                entity.Property(e => e.FldtransferStatus)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldtransferStatus");
            });

            modelBuilder.Entity<CTransfertype>(entity =>
            {
                entity.HasKey(e => e.IdTransferType)
                    .HasName("PK_c_transfertype_id_transferType");

                entity.ToTable("c_transfertype");

                entity.Property(e => e.IdTransferType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_transferType");

                entity.Property(e => e.FldtransferType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldtransferType");
            });

            modelBuilder.Entity<CUsecfdi>(entity =>
            {
                entity.HasKey(e => e.IdUseCfdi)
                    .HasName("PK_c_usecfdi_id_useCFDI");

                entity.ToTable("c_usecfdi");

                entity.Property(e => e.IdUseCfdi)
                    .ValueGeneratedNever()
                    .HasColumnName("id_useCFDI");

                entity.Property(e => e.FldbusinessPerson).HasColumnName("fldbusinessPerson");

                entity.Property(e => e.FldindividualPerson).HasColumnName("fldindividualPerson");

                entity.Property(e => e.Fldkey)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("fldkey");

                entity.Property(e => e.FlduseCfdi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("flduseCFDI");
            });

            modelBuilder.Entity<CUser>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK_c_user_id_user");

                entity.ToTable("c_user");

                entity.Property(e => e.IdUser)
                    .ValueGeneratedNever()
                    .HasColumnName("id_user");

                entity.Property(e => e.FldemailAccount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fldemailAccount");

                entity.Property(e => e.FldfirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldfirstName");

                entity.Property(e => e.FldlastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldlastName");

                entity.Property(e => e.Fldname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("fldname");

                entity.Property(e => e.Fldpassword)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("fldpassword");

                entity.Property(e => e.IdUserStatus).HasColumnName("id_userStatus");

                entity.Property(e => e.IdUserType).HasColumnName("id_userType");

                entity.HasOne(d => d.IdUserStatusNavigation)
                    .WithMany(p => p.CUsers)
                    .HasForeignKey(d => d.IdUserStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_user$c_user_fk02");

                entity.HasOne(d => d.IdUserTypeNavigation)
                    .WithMany(p => p.CUsers)
                    .HasForeignKey(d => d.IdUserType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("c_user$c_user_fk01");
            });

            modelBuilder.Entity<CUserstatus>(entity =>
            {
                entity.HasKey(e => e.IdUserStatus)
                    .HasName("PK_c_userstatus_id_userStatus");

                entity.ToTable("c_userstatus");

                entity.Property(e => e.IdUserStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("id_userStatus");

                entity.Property(e => e.FlduserStatus)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("flduserStatus");
            });

            modelBuilder.Entity<CUsertype>(entity =>
            {
                entity.HasKey(e => e.IdUserType)
                    .HasName("PK_c_usertype_id_userType");

                entity.ToTable("c_usertype");

                entity.Property(e => e.IdUserType)
                    .ValueGeneratedNever()
                    .HasColumnName("id_userType");

                entity.Property(e => e.FlduserType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("flduserType");
            });

            modelBuilder.Entity<PEnterprisebranchcashcount>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchCash, e.IdEnterpriseBranchCashCount })
                    .HasName("PK_p_enterprisebranchcashcount_id_enterprise");

                entity.ToTable("p_enterprisebranchcashcount");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchCash).HasColumnName("id_enterpriseBranchCash");

                entity.Property(e => e.IdEnterpriseBranchCashCount).HasColumnName("id_enterpriseBranchCashCount");

                entity.Property(e => e.Fldobservation).HasColumnName("fldobservation");

                entity.Property(e => e.FldrecordDate)
                    .HasPrecision(0)
                    .HasColumnName("fldrecordDate");

                entity.Property(e => e.IdUserAuditor).HasColumnName("id_userAuditor");

                entity.Property(e => e.IdUserCashier).HasColumnName("id_userCashier");

                entity.HasOne(d => d.IdUserAuditorNavigation)
                    .WithMany(p => p.PEnterprisebranchcashcountIdUserAuditorNavigations)
                    .HasForeignKey(d => d.IdUserAuditor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchcashcount$p_enterpriseBranchCashCount_fk02");

                entity.HasOne(d => d.IdUserCashierNavigation)
                    .WithMany(p => p.PEnterprisebranchcashcountIdUserCashierNavigations)
                    .HasForeignKey(d => d.IdUserCashier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchcashcount$p_enterpriseBranchCashCount_fk03");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchcashcounts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseBranchCash })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchcashcount$p_enterpriseBranchCashCount_fk01");
            });

            modelBuilder.Entity<PEnterprisebranchcashcountcash>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchCash, e.IdEnterpriseBranchCashCount, e.IdEnterpriseBranchCashCountCash })
                    .HasName("PK_p_enterprisebranchcashcountcash_id_enterprise");

                entity.ToTable("p_enterprisebranchcashcountcash");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchCash).HasColumnName("id_enterpriseBranchCash");

                entity.Property(e => e.IdEnterpriseBranchCashCount).HasColumnName("id_enterpriseBranchCashCount");

                entity.Property(e => e.IdEnterpriseBranchCashCountCash).HasColumnName("id_enterpriseBranchCashCountCash");

                entity.Property(e => e.Fldamount).HasColumnName("fldamount");

                entity.Property(e => e.Fldvalue)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldvalue")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.IdCashType).HasColumnName("id_cashType");

                entity.HasOne(d => d.IdCashTypeNavigation)
                    .WithMany(p => p.PEnterprisebranchcashcountcashes)
                    .HasForeignKey(d => d.IdCashType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchcashcountcash$p_enterpriseBranchCashCountCash_fk02");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchcashcountcashes)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseBranchCash, d.IdEnterpriseBranchCashCount })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchcashcountcash$p_enterpriseBranchCashCountCash_fk01");
            });

            modelBuilder.Entity<PEnterprisebranchcashcountdocument>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchCash, e.IdEnterpriseBranchCashCount, e.IdEnterpriseBranchCashCountDocument })
                    .HasName("PK_p_enterprisebranchcashcountdocument_id_enterprise");

                entity.ToTable("p_enterprisebranchcashcountdocument");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchCash).HasColumnName("id_enterpriseBranchCash");

                entity.Property(e => e.IdEnterpriseBranchCashCount).HasColumnName("id_enterpriseBranchCashCount");

                entity.Property(e => e.IdEnterpriseBranchCashCountDocument).HasColumnName("id_enterpriseBranchCashCountDocument");

                entity.Property(e => e.Fldconcept)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("fldconcept");

                entity.Property(e => e.Fldvalue)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldvalue")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.IdDocumentType).HasColumnName("id_documentType");

                entity.HasOne(d => d.IdDocumentTypeNavigation)
                    .WithMany(p => p.PEnterprisebranchcashcountdocuments)
                    .HasForeignKey(d => d.IdDocumentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchcashcountdocument$p_enterpriseBranchCashCountDocument_fk02");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchcashcountdocuments)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseBranchCash, d.IdEnterpriseBranchCashCount })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchcashcountdocument$p_enterpriseBranchCashCountDocument_fk01");
            });

            modelBuilder.Entity<PEnterprisebranchcashmovement>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchCash, e.IdEnterpriseBranchCashMovement })
                    .HasName("PK_p_enterprisebranchcashmovement_id_enterprise");

                entity.ToTable("p_enterprisebranchcashmovement");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchCash).HasColumnName("id_enterpriseBranchCash");

                entity.Property(e => e.IdEnterpriseBranchCashMovement).HasColumnName("id_enterpriseBranchCashMovement");

                entity.Property(e => e.FldcloseAmount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldcloseAmount")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FldcloseTime).HasColumnName("fldcloseTime");

                entity.Property(e => e.FldopenAmount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldopenAmount")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FldopenTime).HasColumnName("fldopenTime");

                entity.Property(e => e.FldrecordDate)
                    .HasColumnType("date")
                    .HasColumnName("fldrecordDate");

                entity.Property(e => e.IdCashMovementStatus).HasColumnName("id_cashMovementStatus");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdCashMovementStatusNavigation)
                    .WithMany(p => p.PEnterprisebranchcashmovements)
                    .HasForeignKey(d => d.IdCashMovementStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchcashmovement$p_enterpriseBranchCashMovement_fk02");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.PEnterprisebranchcashmovements)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchcashmovement$p_enterpriseBranchCashMovement_fk03");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchcashmovements)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseBranchCash })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchcashmovement$p_enterpriseBranchCashMovement_fk01");
            });

            modelBuilder.Entity<PEnterprisebranchoutput>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchOutput })
                    .HasName("PK_p_enterprisebranchoutput_id_enterprise");

                entity.ToTable("p_enterprisebranchoutput");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchOutput)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseBranchOutput")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.Fldobservation).HasColumnName("fldobservation");

                entity.Property(e => e.FldrecordDate)
                    .HasPrecision(0)
                    .HasColumnName("fldrecordDate");

                entity.Property(e => e.IdOutputType).HasColumnName("id_outputType");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdOutputTypeNavigation)
                    .WithMany(p => p.PEnterprisebranchoutputs)
                    .HasForeignKey(d => d.IdOutputType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchoutput$p_enterpriseBranchOutput_fk02");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.PEnterprisebranchoutputs)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchoutput$p_enterpriseBranchOutput_fk03");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchoutputs)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchoutput$p_enterpriseBranchOutput_fk01");
            });

            modelBuilder.Entity<PEnterprisebranchoutputproduct>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchOutput, e.IdEnterpriseProduct })
                    .HasName("PK_p_enterprisebranchoutputproduct_id_enterprise");

                entity.ToTable("p_enterprisebranchoutputproduct");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchOutput)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseBranchOutput")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.IdEnterpriseProduct).HasColumnName("id_enterpriseProduct");

                entity.Property(e => e.Fldamount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldamount")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchoutputproducts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseBranchOutput })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchoutputproduct$p_enterpriseBranchOutputProduct_fk01");

                entity.HasOne(d => d.IdEnterprise1)
                    .WithMany(p => p.PEnterprisebranchoutputproducts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseProduct })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchoutputproduct$p_enterpriseBranchOutputProduct_fk02");
            });

            modelBuilder.Entity<PEnterprisebranchpurchase>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchPurchase })
                    .HasName("PK_p_enterprisebranchpurchase_id_enterprise");

                entity.ToTable("p_enterprisebranchpurchase");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchPurchase)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseBranchPurchase")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.FldentryDateToWarehouse)
                    .HasColumnType("date")
                    .HasColumnName("fldentryDateToWarehouse");

                entity.Property(e => e.FldinvoiceDate)
                    .HasColumnType("date")
                    .HasColumnName("fldinvoiceDate");

                entity.Property(e => e.FldinvoiceNumber)
                    .HasMaxLength(10)
                    .HasColumnName("fldinvoiceNumber");

                entity.Property(e => e.Fldobservation).HasColumnName("fldobservation");

                entity.Property(e => e.FldpurchaseDate)
                    .HasColumnType("date")
                    .HasColumnName("fldpurchaseDate");

                entity.Property(e => e.IdEnterpriseProvider).HasColumnName("id_enterpriseProvider");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchpurchases)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchpurchase$p_enterpriseBranchPurchase_fk01");

                entity.HasOne(d => d.IdEnterprise1)
                    .WithMany(p => p.PEnterprisebranchpurchases)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseProvider })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchpurchase$p_enterpriseBranchPurchase_fk02");
            });

            modelBuilder.Entity<PEnterprisebranchpurchasedetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("p_enterprisebranchpurchasedetail");

                entity.Property(e => e.Fldprice).HasColumnName("fldprice");

                entity.Property(e => e.FldunitAmount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldunitAmount")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchPurchase)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseBranchPurchase")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.IdEnterpriseProduct).HasColumnName("id_enterpriseProduct");
            });

            modelBuilder.Entity<PEnterprisebranchquote>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchQuote })
                    .HasName("PK_p_enterprisebranchquote_id_enterprise");

                entity.ToTable("p_enterprisebranchquote");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchQuote)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseBranchQuote")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.Fldquotient)
                    .IsRequired()
                    .HasMaxLength(90)
                    .HasColumnName("fldquotient");

                entity.Property(e => e.FldrecordDate)
                    .HasPrecision(0)
                    .HasColumnName("fldrecordDate");

                entity.Property(e => e.IdEnterpriseCustomer).HasColumnName("id_enterpriseCustomer");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.PEnterprisebranchquotes)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchquote$p_enterpriseBranchQuote_fk03");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchquotes)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchquote$p_enterpriseBranchQuote_fk01");

                entity.HasOne(d => d.IdEnterprise1)
                    .WithMany(p => p.PEnterprisebranchquotes)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseCustomer })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchquote$p_enterpriseBranchQuote_fk02");
            });

            modelBuilder.Entity<PEnterprisebranchquoteproduct>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchQuote, e.IdEnterpriseProduct })
                    .HasName("PK_p_enterprisebranchquoteproduct_id_enterprise");

                entity.ToTable("p_enterprisebranchquoteproduct");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchQuote)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseBranchQuote")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.IdEnterpriseProduct).HasColumnName("id_enterpriseProduct");

                entity.Property(e => e.Fldamount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldamount")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Fldprice).HasColumnName("fldprice");

                entity.Property(e => e.FldpriceQuote).HasColumnName("fldpriceQuote");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchquoteproducts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseBranchQuote })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchquoteproduct$p_enterpriseBranchQuoteProduct_fk01");

                entity.HasOne(d => d.IdEnterprise1)
                    .WithMany(p => p.PEnterprisebranchquoteproducts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseProduct })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchquoteproduct$p_enterpriseBranchQuoteProduct_fk02");
            });

            modelBuilder.Entity<PEnterprisebranchsale>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchSale })
                    .HasName("PK_p_enterprisebranchsale_id_enterprise");

                entity.ToTable("p_enterprisebranchsale");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchSale)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseBranchSale")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.FldinvoiceName)
                    .HasMaxLength(32)
                    .HasColumnName("fldinvoiceName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FldrecordDate)
                    .HasPrecision(0)
                    .HasColumnName("fldrecordDate");

                entity.Property(e => e.FldsaleDate)
                    .HasPrecision(0)
                    .HasColumnName("fldsaleDate");

                entity.Property(e => e.IdEnterpriseCustomer).HasColumnName("id_enterpriseCustomer");

                entity.Property(e => e.IdPaymentStatus).HasColumnName("id_paymentStatus");

                entity.Property(e => e.IdSaleStatus).HasColumnName("id_saleStatus");

                entity.Property(e => e.IdUseCfdi).HasColumnName("id_useCFDI");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdPaymentStatusNavigation)
                    .WithMany(p => p.PEnterprisebranchsales)
                    .HasForeignKey(d => d.IdPaymentStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsale$p_enterpriseBranchSale_fk04");

                entity.HasOne(d => d.IdSaleStatusNavigation)
                    .WithMany(p => p.PEnterprisebranchsales)
                    .HasForeignKey(d => d.IdSaleStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsale$p_enterpriseBranchSale_fk03");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.PEnterprisebranchsales)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsale$p_enterpriseBranchSale_fk05");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchsales)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsale$p_enterpriseBranchSale_fk01");

                entity.HasOne(d => d.IdEnterprise1)
                    .WithMany(p => p.PEnterprisebranchsales)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseCustomer })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsale$p_enterpriseBranchSale_fk02");
            });

            modelBuilder.Entity<PEnterprisebranchsaledelivery>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchSale })
                    .HasName("PK_p_enterprisebranchsaledelivery_id_enterprise");

                entity.ToTable("p_enterprisebranchsaledelivery");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchSale)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseBranchSale")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.Fldobservation).HasColumnName("fldobservation");

                entity.Property(e => e.FldrecordDate)
                    .HasPrecision(0)
                    .HasColumnName("fldrecordDate");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.PEnterprisebranchsaledeliveries)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsaledelivery$p_enterpriseBranchSaleDelivery_fk02");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithOne(p => p.PEnterprisebranchsaledelivery)
                    .HasForeignKey<PEnterprisebranchsaledelivery>(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseBranchSale })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsaledelivery$p_enterpriseBranchSaleDelivery_fk01");
            });

            modelBuilder.Entity<PEnterprisebranchsalepayment>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchSale, e.IdEnterpriseBranchSalePayment })
                    .HasName("PK_p_enterprisebranchsalepayment_id_enterprise");

                entity.ToTable("p_enterprisebranchsalepayment");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchSale)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseBranchSale")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.IdEnterpriseBranchSalePayment).HasColumnName("id_enterpriseBranchSalePayment");

                entity.Property(e => e.Fldamount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldamount")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FldnumberAccount)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("fldnumberAccount");

                entity.Property(e => e.Fldobservation).HasColumnName("fldobservation");

                entity.Property(e => e.FldrecordDate)
                    .HasPrecision(0)
                    .HasColumnName("fldrecordDate");

                entity.Property(e => e.IdEnterpriseBranchCash).HasColumnName("id_enterpriseBranchCash");

                entity.Property(e => e.IdPaymentMethod).HasColumnName("id_paymentMethod");

                entity.Property(e => e.IdPaymentType).HasColumnName("id_paymentType");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdPaymentMethodNavigation)
                    .WithMany(p => p.PEnterprisebranchsalepayments)
                    .HasForeignKey(d => d.IdPaymentMethod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsalepayment$p_enterpriseBranchSalePayment_fk05");

                entity.HasOne(d => d.IdPaymentTypeNavigation)
                    .WithMany(p => p.PEnterprisebranchsalepayments)
                    .HasForeignKey(d => d.IdPaymentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsalepayment$p_enterpriseBranchSalePayment_fk03");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.PEnterprisebranchsalepayments)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsalepayment$p_enterpriseBranchSalePayment_fk04");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchsalepayments)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseBranchCash })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsalepayment$p_enterpriseBranchSalePayment_fk02");

                entity.HasOne(d => d.IdEnterprise1)
                    .WithMany(p => p.PEnterprisebranchsalepayments)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseBranchSale })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsalepayment$p_enterpriseBranchSalePayment_fk01");
            });

            modelBuilder.Entity<PEnterprisebranchsaleproduct>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseBranch, e.IdEnterpriseBranchSale, e.IdEnterpriseProduct })
                    .HasName("PK_p_enterprisebranchsaleproduct_id_enterprise");

                entity.ToTable("p_enterprisebranchsaleproduct");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseBranchSale)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseBranchSale")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.IdEnterpriseProduct).HasColumnName("id_enterpriseProduct");

                entity.Property(e => e.Fldamount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldamount")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Fldprice).HasColumnName("fldprice");

                entity.Property(e => e.FldpriceSale).HasColumnName("fldpriceSale");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisebranchsaleproducts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseBranchSale })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsaleproduct$p_enterpriseBranchSaleProduct_fk01");

                entity.HasOne(d => d.IdEnterprise1)
                    .WithMany(p => p.PEnterprisebranchsaleproducts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch, d.IdEnterpriseProduct })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisebranchsaleproduct$p_enterpriseBranchSaleProduct_fk02");
            });

            modelBuilder.Entity<PEnterprisecreditnote>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseCreditNote })
                    .HasName("PK_p_enterprisecreditnote_id_enterprise");

                entity.ToTable("p_enterprisecreditnote");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseCreditNote)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseCreditNote")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.Fldobservation).HasColumnName("fldobservation");

                entity.Property(e => e.FldrecordDate)
                    .HasPrecision(0)
                    .HasColumnName("fldrecordDate");

                entity.Property(e => e.Fldvalue)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldvalue")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.IdCreditNoteStatus).HasColumnName("id_creditNoteStatus");

                entity.Property(e => e.IdEnterpriseBranch).HasColumnName("id_enterpriseBranch");

                entity.Property(e => e.IdEnterpriseCustomer).HasColumnName("id_enterpriseCustomer");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdCreditNoteStatusNavigation)
                    .WithMany(p => p.PEnterprisecreditnotes)
                    .HasForeignKey(d => d.IdCreditNoteStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisecreditnote$p_enterpriseCreditNote_fk02");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisecreditnotes)
                    .HasForeignKey(d => d.IdEnterprise)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisecreditnote$p_enterpriseCreditNote_fk01");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.PEnterprisecreditnotes)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisecreditnote$p_enterpriseCreditNote_fk05");

                entity.HasOne(d => d.IdEnterprise1)
                    .WithMany(p => p.PEnterprisecreditnotes)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseBranch })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisecreditnote$p_enterpriseCreditNote_fk03");

                entity.HasOne(d => d.IdEnterprise2)
                    .WithMany(p => p.PEnterprisecreditnotes)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseCustomer })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisecreditnote$p_enterpriseCreditNote_fk04");
            });

            modelBuilder.Entity<PEnterprisetransfer>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseTransfer })
                    .HasName("PK_p_enterprisetransfer_id_enterprise");

                entity.ToTable("p_enterprisetransfer");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseTransfer)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseTransfer")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.Fldobservation).HasColumnName("fldobservation");

                entity.Property(e => e.FldrecordDate)
                    .HasPrecision(0)
                    .HasColumnName("fldrecordDate");

                entity.Property(e => e.IdEnterpriseBranchDestination).HasColumnName("id_enterpriseBranchDestination");

                entity.Property(e => e.IdEnterpriseBranchSource).HasColumnName("id_enterpriseBranchSource");

                entity.Property(e => e.IdTransferStatus).HasColumnName("id_transferStatus");

                entity.Property(e => e.IdTransferType).HasColumnName("id_transferType");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisetransfers)
                    .HasForeignKey(d => d.IdEnterprise)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisetransfer$p_enterpriseTransfer_fk01");
            });

            modelBuilder.Entity<PEnterprisetransferproduct>(entity =>
            {
                entity.HasKey(e => new { e.IdEnterprise, e.IdEnterpriseTransfer, e.IdEnterpriseProduct })
                    .HasName("PK_p_enterprisetransferproduct_id_enterprise");

                entity.ToTable("p_enterprisetransferproduct");

                entity.Property(e => e.IdEnterprise).HasColumnName("id_enterprise");

                entity.Property(e => e.IdEnterpriseTransfer)
                    .HasMaxLength(9)
                    .HasColumnName("id_enterpriseTransfer")
                    .HasDefaultValueSql("(N'000000-00')");

                entity.Property(e => e.IdEnterpriseProduct).HasColumnName("id_enterpriseProduct");

                entity.Property(e => e.Fldamount)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("fldamount")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.IdEnterpriseNavigation)
                    .WithMany(p => p.PEnterprisetransferproducts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseProduct })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisetransferproduct$p_enterpriseTransferProduct_fk02");

                entity.HasOne(d => d.IdEnterprise1)
                    .WithMany(p => p.PEnterprisetransferproducts)
                    .HasForeignKey(d => new { d.IdEnterprise, d.IdEnterpriseTransfer })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_enterprisetransferproduct$p_enterpriseTransferProduct_fk01");
            });

            modelBuilder.Entity<PPasswordreset>(entity =>
            {
                entity.HasKey(e => e.IdPasswordReset)
                    .HasName("PK_p_passwordreset_id_passwordReset");

                entity.ToTable("p_passwordreset");

                entity.Property(e => e.IdPasswordReset)
                    .HasMaxLength(32)
                    .HasColumnName("id_passwordReset");

                entity.Property(e => e.FldeffectiveEndDate)
                    .HasPrecision(0)
                    .HasColumnName("fldeffectiveEndDate");

                entity.Property(e => e.FldeffectiveStartDate)
                    .HasPrecision(0)
                    .HasColumnName("fldeffectiveStartDate");

                entity.Property(e => e.IdPasswordResetStatus).HasColumnName("id_passwordResetStatus");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdPasswordResetStatusNavigation)
                    .WithMany(p => p.PPasswordresets)
                    .HasForeignKey(d => d.IdPasswordResetStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_passwordreset$p_passwordReset_fk01");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.PPasswordresets)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("p_passwordreset$p_passwordReset_fk02");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
