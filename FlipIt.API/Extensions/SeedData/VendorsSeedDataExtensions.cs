using FlipIt.API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlipIt.API.Extensions.SeedData
{
    public static class VendorsSeedDataExtensions
    {
        public static DataBuilder<Vendor> AddSeedData(this EntityTypeBuilder<Vendor> entity)
        {
            return entity.HasData(
                new Vendor()
                {
                    Id = Guid.Parse("d4bd707d-6d07-4730-a179-69256c819983"),
                    VendorName = "Facebook MarketPlace"
                },
                new Vendor()
                {
                    Id = Guid.Parse("e846cc3a-3bf1-4c2d-b139-5b54f9834aec"),
                    VendorName = "eBay"
                },
                new Vendor()
                {
                    Id = Guid.Parse("b06a0d5f-6e69-46c7-a2b4-e63c30b2e4d4"),
                    VendorName = "Newegg"
                },
                new Vendor()
                {
                    Id = Guid.Parse("2d818341-be49-420b-ae01-d375c460756a"),
                    VendorName = "Amazon"
                },
                new Vendor()
                {
                    Id = Guid.Parse("674a8043-7458-4670-83cb-441bfcd422dd"),
                    VendorName = "Jawa"
                },
                new Vendor()
                {
                    Id = Guid.Parse("8926f78c-1a13-4824-9cd8-a7185ccbecac"),
                    VendorName = "AliExpress"
                }, 
                new Vendor()
                {
                    Id = Guid.Parse("9f7ff836-eca7-4f46-a42e-e9ae833cd2a1"),
                    VendorName = "Other"
                });
        }
    }
}
