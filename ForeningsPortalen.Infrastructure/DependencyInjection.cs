﻿using ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces;
using ForeningsPortalen.Application.Features.Unions.Queries;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Queries;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using ForeningsPortalen.Infrastructure.Queries;
using ForeningsPortalen.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

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

            // Add-Migration InitialMigration -Context ForeningsPortalenContext -Project ForeningsPortalen.DatabaseMigration
            // Update-Database -Context ForeningsPortalenContext -Project ForeningsPortalen.DatabaseMigration

            services.AddDbContext<ForeningsPortalenContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ForeningsPortalen_test"),
                    x =>
                        x.MigrationsAssembly("ForeningsPortalen.DatabaseMigration")));

            //Queries
            services.AddScoped<IUserQueries, UserQueries>();
            services.AddScoped<IAddressQueries, AddressQueries>();
            services.AddScoped<IMemberQueries, MemberQueries>();

            //Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IMemberRepository, MemberRepository>();

            //services.AddScoped<IUnitOfWork, IUnitOfWork>();

            services.AddScoped<IUnionQueries, UnionQueries>();
            services.AddScoped<IUnionRepository, UnionRepository>();


            return services;
        }
    }
}
