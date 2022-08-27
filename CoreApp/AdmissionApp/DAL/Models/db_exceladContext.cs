using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.Models
{
    public partial class db_exceladContext : DbContext
    {
        public db_exceladContext()
        {

        }

        public db_exceladContext(DbContextOptions<db_exceladContext> options)
            : base(options)
        {

        }

        public virtual DbSet<TblAdmission> TblAdmissions { get; set; }
        public virtual DbSet<TblBranch> TblBranches { get; set; }
        public virtual DbSet<TblCourse> TblCourses { get; set; }
        public virtual DbSet<TblDesignation> TblDesignations { get; set; }
        public virtual DbSet<TblEnquiry> TblEnquiries { get; set; }
        public virtual DbSet<TblSubject> TblSubjects { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=101.53.144.230;Initial Catalog=db_excelad;Persist Security Info=True;User ID=excelad;password=n2qe_86N;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("excelad")
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<TblAdmission>(entity =>
            {
                entity.HasKey(e => e.AId)
                    .HasName("PK__TBL_ADMI__71AC6D415D03478D");

                entity.ToTable("TBL_ADMISSION", "dbo");

                entity.Property(e => e.AId).HasColumnName("A_ID");

                entity.Property(e => e.AppearingFor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPEARING_FOR");

                entity.Property(e => e.AppearingYear).HasColumnName("APPEARING_YEAR");

                entity.Property(e => e.CameThroughId).HasColumnName("CAME_THROUGH_ID");

                entity.Property(e => e.DateOfJoining)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_OF_JOINING");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DISCOUNT_PERCENT");

                entity.Property(e => e.DiscountRupees)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DISCOUNT_RUPEES");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Father)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FATHER");

                entity.Property(e => e.FeesPaid).HasColumnName("FEES_PAID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Marks10th)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MARKS_10TH");

                entity.Property(e => e.Marks11th)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MARKS_11TH");

                entity.Property(e => e.Marks12th)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("MARKS_12TH");

                entity.Property(e => e.Medium)
                    .HasColumnName("MEDIUM")
                    .HasComment("1 FOR HINDI 0 FOR ENGLISH");

                entity.Property(e => e.Mother)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOTHER");

                entity.Property(e => e.PaidAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PAID_AMOUNT");

                entity.Property(e => e.ParentContact)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_CONTACT");

                entity.Property(e => e.ParentEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_EMAIL");

                entity.Property(e => e.ParentTelegram)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_TELEGRAM");

                entity.Property(e => e.PartPayment).HasColumnName("PART_PAYMENT");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PAYMENT_DATE");

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(200)
                    .HasColumnName("PERMANENT_ADDRESS");

                entity.Property(e => e.PermanentDistrict)
                    .HasMaxLength(40)
                    .HasColumnName("PERMANENT_DISTRICT");

                entity.Property(e => e.PermanentPincode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PERMANENT_PINCODE");

                entity.Property(e => e.ResidentialAddress)
                    .HasMaxLength(200)
                    .HasColumnName("RESIDENTIAL_ADDRESS");

                entity.Property(e => e.ResidentialDistrict)
                    .HasMaxLength(40)
                    .HasColumnName("RESIDENTIAL_DISTRICT");

                entity.Property(e => e.ResidentialPincode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("RESIDENTIAL_PINCODE");

                entity.Property(e => e.SchoolColllege)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SCHOOL_COLLLEGE");

                entity.Property(e => e.StudentContact)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STUDENT_CONTACT");

                entity.Property(e => e.StudentEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STUDENT_EMAIL");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STUDENT_NAME");

                entity.Property(e => e.StudentTelegram)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STUDENT_TELEGRAM");

                entity.Property(e => e.TotalFees).HasColumnName("TOTAL_FEES");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANSACTION_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblAdmissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_ADMISSION_TBL_USERS");
            });

            modelBuilder.Entity<TblBranch>(entity =>
            {
                entity.HasKey(e => e.BranchId);

                entity.ToTable("TBL_BRANCH", "dbo");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .HasColumnName("BRANCH");
            });

            modelBuilder.Entity<TblCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("TBL_COURSE", "dbo");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.Course)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COURSE");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.OfflineFees).HasColumnName("OFFLINE_FEES");

                entity.Property(e => e.OnlineFees).HasColumnName("ONLINE_FEES");
            });

            modelBuilder.Entity<TblDesignation>(entity =>
            {
                entity.HasKey(e => e.DesignationId);

                entity.ToTable("TBL_DESIGNATION", "dbo");

                entity.Property(e => e.DesignationId).HasColumnName("DESIGNATION_ID");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESIGNATION");
            });

            modelBuilder.Entity<TblEnquiry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_ENQUIRY", "dbo");

                entity.Property(e => e.Contact)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.Datetimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("DATETIMESTAMP");

                entity.Property(e => e.EId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("E_ID");

                entity.Property(e => e.Message)
                    .HasMaxLength(200)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.ModeOfClass)
                    .HasColumnName("MODE_OF_CLASS")
                    .HasComment("0 FOR OFFLINE 1 FOR ONLINE");

                entity.Property(e => e.Place)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PLACE");

                entity.Property(e => e.Student)
                    .HasMaxLength(100)
                    .HasColumnName("STUDENT");
            });

            modelBuilder.Entity<TblSubject>(entity =>
            {
                entity.HasKey(e => e.SubjectId);

                entity.ToTable("TBL_SUBJECTS", "dbo");

                entity.Property(e => e.SubjectId).HasColumnName("SUBJECT_ID");

                entity.Property(e => e.CourseId).HasColumnName("COURSE_ID");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.OfflineFees).HasColumnName("OFFLINE_FEES");

                entity.Property(e => e.OnlineFees).HasColumnName("ONLINE_FEES");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TblSubjects)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_TBL_SUBJECTS_TBL_COURSE");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("TBL_USERS", "dbo");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.Contact1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT1");

                entity.Property(e => e.Contact2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT2");

                entity.Property(e => e.DesignationId).HasColumnName("DESIGNATION_ID");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ID");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FATHER_NAME");

                entity.Property(e => e.Gender).HasColumnName("GENDER");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Photo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PHOTO");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_TBL_USERS_TBL_BRANCH1");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK_TBL_USERS_TBL_DESIGNATION1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
