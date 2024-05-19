using ForeningsPortalen.Application.Features.Addresses.Commands.Implementations;
using ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Boards.Commands;
using ForeningsPortalen.Application.Features.Boards.Commands.Implementations;
using ForeningsPortalen.Application.Features.Bookings.Commands;
using ForeningsPortalen.Application.Features.Bookings.Commands.Implementations;
using ForeningsPortalen.Application.Features.BookingUnits.Commands.Implementations;
using ForeningsPortalen.Application.Features.BookingUnits.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Categories.Commands.Implementations;
using ForeningsPortalen.Application.Features.Categories.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Documents.Commands;
using ForeningsPortalen.Application.Features.Documents.Commands.Implementations;
using ForeningsPortalen.Application.Features.Roles.Commands;
using ForeningsPortalen.Application.Features.Roles.Commands.Implementations;
using ForeningsPortalen.Application.Features.Unions.Commands;
using ForeningsPortalen.Application.Features.Unions.Commands.Implementations;
using ForeningsPortalen.Application.Features.UserRoleHistories.Commands;
using ForeningsPortalen.Application.Features.UserRoleHistories.Commands.Implementaions;
using ForeningsPortalen.Application.Features.UserRoles.Commands;
using ForeningsPortalen.Application.Features.UserRoles.Commands.Implementations;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.Implementations;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace ForeningsPortalen.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserCommands, UserCommands>();
            services.AddScoped<IAddressCommands, AddressCommands>();
            services.AddScoped<IUnionCommands, UnionCommand>();
            services.AddScoped<IMemberCommands, MemberCommands>();
            services.AddScoped<IBoardCommands, BoardCommands>();
            services.AddScoped<IBookingCommands, BookingCommands>();
            services.AddScoped<IBookingUnitCommands, BookingUnitCommands>();
            services.AddScoped<ICategoryCommands, CategoryCommands>();
            services.AddScoped<IDocumentCommands, DocumentCommands>();
            services.AddScoped<IRoleCommands, RoleCommands>();
            services.AddScoped<IUserRoleHistoryCommands, UserRoleHistoryCommands>();
            services.AddScoped<IUserRoleCommands, UserRoleCommands>();

            return services;
        }
    }
}
