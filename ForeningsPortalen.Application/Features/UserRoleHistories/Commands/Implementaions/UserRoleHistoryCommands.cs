using ForeningsPortalen.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.UserRoleHistories.Commands.Implementaions
{
    public class UserRoleHistoryCommands : IUserRoleHistoryCommands
    {
        private readonly IUserRoleHistoryRepository _userRoleHistoryRepository;

        public UserRoleHistoryCommands(IUserRoleHistoryRepository userRoleHistoryRepository)
        {
            _userRoleHistoryRepository = userRoleHistoryRepository;
        }
    }
}
