using ForeningsPortalen.Application.Features.Roles.Repositories;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public RoleRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
