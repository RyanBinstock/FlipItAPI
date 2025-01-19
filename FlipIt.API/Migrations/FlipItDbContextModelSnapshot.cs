﻿// <auto-generated />
using System;
using FlipIt.API.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlipIt.API.Migrations
{
    [DbContext(typeof(FlipItDbContext))]
    partial class FlipItDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FlipIt.API.Models.Build", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("BuildCost")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DateListed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateSold")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Builds");

                    b.HasData(
                        new
                        {
                            Id = new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"),
                            Description = "First PC Flip!"
                        });
                });

            modelBuilder.Entity("FlipIt.API.Models.Component", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BuildId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("VendorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BuildId");

                    b.HasIndex("PartId");

                    b.HasIndex("VendorId");

                    b.ToTable("Components");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bfb6188a-5dfa-473e-95c0-f523eea43e12"),
                            BuildId = new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"),
                            Details = "",
                            Name = "Ryzen 5 3600",
                            PartId = new Guid("d3287e4b-189a-4f55-b5c5-898434ec2ffc"),
                            Price = 50.0,
                            VendorId = new Guid("d4bd707d-6d07-4730-a179-69256c819983")
                        },
                        new
                        {
                            Id = new Guid("ade6e1e6-3a24-4803-b4dc-13dd43cc42cf"),
                            BuildId = new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"),
                            Details = "white rgb heatsink",
                            Name = "AIGO ICEPRO200",
                            PartId = new Guid("11ecb302-3f35-44f0-9d32-4a63d421e8dc"),
                            Price = 16.379999999999999,
                            VendorId = new Guid("8926f78c-1a13-4824-9cd8-a7185ccbecac")
                        },
                        new
                        {
                            Id = new Guid("562bd3bc-043f-4505-be2f-aed42f4b47d9"),
                            BuildId = new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"),
                            Details = "8gb",
                            Name = "RADEON RX 580",
                            PartId = new Guid("7c67d165-1560-4684-8adc-3f9e2cd5513a"),
                            Price = 60.0,
                            VendorId = new Guid("d4bd707d-6d07-4730-a179-69256c819983")
                        },
                        new
                        {
                            Id = new Guid("9fd43134-1966-4e2b-9f51-a23044f8edfd"),
                            BuildId = new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"),
                            Details = "",
                            Name = "MSI A530M-A PRO",
                            PartId = new Guid("90a8eadc-a3a7-4f0e-8d6f-7f930fb9dc20"),
                            Price = 91.75,
                            VendorId = new Guid("e846cc3a-3bf1-4c2d-b139-5b54f9834aec")
                        },
                        new
                        {
                            Id = new Guid("5901e2cf-bf85-4b75-a9d2-6131139c3b5a"),
                            BuildId = new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"),
                            Details = "2x8gb DDR4 3200",
                            Name = "Team T-Force",
                            PartId = new Guid("d8d59d14-4275-4af8-92dc-ce88c8c94fa6"),
                            Price = 45.149999999999999,
                            VendorId = new Guid("b06a0d5f-6e69-46c7-a2b4-e63c30b2e4d4")
                        },
                        new
                        {
                            Id = new Guid("70ceed4c-458a-447b-8b2f-ee5461cf61cd"),
                            BuildId = new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"),
                            Details = "700 watt 80+ Bronze",
                            Name = "Deep Cool DA700",
                            PartId = new Guid("27f66724-0cc1-4968-b3ee-6f4460c1ab33"),
                            Price = 35.0,
                            VendorId = new Guid("d4bd707d-6d07-4730-a179-69256c819983")
                        },
                        new
                        {
                            Id = new Guid("4fc141cf-9afe-4d60-9231-36600895c0ec"),
                            BuildId = new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"),
                            Details = "mATX",
                            Name = "DIYPC ARGB-Q3",
                            PartId = new Guid("ecef90a2-ab8b-48f4-a379-430f1cad9140"),
                            Price = 101.68000000000001,
                            VendorId = new Guid("b06a0d5f-6e69-46c7-a2b4-e63c30b2e4d4")
                        },
                        new
                        {
                            Id = new Guid("10f3cc43-ddae-4a36-8590-66f90060220b"),
                            BuildId = new Guid("292b2323-903f-4ce4-a579-001755ae5c1b"),
                            Details = "1tb m.2 NVMw",
                            Name = "ORICO SSD",
                            PartId = new Guid("dcff96b3-a4c6-4454-8d89-dbb70562d712"),
                            Price = 67.790000000000006,
                            VendorId = new Guid("2d818341-be49-420b-ae01-d375c460756a")
                        },
                        new
                        {
                            Id = new Guid("3eadd160-85a8-47ba-808d-a333ded9ec83"),
                            Details = "",
                            Name = "Ryzen 5 2600",
                            PartId = new Guid("d3287e4b-189a-4f55-b5c5-898434ec2ffc"),
                            Price = 15.0,
                            VendorId = new Guid("d4bd707d-6d07-4730-a179-69256c819983")
                        },
                        new
                        {
                            Id = new Guid("3b59a8da-9bb1-4c1b-915d-576ed0cc99db"),
                            Details = "",
                            Name = "GIGABYTE GTX 1070ti",
                            PartId = new Guid("7c67d165-1560-4684-8adc-3f9e2cd5513a"),
                            Price = 90.0,
                            VendorId = new Guid("d4bd707d-6d07-4730-a179-69256c819983")
                        });
                });

            modelBuilder.Entity("FlipIt.API.Models.Part", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PartName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d3287e4b-189a-4f55-b5c5-898434ec2ffc"),
                            PartName = "CPU"
                        },
                        new
                        {
                            Id = new Guid("7c67d165-1560-4684-8adc-3f9e2cd5513a"),
                            PartName = "GPU"
                        },
                        new
                        {
                            Id = new Guid("90a8eadc-a3a7-4f0e-8d6f-7f930fb9dc20"),
                            PartName = "MOBO"
                        },
                        new
                        {
                            Id = new Guid("27f66724-0cc1-4968-b3ee-6f4460c1ab33"),
                            PartName = "PSU"
                        },
                        new
                        {
                            Id = new Guid("dcff96b3-a4c6-4454-8d89-dbb70562d712"),
                            PartName = "STORAGE"
                        },
                        new
                        {
                            Id = new Guid("ecef90a2-ab8b-48f4-a379-430f1cad9140"),
                            PartName = "CASE"
                        },
                        new
                        {
                            Id = new Guid("d8d59d14-4275-4af8-92dc-ce88c8c94fa6"),
                            PartName = "MEMORY"
                        },
                        new
                        {
                            Id = new Guid("11ecb302-3f35-44f0-9d32-4a63d421e8dc"),
                            PartName = "COOLER"
                        });
                });

            modelBuilder.Entity("FlipIt.API.Models.Vendor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d4bd707d-6d07-4730-a179-69256c819983"),
                            VendorName = "Facebook MarketPlace"
                        },
                        new
                        {
                            Id = new Guid("e846cc3a-3bf1-4c2d-b139-5b54f9834aec"),
                            VendorName = "eBay"
                        },
                        new
                        {
                            Id = new Guid("b06a0d5f-6e69-46c7-a2b4-e63c30b2e4d4"),
                            VendorName = "Newegg"
                        },
                        new
                        {
                            Id = new Guid("2d818341-be49-420b-ae01-d375c460756a"),
                            VendorName = "Amazon"
                        },
                        new
                        {
                            Id = new Guid("674a8043-7458-4670-83cb-441bfcd422dd"),
                            VendorName = "Jawa"
                        },
                        new
                        {
                            Id = new Guid("8926f78c-1a13-4824-9cd8-a7185ccbecac"),
                            VendorName = "AliExpress"
                        },
                        new
                        {
                            Id = new Guid("9f7ff836-eca7-4f46-a42e-e9ae833cd2a1"),
                            VendorName = "Other"
                        });
                });

            modelBuilder.Entity("FlipIt.API.Models.Component", b =>
                {
                    b.HasOne("FlipIt.API.Models.Build", "Build")
                        .WithMany("Components")
                        .HasForeignKey("BuildId");

                    b.HasOne("FlipIt.API.Models.Part", "Part")
                        .WithMany()
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlipIt.API.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Build");

                    b.Navigation("Part");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("FlipIt.API.Models.Build", b =>
                {
                    b.Navigation("Components");
                });
#pragma warning restore 612, 618
        }
    }
}
