using FlipIt.API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlipIt.API.Extensions.SeedData
{
    public static class ComponentsSeedDataExtensions
    {
        public static DataBuilder<Component> AddSeedData(this EntityTypeBuilder<Component> entity)
        {
            return entity.HasData(
                new Component()
                {
                    Id = Guid.Parse("bfb6188a-5dfa-473e-95c0-f523eea43e12"),
                    BuildId = Guid.Parse("292b2323-903f-4ce4-a579-001755ae5c1b"),
                    PartId = Guid.Parse("d3287e4b-189a-4f55-b5c5-898434ec2ffc"), // CPU
                    Name = "Ryzen 5 3600",
                    Price = 50.00,
                    Details = "",
                    VendorId = Guid.Parse("d4bd707d-6d07-4730-a179-69256c819983") // MARKETPLACE
                },
                new Component()
                {
                    Id = Guid.Parse("ade6e1e6-3a24-4803-b4dc-13dd43cc42cf"),
                    BuildId = Guid.Parse("292b2323-903f-4ce4-a579-001755ae5c1b"),
                    PartId = Guid.Parse("11ecb302-3f35-44f0-9d32-4a63d421e8dc"), // COOLER
                    Name = "AIGO ICEPRO200",
                    Price = 16.38,
                    Details = "white rgb heatsink",
                    VendorId = Guid.Parse("8926f78c-1a13-4824-9cd8-a7185ccbecac") // ALIEXPRESS
                },
                new Component()
                {
                    Id = Guid.Parse("562bd3bc-043f-4505-be2f-aed42f4b47d9"),
                    BuildId = Guid.Parse("292b2323-903f-4ce4-a579-001755ae5c1b"),
                    PartId = Guid.Parse("7c67d165-1560-4684-8adc-3f9e2cd5513a"), // GPU
                    Name = "RADEON RX 580",
                    Price = 60.00,
                    Details = "8gb",
                    VendorId = Guid.Parse("d4bd707d-6d07-4730-a179-69256c819983")
                },
                new Component()
                {
                    Id = Guid.Parse("9fd43134-1966-4e2b-9f51-a23044f8edfd"),
                    BuildId = Guid.Parse("292b2323-903f-4ce4-a579-001755ae5c1b"),
                    PartId = Guid.Parse("90a8eadc-a3a7-4f0e-8d6f-7f930fb9dc20"), // MOBO
                    Name = "MSI A530M-A PRO",
                    Price = 91.75,
                    Details = "",
                    VendorId = Guid.Parse("e846cc3a-3bf1-4c2d-b139-5b54f9834aec")
                },

                new Component()
                {
                    Id = Guid.Parse("5901e2cf-bf85-4b75-a9d2-6131139c3b5a"),
                    BuildId = Guid.Parse("292b2323-903f-4ce4-a579-001755ae5c1b"),
                    PartId = Guid.Parse("d8d59d14-4275-4af8-92dc-ce88c8c94fa6"), // MEMORY
                    Name = "Team T-Force",
                    Price = 45.15,
                    Details="2x8gb DDR4 3200",
                    VendorId = Guid.Parse("b06a0d5f-6e69-46c7-a2b4-e63c30b2e4d4") // NEWEGG

                },
                new Component()
                {
                    Id = Guid.Parse("70ceed4c-458a-447b-8b2f-ee5461cf61cd"),
                    BuildId = Guid.Parse("292b2323-903f-4ce4-a579-001755ae5c1b"),
                    PartId = Guid.Parse("27f66724-0cc1-4968-b3ee-6f4460c1ab33"), // PSU
                    Name = "Deep Cool DA700",
                    Price = 35.00,
                    Details = "700 watt 80+ Bronze",
                    VendorId = Guid.Parse("d4bd707d-6d07-4730-a179-69256c819983"), // MARKETPLACE
                },
                new Component()
                {
                    Id = Guid.Parse("4fc141cf-9afe-4d60-9231-36600895c0ec"),
                    BuildId = Guid.Parse("292b2323-903f-4ce4-a579-001755ae5c1b"),
                    PartId = Guid.Parse("ecef90a2-ab8b-48f4-a379-430f1cad9140"), // CASE
                    Name = "DIYPC ARGB-Q3",
                    Price = 101.68,
                    Details = "mATX",
                    VendorId = Guid.Parse("b06a0d5f-6e69-46c7-a2b4-e63c30b2e4d4") // NEWEGG
                },
                new Component()
                {
                    Id = Guid.Parse("10f3cc43-ddae-4a36-8590-66f90060220b"),
                    BuildId = Guid.Parse("292b2323-903f-4ce4-a579-001755ae5c1b"),
                    PartId = Guid.Parse("dcff96b3-a4c6-4454-8d89-dbb70562d712"), //STORAGE
                    Name = "ORICO SSD",
                    Price = 67.79,
                    Details = "1tb m.2 NVMe",
                    VendorId = Guid.Parse("2d818341-be49-420b-ae01-d375c460756a")
                },
                new Component()
                {
                    Id = Guid.Parse("3eadd160-85a8-47ba-808d-a333ded9ec83"),
                    PartId = Guid.Parse("d3287e4b-189a-4f55-b5c5-898434ec2ffc"),
                    Name = "Ryzen 5 2600",
                    Price = 15.00,
                    Details = "",
                    VendorId = Guid.Parse("d4bd707d-6d07-4730-a179-69256c819983")
                },
                new Component()
                {
                    Id = Guid.Parse("3b59a8da-9bb1-4c1b-915d-576ed0cc99db"),
                    PartId = Guid.Parse("7c67d165-1560-4684-8adc-3f9e2cd5513a"),
                    Name = "GIGABYTE GTX 1070ti",
                    Price = 90.00,
                    Details = "",
                    VendorId = Guid.Parse("d4bd707d-6d07-4730-a179-69256c819983")
                });
        }
    }
}
