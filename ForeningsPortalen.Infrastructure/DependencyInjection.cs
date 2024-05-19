using ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces;
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
using ForeningsPortalen.Application.Features.Addresses.Commands.Implementations;
using ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Boards.Commands.Implementations;
using ForeningsPortalen.Application.Features.Boards.Commands;
using ForeningsPortalen.Application.Features.Bookings.Commands.Implementations;
using ForeningsPortalen.Application.Features.Bookings.Commands;
using ForeningsPortalen.Application.Features.BookingUnits.Commands.Implementations;
using ForeningsPortalen.Application.Features.BookingUnits.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Categories.Commands.Implementations;
using ForeningsPortalen.Application.Features.Categories.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Documents.Commands.Implementations;
using ForeningsPortalen.Application.Features.Documents.Commands;
using ForeningsPortalen.Application.Features.Roles.Commands.Implementations;
using ForeningsPortalen.Application.Features.Roles.Commands;
using ForeningsPortalen.Application.Features.Unions.Commands.Implementations;
using ForeningsPortalen.Application.Features.Unions.Commands;
using ForeningsPortalen.Application.Features.UserRoleHistories.Commands.Implementaions;
using ForeningsPortalen.Application.Features.UserRoleHistories.Commands;
using ForeningsPortalen.Application.Features.UserRoles.Commands.Implementations;
using ForeningsPortalen.Application.Features.UserRoles.Commands;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.Implementations;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.Implementations;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands;
using ForeningsPortalen.Application.Features.Boards.Queries;
using ForeningsPortalen.Application.Features.Bookings.Queries;
using ForeningsPortalen.Application.Features.BookingUnits.Queries.Interfaces;
using ForeningsPortalen.Application.Features.Categories.Queries.Interfaces;
using ForeningsPortalen.Application.Features.Documents.Queries;
using ForeningsPortalen.Application.Features.Roles.Queries;
using ForeningsPortalen.Application.Features.UserRoleHistories.Queries;
using ForeningsPortalen.Application.Features.UserRoles.Queries;

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
            //Update-Database -Context ForeningsPortalenContext -Project ForeningsPortalen.DatabaseMigration

            services.AddDbContext<ForeningsPortalenContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ForeningsPortalen_test"),
                    x =>
                        x.MigrationsAssembly("ForeningsPortalen.DatabaseMigration")));

            //Queries
            services.AddScoped<IUserQueries, UserQueries>();
            services.AddScoped<IAddressQueries, AddressQueries>();
            services.AddScoped<IMemberQueries, MemberQueries>();
            services.AddScoped<IUnionQueries, UnionQueries>();
            services.AddScoped<IBoardQueries, BoardQueries>();
            services.AddScoped<IBookingQueries, BookingQueries>();
            services.AddScoped<IBookingUnitQueries, BookingUnitQueries>();
            services.AddScoped<ICategoryQueries, CategoryQueries>();
            services.AddScoped<IDocumentQueries, DocumentQueries>();
            services.AddScoped<IRoleQueries, RoleQueries>();
            services.AddScoped<IUserRoleHistoryQueries, UserRoleHistoryQueries>();
            services.AddScoped<IUserRoleQueries, UserRoleQueries>();


            //Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IUnionRepository, UnionRepository>();
            services.AddScoped<IBoardRepository, BoardRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRoleHistoryRepository, UserRoleHistoryRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();



            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IUnionQueries, UnionQueries>();
            services.AddScoped<IUnionRepository, UnionRepository>();


            return services;
        }
    }
}
