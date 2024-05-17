﻿
using ForeningsPortalen.Application.Features.Users.BaseUsers.Queries;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Repositories;
using ForeningsPortalen.Infrastructure.Queries;
using ForeningsPortalen.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeningsPortalen.Application.Features.Users.Queries;
using Microsoft.Extensions.Configuration;
using ForeningsPortalen.Infrastructure.Queries;
using ForeningsPortalen.Application.Features.Addresses.Repositories;
using ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Repositories;
using ForeningsPortalen.Application.Features.Unions.Queries;
using ForeningsPortalen.Application.Features.Unions.Repositories;

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

            //Queries
            services.AddScoped<IUserQueries, UserQueries>();
            services.AddScoped<IAddressQueries, AddressQueries>();
            services.AddScoped<IUnionMemberQueries, UnionMemberQueries>();

            //Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IUnionMemberRepository, UnionMemberRepository>();
           
            //services.AddScoped<IUnitOfWork, IUnitOfWork>();


        
            
            services.AddScoped<IUnionQueries, UnionQueries>();
            services.AddScoped<IUnionRepository, UnionRepository>();
            

            return services;
        }
    }
}
