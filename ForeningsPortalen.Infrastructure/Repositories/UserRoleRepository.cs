using ForeningsPortalen.Application.Features.UserRoles.Repositories;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ForeningsPortalenContext _dbCopntext;
        public UserRoleRepository(ForeningsPortalenContext dbContext)
        {
            _dbCopntext = dbContext;
        }
    }
}
