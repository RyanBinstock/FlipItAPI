using FlipIt.API.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FlipIt.API.EntityFramework
{
    public class FlipItDbContextFactory : IDesignTimeDbContextFactory<FlipItDbContext>
    {
        public FlipItDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FlipItDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FlipIt;MultipleActiveResultSets=True;Trusted_Connection=True",
                op => op.MigrationsHistoryTable(EntityFrameworkConstants.ContextMigrationsTableName, EntityFrameworkConstants.ContextSchema));
        
            return new FlipItDbContext(optionsBuilder.Options);
        }
    }
}
