using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BikeService.Models
{
    public partial class BikeServiceContext : DbContext
    {
        public BikeServiceContext()
        {
        }

        public BikeServiceContext(DbContextOptions<BikeServiceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAdminLogin> TblAdminLogins { get; set; }
        public virtual DbSet<TblBanner> TblBanners { get; set; }
        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblCountry> TblCountries { get; set; }
        public virtual DbSet<TblInvoice> TblInvoices { get; set; }
        public virtual DbSet<TblLog> TblLogs { get; set; }
        public virtual DbSet<TblMenu> TblMenus { get; set; }
        public virtual DbSet<TblOrder> TblOrders { get; set; }
        public virtual DbSet<TblOrderMapping> TblOrderMappings { get; set; }
        public virtual DbSet<TblOtp> TblOtps { get; set; }
        public virtual DbSet<TblQuickBooking> TblQuickBookings { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblRoleMenu> TblRoleMenus { get; set; }
        public virtual DbSet<TblService> TblServices { get; set; }
        public virtual DbSet<TblServiceType> TblServiceTypes { get; set; }
        public virtual DbSet<TblState> TblStates { get; set; }
        public virtual DbSet<TblSubCategory> TblSubCategories { get; set; }
        public virtual DbSet<TblSubSubCategory> TblSubSubCategories { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserAddress> TblUserAddresses { get; set; }
        public virtual DbSet<TblUserReview> TblUserReviews { get; set; }
        public virtual DbSet<TblVendor> TblVendors { get; set; }
        public virtual DbSet<TblVendorReview> TblVendorReviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-CT6B57M\\SQLEXPRESS;Initial Catalog=BikeService;Persist Security Info=False;User ID=sa;Password=p@ssw0rd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAdminLogin>(entity =>
            {
                entity.ToTable("tbl_AdminLogin");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBanner>(entity =>
            {
                entity.ToTable("tbl_Banner");

                entity.Property(e => e.BannerName).HasMaxLength(50);

                entity.Property(e => e.BannerUrl)
                    .HasMaxLength(500)
                    .HasColumnName("BannerURL");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("tbl_Category");

                entity.Property(e => e.CategoryBanner).HasMaxLength(50);

                entity.Property(e => e.CategoryCode).HasMaxLength(50);

                entity.Property(e => e.CategoryDescription).HasMaxLength(50);

                entity.Property(e => e.CategoryDisplayName).HasMaxLength(50);

                entity.Property(e => e.CategoryImage).HasMaxLength(50);

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.ToTable("tbl_Country");

                entity.Property(e => e.CountryCode).HasMaxLength(50);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblInvoice>(entity =>
            {
                entity.ToTable("tbl_Invoice");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<TblLog>(entity =>
            {
                entity.ToTable("tbl_logs");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionMessage).HasMaxLength(500);

                entity.Property(e => e.ExceptionSource).HasMaxLength(50);

                entity.Property(e => e.ExceptionType).HasMaxLength(50);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMenu>(entity =>
            {
                entity.ToTable("tbl_Menu");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MenuCode).HasMaxLength(50);

                entity.Property(e => e.MenuName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.ToTable("tbl_Order");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(50);

                entity.Property(e => e.ServiceAmountPaidByUser).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceDiscountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceInitialAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceOfferAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceTotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<TblOrderMapping>(entity =>
            {
                entity.ToTable("tbl_OrderMapping");

                entity.Property(e => e.AcceptOrderDate).HasColumnType("datetime");

                entity.Property(e => e.AcceptOrderRemarks).HasMaxLength(50);

                entity.Property(e => e.AssignDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderCancellBy).HasMaxLength(50);

                entity.Property(e => e.OrderCancelledDate).HasColumnType("datetime");

                entity.Property(e => e.OrderCancelledRemarks).HasMaxLength(50);

                entity.Property(e => e.OrderCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.OrderCompletedRemarksByVendor).HasMaxLength(50);

                entity.Property(e => e.OrderCurrentStatus).HasMaxLength(50);

                entity.Property(e => e.OrderNumber).HasMaxLength(50);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMode).HasMaxLength(50);

                entity.Property(e => e.PaymentStatus).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserDescription).HasMaxLength(50);

                entity.Property(e => e.VendorDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<TblOtp>(entity =>
            {
                entity.ToTable("tbl_OTP");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.Otp)
                    .HasMaxLength(50)
                    .HasColumnName("OTP");
            });

            modelBuilder.Entity<TblQuickBooking>(entity =>
            {
                entity.ToTable("tbl_QuickBooking");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Ccdetails).HasColumnName("CCDetails");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(500);

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.ToTable("tbl_Role");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Role).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRoleMenu>(entity =>
            {
                entity.ToTable("tbl_RoleMenu");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.ToTable("tbl_Service");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblServiceType>(entity =>
            {
                entity.ToTable("tbl_ServiceType");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceType).HasMaxLength(50);
            });

            modelBuilder.Entity<TblState>(entity =>
            {
                entity.ToTable("tbl_State");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.State).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSubCategory>(entity =>
            {
                entity.ToTable("tbl_SubCategory");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryBanner).HasMaxLength(50);

                entity.Property(e => e.SubCategoryCode).HasMaxLength(50);

                entity.Property(e => e.SubCategoryDescription).HasMaxLength(50);

                entity.Property(e => e.SubCategoryDisplayName).HasMaxLength(50);

                entity.Property(e => e.SubCategoryImage).HasMaxLength(50);

                entity.Property(e => e.SubCategoryName).HasMaxLength(50);

                entity.Property(e => e.SubCategoryTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSubSubCategory>(entity =>
            {
                entity.ToTable("tbl_SubSubCategory");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubSubCategoryBanner).HasMaxLength(50);

                entity.Property(e => e.SubSubCategoryCode).HasMaxLength(50);

                entity.Property(e => e.SubSubCategoryDescription).HasMaxLength(50);

                entity.Property(e => e.SubSubCategoryDisplayName).HasMaxLength(50);

                entity.Property(e => e.SubSubCategoryImage).HasMaxLength(50);

                entity.Property(e => e.SubSubCategoryName).HasMaxLength(50);

                entity.Property(e => e.SubSubCategoryTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_User");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(500);

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserImage).HasMaxLength(500);
            });

            modelBuilder.Entity<TblUserAddress>(entity =>
            {
                entity.ToTable("tbl_UserAddress");

                entity.Property(e => e.Address1).HasMaxLength(500);

                entity.Property(e => e.Address2).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsCurrentAddress).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<TblUserReview>(entity =>
            {
                entity.ToTable("tbl_UserReview");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<TblVendor>(entity =>
            {
                entity.ToTable("tbl_Vendor");

                entity.Property(e => e.Address1)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Address2)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Isverified).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VendorAadharImage).HasMaxLength(50);

                entity.Property(e => e.VendorAadharNo).HasMaxLength(12);

                entity.Property(e => e.VendorImage).HasMaxLength(50);
            });

            modelBuilder.Entity<TblVendorReview>(entity =>
            {
                entity.ToTable("tbl_VendorReview");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
