using ForeningsPortalen.Application.Features.Users.Queries.Implementations;
using ForeningsPortalen.Application.Features.Users.Queries;
using Microsoft.Extensions.DependencyInjection;
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

namespace ForeningsPortalen.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserQuery, UserQuery>();
            services.AddScoped<IUserCommands, UserCommands>();
            services.AddScoped<IUnionCommands, UnionCommand>();
            services.AddScoped<IUnionQuery, IUnionQuery>();
            return services;
        }
    }
}
