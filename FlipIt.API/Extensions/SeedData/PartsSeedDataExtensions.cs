using FlipIt.API.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlipIt.API.Extensions
{
    public static class PartsSeedDataExtensions
    {
        public static DataBuilder<Part> AddSeedData(this EntityTypeBuilder<Part> entity)
        {
            return entity.HasData(
                new Part()
                {
                    Id = Guid.Parse("d3287e4b-189a-4f55-b5c5-898434ec2ffc"),
                    PartName = "CPU"
                },
                new Part()
                {
                    Id = Guid.Parse("7c67d165-1560-4684-8adc-3f9e2cd5513a"),
                    PartName = "GPU"
                },
                new Part()
                {
                    Id = Guid.Parse("90a8eadc-a3a7-4f0e-8d6f-7f930fb9dc20"),
                    PartName = "MOBO"
                },
                new Part()
                {
                    Id = Guid.Parse("27f66724-0cc1-4968-b3ee-6f4460c1ab33"),
                    PartName = "PSU"
                },
                new Part()
                {
                    Id = Guid.Parse("dcff96b3-a4c6-4454-8d89-dbb70562d712"),
                    PartName = "STORAGE"
                },
                new Part()
                {
                    Id = Guid.Parse("ecef90a2-ab8b-48f4-a379-430f1cad9140"),
                    PartName = "CASE"
                },
                new Part()
                {
                    Id = Guid.Parse("d8d59d14-4275-4af8-92dc-ce88c8c94fa6"),
                    PartName = "MEMORY"
                },
                new Part()
                {
                    Id = Guid.Parse("11ecb302-3f35-44f0-9d32-4a63d421e8dc"),
                    PartName = "COOLER"
                });
        }
    }
}






