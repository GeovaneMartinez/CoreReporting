using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebullCore.Models
{
    public partial class WebullContext : DbContext
    {
        public WebullContext()
        {
        }

        public WebullContext(DbContextOptions<WebullContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Transactions> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=GEOVANE-PC\\SQLEXPRESS;Database=Webull;user id=Webull;password=Webull;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndPrice).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartPrice).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
