﻿using ForeningsPortalen.Application.Features.Addresses.Commands.Implementations;
using ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Addresses.Queries.Implementations;
using ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces;
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
            services.AddScoped<IAddressCommand, AddressCommand>();
            services.AddScoped<IAddressQuery, AddressQuery>();

            services.AddScoped<IMemberCommands, MemberCommands>();
            return services;
        }
    }
}
