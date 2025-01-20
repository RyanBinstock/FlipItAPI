using FlipIt.API.Constants;
using FlipIt.API.EntityFramework;
using FlipIt.API.Interfaces;
using FlipIt.API.Models;
using FlipIt.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlipIt.API.Extensions
{
    public static class DependencyInjectionExtensions
    {
        private static bool PersistenceIsSqlServer(IConfiguration config) => config.GetSection("Persistence")["EfProvider"] == "sqlServer";
        private static bool PersistenceIsLocal(IConfiguration config) => config.GetSection("Persistence")["EfProvider"] == "local";

        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IAsyncRepository<Build>, BuildsRepository>();
            services.AddScoped<IAsyncRepository<Component>, ComponentsRepository>();
            services.AddScoped<IAsyncRepository<Part>, PartsRepository>();
            services.AddScoped<IAsyncRepository<Vendor>, VendorsRepository>();

            return services;
        }

        public static IServiceCollection AddFlipItContext(this IServiceCollection services, IConfiguration config)
        {
            if (PersistenceIsSqlServer(config))
            {
                services.AddDbContext<FlipItDbContext>(options =>
                {
                    options.UseSqlServer(config.GetConnectionString("FlipItDatabase")
                        ?? throw new ApplicationException("No SqlServer databse provided for the FlipIt dbContext to use!"),
                        op => op.MigrationsHistoryTable(EntityFrameworkConstants.ContextMigrationsTableName, EntityFrameworkConstants.ContextSchema));
                });
            }
            else if (PersistenceIsLocal(config))
            {
                services.AddDbContext<FlipItDbContext>(options =>
                {
                    options.UseSqlite("DataSource=file:memdb1?mode=memory&cache=shared");
                });

                services.AddSingleton<SqlLiteConnectionPersistor>();
                services.AddTransient<SqlLiteDatabaseInitializer>();
            }

            return services;
        }
    public static IServiceProvider SetupDatabasePersistence(this IServiceProvider services, IConfiguration config)
        {
            if (PersistenceIsLocal(config))
            {
                using (var scope = services.CreateScope())
                {
                    scope.ServiceProvider.GetRequiredService<SqlLiteConnectionPersistor>();
                    scope.ServiceProvider.GetRequiredService<SqlLiteDatabaseInitializer>();
                }
            }

            return services;
        }
    }
}
