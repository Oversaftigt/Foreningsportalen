using _3.semesterProjekt.Application.Features.Helpers;
using _3.semesterProjekt.Application.Features.Users.Commands;
using _3.semesterProjekt.Application.Features.Users.Commands.Implementations;
using _3.semesterProjekt.Application.Features.Users.Queries;
using _3.semesterProjekt.Application.Features.Users.Queries.Implementations;
using _3.semesterProjekt.Application.Features.Users.Repositories;
using _3.semesterProjekt.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services
        /*IConfiguration configuration*/)
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

            
            //services.AddScoped<IUserQueries, UserQueries>();
            //services.AddScoped<IUnitOfWork, IUnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserCommands, UserCommands>();

            return services;
        }
    }
}
