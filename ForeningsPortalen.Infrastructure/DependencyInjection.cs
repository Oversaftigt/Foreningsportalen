
using ForeningsPortalen.Application.Features.Users.BaseUsers.Queries;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Repositories;
using ForeningsPortalen.Infrastructure.Queries;
using ForeningsPortalen.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ForeningsPortalen.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
        {
            // Database
            // https://github.com/dotnet/SqlClient/issues/2239
            // https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects?tabs=dotnet-core-cli
            // Add-Migration InitialMigration -Context BookMyHomeContext -Project BookMyHome.DatabaseMigration
            // Update-Database -Context BookMyHomeContext -Project BookMyHome.DatabaseMigration

            //services.AddDbContext<Forenings>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("BookMyHomeDbConnection"),
            //        x =>
            //            x.MigrationsAssembly("BookMyHome.DatabaseMigration")));


            services.AddScoped<IUserQueries, UserQueries>();
            services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IUnitOfWork, IUnitOfWork>();


            return services;
        }
    }
}
