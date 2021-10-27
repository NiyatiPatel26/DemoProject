using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DemoProject.DataServices.EntityData.EntityModels;

#nullable disable

namespace DemoProject.DataServices.EntityData
{
    public partial class DemoContext : DbContext
    {
        public DemoContext()
        {
        }

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<UserPersonal> UserPersonals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=EC2AMAZ-HTK07IA;Database=Demo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__UserInfo__DD701264D9ED8F2E");

                entity.ToTable("UserInfo");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Uadd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("uadd");

                entity.Property(e => e.Uname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("uname");
            });

            modelBuilder.Entity<UserPersonal>(entity =>
            {
                entity.HasKey(e => e.Upid)
                    .HasName("PK__userPers__B6A5904F09B45149");

                entity.ToTable("userPersonal");

                entity.Property(e => e.Upid).HasColumnName("UPid");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.UidNavigation)
                    .WithMany(p => p.UserPersonals)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__userPersona__uid__36B12243");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
