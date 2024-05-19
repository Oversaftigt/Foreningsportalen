using ForeningsPortalen.Application.Features.UserRoles.Queries;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class UserRoleQueries : IUserRoleQueries
    {
        private readonly ForeningsPortalenContext _dbContext;
        public UserRoleQueries(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
