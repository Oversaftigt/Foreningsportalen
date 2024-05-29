using ForeningsPortalen.Application.Features.Addresses.Queries;
using ForeningsPortalen.Application.Features.Bookings.Queries;
using ForeningsPortalen.Application.Features.BookingUnits.Queries;
using ForeningsPortalen.Application.Features.Categories.Queries;
using ForeningsPortalen.Application.Features.Documents.Queries;
using ForeningsPortalen.Application.Features.Roles.Queries;
using ForeningsPortalen.Application.Features.Unions.Queries;
using ForeningsPortalen.Application.Features.UserRoleHistories.Queries;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Queries;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Validation;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using ForeningsPortalen.Infrastructure.DomainServices;
using ForeningsPortalen.Infrastructure.Queries;
using ForeningsPortalen.Infrastructure.Repositories;
using ForeningsPortalen.Infrastructure.ThirdPartyIntegrations;
using Microsoft.EntityFrameworkCore;
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

            // Add-Migration InitialMigration -Context ForeningsPortalenContext -Project ForeningsPortalen.DatabaseMigration
            //Update-Database -Context ForeningsPortalenContext -Project ForeningsPortalen.DatabaseMigration

            services.AddDbContext<ForeningsPortalenContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ForeningsPortalenDbConnection"),
                    x =>
                        x.MigrationsAssembly("ForeningsPortalen.DatabaseMigration")));

            //DomainServices
            services.AddScoped<IBookingDomainService, BookingDomainService>();
            services.AddScoped<ICategoryDomainService, CategoryDomainService>();
            services.AddScoped<IBookingUnitDomainService, BookingUnitDomainService>();

            //Queries
            services.AddScoped<IUserQueries, UserQueries>();
            services.AddScoped<IAddressQueries, AddressQueries>();
            services.AddScoped<IMemberQueries, MemberQueries>();
            services.AddScoped<IUnionQueries, UnionQueries>();
            services.AddScoped<IBookingQueries, BookingQueries>();
            services.AddScoped<IBookingUnitQueries, BookingUnitQueries>();
            services.AddScoped<ICategoryQueries, CategoryQueries>();
            services.AddScoped<IDocumentQueries, DocumentQueries>();
            services.AddScoped<IRoleQueries, RoleQueries>();
            services.AddScoped<IUserRoleHistoryQueries, UserRoleHistoryQueries>();


            //Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IUnionRepository, UnionRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IBookingUnitRepository, BookingUnitRepository>();
            services.AddScoped<IDocumentRepository, DocumentRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRoleHistoryRepository, UserRoleHistoryRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            //Third party integration
            services.AddScoped<IDawaAddressValidationService, DawaAddressValidationService>();


            return services;
        }
    }
}
