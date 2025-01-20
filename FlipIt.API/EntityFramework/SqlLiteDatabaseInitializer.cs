namespace FlipIt.API.EntityFramework
{
    public class SqlLiteDatabaseInitializer
    {
        public SqlLiteDatabaseInitializer(FlipItDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
