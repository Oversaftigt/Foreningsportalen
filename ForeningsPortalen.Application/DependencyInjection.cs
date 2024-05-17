using Microsoft.Extensions.DependencyInjection;
using ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Addresses.Commands.Implementations;
using ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces;
using ForeningsPortalen.Application.Features.Addresses.Queries.Implementations;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.Implementations;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeningsPortalen.Application.Features.Users.Commands;
using ForeningsPortalen.Application.Features.Users.Commands.Implementations;
using ForeningsPortalen.Application.Features.Unions.Commands;
using ForeningsPortalen.Application.Features.Unions.Commands.Implementations;
using ForeningsPortalen.Application.Features.Unions.Queries;
using ForeningsPortalen.Application.Features.Unions.Queries.Implementations;

namespace ForeningsPortalen.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserCommands, UserCommands>();
         
            
            services.AddScoped<IUnionCommands, UnionCommand>();
            services.AddScoped<IUnionQuery, UnionQuery>();
            services.AddScoped<IAddressCommand, AddressCommand>();
            services.AddScoped<IAddressQuery, AddressQuery>();

            services.AddScoped<IUnionMemberCommands, UnionMemberCommands>();
            return services;
        }
    }
}
