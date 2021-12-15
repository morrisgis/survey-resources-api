using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SurveyResourcesAPI.Models
{
    public partial class SurveyResourcesContext : DbContext
    {
        public SurveyResourcesContext()
        {
        }

        public SurveyResourcesContext(DbContextOptions<SurveyResourcesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LkupDocumentType> LkupDocumentTypes { get; set; }
        public virtual DbSet<LkupSurveyBaseMapStatus> LkupSurveyBaseMapStatuses { get; set; }
        public virtual DbSet<LkupSurveyCoordinateSystem> LkupSurveyCoordinateSystems { get; set; }
        public virtual DbSet<LkupSurveyDocType> LkupSurveyDocTypes { get; set; }
        public virtual DbSet<LkupSurveyFileExtension> LkupSurveyFileExtensions { get; set; }
        public virtual DbSet<LkupSurveyResourceType> LkupSurveyResourceTypes { get; set; }
        public virtual DbSet<LkupSurveySurveySource> LkupSurveySurveySources { get; set; }
        public virtual DbSet<MetaLinkedtablesSurveyresource> MetaLinkedtablesSurveyresources { get; set; }
        public virtual DbSet<MetaVersionFeMasterSurveyresource> MetaVersionFeMasterSurveyresources { get; set; }
        public virtual DbSet<SurveyDocument> SurveyDocuments { get; set; }
        public virtual DbSet<SurveyLandUse> SurveyLandUses { get; set; }
        public virtual DbSet<SurveyLandholderInterest> SurveyLandholderInterests { get; set; }
        public virtual DbSet<SurveyParcelsLink> SurveyParcelsLinks { get; set; }
        public virtual DbSet<SurveyResource> SurveyResources { get; set; }
        public virtual DbSet<SurveyTaxMapLink> SurveyTaxMapLinks { get; set; }
        public virtual DbSet<TblLkupBasePlanStatus> TblLkupBasePlanStatuses { get; set; }
        public virtual DbSet<TblLkupBaseSurveySource> TblLkupBaseSurveySources { get; set; }
        public virtual DbSet<TblLkupBaseSurveyType> TblLkupBaseSurveyTypes { get; set; }
        public virtual DbSet<TblLkupSurveyStatus> TblLkupSurveyStatuses { get; set; }
        public virtual DbSet<TblLkupSurveyType> TblLkupSurveyTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=mcgisdb;Initial Catalog=SurveyResources;Persist Security Info=False;User ID=sa;Password=GIS 2019 sql database admin;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LkupDocumentType>(entity =>
            {
                entity.HasKey(e => e.DocumentTypeId);

                entity.ToTable("Lkup_DocumentTypes");

                entity.Property(e => e.ApplicationRoute)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationTenant)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FileSubstring)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PktableName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PKTableName");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LkupSurveyBaseMapStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lkup_SURVEY_BaseMapStatus");

                entity.Property(e => e.BaseMapStatusCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");
            });

            modelBuilder.Entity<LkupSurveyCoordinateSystem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lkup_SURVEY_CoordinateSystem");

                entity.Property(e => e.CoordinateSystemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");
            });

            modelBuilder.Entity<LkupSurveyDocType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lkup_SURVEY_DocType");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocTypeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");
            });

            modelBuilder.Entity<LkupSurveyFileExtension>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lkup_SURVEY_FileExtension");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileExtensionCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");
            });

            modelBuilder.Entity<LkupSurveyResourceType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lkup_SURVEY_ResourceType");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ResourceTypeCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LkupSurveySurveySource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lkup_SURVEY_SurveySource");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.SurveySourceCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MetaLinkedtablesSurveyresource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("meta_linkedtables-surveyresources");

                entity.Property(e => e.DbName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dbName");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("tableName");
            });

            modelBuilder.Entity<MetaVersionFeMasterSurveyresource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("meta_version_fe_master-surveyresources");

                entity.Property(e => e.FeVersionNumber)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("fe_version_number");

                entity.Property(e => e.SMasterlocation)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("s_masterlocation");
            });

            modelBuilder.Entity<SurveyDocument>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.Property(e => e.DocumentId)
                    .ValueGeneratedNever()
                    .HasColumnName("DocumentID");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.ExternalUrl)
                    .HasMaxLength(150)
                    .HasColumnName("ExternalURL");

                entity.Property(e => e.FileExtension)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FolderPath).HasMaxLength(150);

                entity.Property(e => e.HasTraverse).HasColumnName("hasTraverse");

                entity.Property(e => e.HasWorldFile).HasColumnName("hasWorldFile");

                entity.Property(e => e.LastEditDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastEditor).HasMaxLength(25);

                entity.Property(e => e.McgisUrl)
                    .HasMaxLength(150)
                    .HasColumnName("mcgisURL");

                entity.Property(e => e.OrigFilePath)
                    .HasMaxLength(150)
                    .HasColumnName("origFilePath");

                entity.Property(e => e.OrigSurveyId).HasColumnName("origSurveyID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.SurveySource).HasMaxLength(50);

                entity.Property(e => e.TempFileName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("tempFileName");

                entity.Property(e => e.TempHasMatch).HasColumnName("tempHasMatch");

                entity.Property(e => e.TempTimestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("tempTimestamp");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyDocuments)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyDocuments_SurveyResources");
            });

            modelBuilder.Entity<SurveyLandUse>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClassificationCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IsPrimary).HasColumnName("isPrimary");

                entity.Property(e => e.Luid).HasColumnName("LUID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");
            });

            modelBuilder.Entity<SurveyLandholderInterest>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Agencyid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AGENCYID");

                entity.Property(e => e.IsPrimary).HasColumnName("isPrimary");

                entity.Property(e => e.Lhiid).HasColumnName("LHIID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");
            });

            modelBuilder.Entity<SurveyParcelsLink>(entity =>
            {
                entity.HasKey(e => e.Spid);

                entity.ToTable("SurveyParcels_link");

                entity.Property(e => e.AddTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Block).HasMaxLength(10);

                entity.Property(e => e.Gnis)
                    .HasMaxLength(20)
                    .HasColumnName("GNIS");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Lot).HasMaxLength(10);

                entity.Property(e => e.MunicipalId)
                    .HasMaxLength(4)
                    .HasColumnName("MunicipalID");

                entity.Property(e => e.PamsPin)
                    .HasMaxLength(38)
                    .HasColumnName("PAMS_PIN");

                entity.Property(e => e.QualificationCode).HasMaxLength(11);

                entity.Property(e => e.RetirementComments).HasColumnName("retirementComments");

                entity.Property(e => e.RetirementDate)
                    .HasColumnType("date")
                    .HasColumnName("retirementDate");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.TaxSheet).HasMaxLength(15);

                entity.Property(e => e.ValidationDate).HasColumnName("validationDate");
            });

            modelBuilder.Entity<SurveyResource>(entity =>
            {
                entity.HasKey(e => e.SurveyId);

                entity.Property(e => e.SurveyId)
                    .ValueGeneratedNever()
                    .HasColumnName("SurveyID");

                entity.Property(e => e.AliasNames).HasMaxLength(255);

                entity.Property(e => e.BaseMapUpdateStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CoClerkBookNumber).HasMaxLength(12);

                entity.Property(e => e.CoClerkFileNumber).HasMaxLength(16);

                entity.Property(e => e.CoClerkPageNumber).HasMaxLength(12);

                entity.Property(e => e.Cogoreport)
                    .HasMaxLength(2000)
                    .HasColumnName("COGOReport");

                entity.Property(e => e.DevReviewNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GreenAcresSurveyId)
                    .HasMaxLength(20)
                    .HasColumnName("GreenAcresSurveyID");

                entity.Property(e => e.HasValidBaseSurvey).HasColumnName("hasValidBaseSurvey");

                entity.Property(e => e.HasValidLandholderInterests).HasColumnName("hasValidLandholderInterests");

                entity.Property(e => e.HasValidSurveyDocument).HasColumnName("hasValidSurveyDocument");

                entity.Property(e => e.HasValidSurveyParcelsLink).HasColumnName("hasValidSurveyParcelsLink");

                entity.Property(e => e.IsPublicLandholderInterest).HasColumnName("isPublicLandholderInterest");

                entity.Property(e => e.LastEditDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastEditor).HasMaxLength(25);

                entity.Property(e => e.MetaCreationDateTime)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NewFilename)
                    .HasMaxLength(10)
                    .HasColumnName("newFilename")
                    .IsFixedLength(true);

                entity.Property(e => e.OrigSurveyId).HasColumnName("orig_SurveyID");

                entity.Property(e => e.OstfProjectId).HasColumnName("OSTF_ProjectID");

                entity.Property(e => e.OtherSurveyId)
                    .HasMaxLength(50)
                    .HasColumnName("otherSurveyID");

                entity.Property(e => e.PosiUnitId).HasColumnName("POSI_UNIT_ID");

                entity.Property(e => e.PresentName).HasMaxLength(100);

                entity.Property(e => e.PrimaryMuniId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("primaryMuniID");

                entity.Property(e => e.ResourceType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyCoordinateSystem)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyDate).HasColumnType("date");

                entity.Property(e => e.SurveySiteGeneralAddress).HasMaxLength(150);

                entity.Property(e => e.SurveySource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyTitle).HasMaxLength(100);

                entity.Property(e => e.TestTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("testTimeStamp");
            });

            modelBuilder.Entity<SurveyTaxMapLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SurveyTaxMap_link");

                entity.Property(e => e.AddTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Gnis)
                    .HasMaxLength(20)
                    .HasColumnName("GNIS");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.MunicipalId)
                    .HasMaxLength(4)
                    .HasColumnName("MunicipalID");

                entity.Property(e => e.RetirementComments).HasColumnName("retirementComments");

                entity.Property(e => e.RetirementDate)
                    .HasColumnType("date")
                    .HasColumnName("retirementDate");

                entity.Property(e => e.Stmid).HasColumnName("STMID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.TaxSheet).HasMaxLength(15);

                entity.Property(e => e.ValidationDate).HasColumnName("validationDate");
            });

            modelBuilder.Entity<TblLkupBasePlanStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_Lkup_BASE_PlanStatus");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLkupBaseSurveySource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_Lkup_BASE_SurveySource");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLkupBaseSurveyType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_Lkup_BASE_SurveyType");

                entity.Property(e => e.Code).HasMaxLength(30);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Value).HasMaxLength(30);
            });

            modelBuilder.Entity<TblLkupSurveyStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_LkupSurveyStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status).HasMaxLength(12);
            });

            modelBuilder.Entity<TblLkupSurveyType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_LKUP_SurveyType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status).HasMaxLength(12);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
