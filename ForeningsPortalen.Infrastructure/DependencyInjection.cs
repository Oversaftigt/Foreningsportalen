using ForeningsPortalen.Application.Features.Users.Commands.Implementations;
using ForeningsPortalen.Application.Features.Users.Commands;
using ForeningsPortalen.Application.Features.Users.Repositories;
using ForeningsPortalen.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeningsPortalen.Application.Features.Users.Queries;
using Microsoft.Extensions.Configuration;
using ForeningsPortalen.Infrastructure.Queries;
using ForeningsPortalen.Application.Features.Unions.Queries;

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
          //  services.AddScoped<IUnionQueries, UnionQueries>();
            

            return services;
        }
    }
}
