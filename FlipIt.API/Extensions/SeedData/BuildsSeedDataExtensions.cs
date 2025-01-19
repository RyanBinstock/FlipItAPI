using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlipIt.API.Models;

namespace FlipIt.API.Extensions.SeedData
{
    public static class BuildsSeedDataExtensions
    {
        public static DataBuilder<Build> AddSeedData(this EntityTypeBuilder<Build> entity)
        {
            return entity.HasData(
                new Build()
                {
                    Id = Guid.Parse("292b2323-903f-4ce4-a579-001755ae5c1b"),
                    Description = "First PC Flip!"
                });
        }
    }
}
