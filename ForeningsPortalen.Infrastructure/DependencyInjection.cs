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
using ForeningsPortalen.Application.Features.Boards.Queries;
using ForeningsPortalen.Application.Features.Bookings.Queries;
using ForeningsPortalen.Application.Features.Documents.Queries;
using ForeningsPortalen.Application.Features.Roles.Queries;
using ForeningsPortalen.Application.Features.UserRoleHistories.Queries;
using ForeningsPortalen.Application.Features.UserRoles.Queries;
using ForeningsPortalen.Application.Features.Helpers;
using ForeningsPortalen.Application.Features.Addresses.Queries;
using ForeningsPortalen.Application.Features.BookingUnits.Queries;
using ForeningsPortalen.Application.Features.Categories.Queries;

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
            services.AddScoped<IBookingUnitRepository, BookingUnitRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRoleHistoryRepository, UserRoleHistoryRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();





            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IUnionQueries, UnionQueries>();
            services.AddScoped<IUnionRepository, UnionRepository>();


            return services;
        }
    }
}
