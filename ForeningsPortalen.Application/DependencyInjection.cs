using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.Implementations;

namespace ForeningsPortalen.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserCommands, UserCommands>();
            return services;
        }
    }
}
