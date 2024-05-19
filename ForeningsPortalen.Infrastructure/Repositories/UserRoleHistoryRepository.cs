using ForeningsPortalen.Application.Features.UserRoleHistories.Repositories;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class UserRoleHistoryRepository : IUserRoleHistoryRepository
    {
        private readonly ForeningsPortalenContext _foreningsPortalenContext;
        public UserRoleHistoryRepository(ForeningsPortalenContext foreningsPortalenContext)
        {
            _foreningsPortalenContext = foreningsPortalenContext;
        }
    }
}
