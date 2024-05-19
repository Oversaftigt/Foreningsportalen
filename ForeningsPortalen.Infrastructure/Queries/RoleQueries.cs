using ForeningsPortalen.Application.Features.Roles.Queries;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class RoleQueries : IRoleQueries
    {
        private readonly ForeningsPortalenContext _dbContext;
        public RoleQueries(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
