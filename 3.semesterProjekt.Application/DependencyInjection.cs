using _3.semesterProjekt.Application.Features.Users.Queries;
using _3.semesterProjekt.Application.Features.Users.Queries.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserQuery, UserQuery>();

            return services;
        }
    }
}
