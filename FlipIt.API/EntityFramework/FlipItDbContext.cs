using FlipIt.API.Constants;
using FlipIt.API.Enums;
using FlipIt.API.Extensions;
using FlipIt.API.Extensions.SeedData;
using FlipIt.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FlipIt.API.EntityFramework
{
    public class FlipItDbContext : DbContext
    {
        public DbSet<Build> Builds { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public FlipItDbContext(DbContextOptions<FlipItDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Build>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.DateListed);
                entity.HasMany(x => x.Components).WithOne(x => x.Build)
                .HasForeignKey(x => x.BuildId);
            });

            builder.Entity<Component>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.PartId).IsRequired();
                entity.Property(x => x.BuildId).IsRequired(false);
                entity.HasOne(x => x.Build).WithMany(x => x.Components).HasForeignKey(x => x.BuildId);
                entity.HasOne(x => x.Vendor).WithMany().HasForeignKey(x => x.VendorId);
                entity.HasOne(x => x.Part).WithMany().HasForeignKey(x => x.PartId);
            });

            //builder.Entity<Inventory>(entity =>
            //{
            //    entity.HasKey(x => x.Id);
            //    entity.HasMany(x => x.Builds);
            //    entity.HasMany(x => x.Components);
            //});

            builder.Entity<Part>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.PartName).IsRequired();
            });

            builder.Entity<Vendor>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.VendorName).IsRequired();
            });


            builder.Entity<Part>().AddSeedData();
            builder.Entity<Vendor>().AddSeedData();
            builder.Entity<Component>().AddSeedData();
            builder.Entity<Build>().AddSeedData();
        }
    }
}
