using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TravelsProject.Models
{
    public partial class TravelsDBContext : DbContext
    {
        public TravelsDBContext()
        {
        }

        public TravelsDBContext(DbContextOptions<TravelsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BusInfo> BusInfos { get; set; } = null!;
        public virtual DbSet<BusView> BusViews { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=KARTHI\\SQLEXPRESS;Initial Catalog=TravelsDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusInfo>(entity =>
            {
                entity.HasKey(e => e.BusId)
                    .HasName("PK__BusInfo__6A0F60B516482A6D");

                entity.ToTable("BusInfo");

                entity.Property(e => e.BoardingPoint)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TravelDate).HasColumnType("date");
            });

            modelBuilder.Entity<BusView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Bus_View");

                entity.Property(e => e.BoardingPoint)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BusId).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
