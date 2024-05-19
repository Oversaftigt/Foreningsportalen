using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUserRoleHistoryRepository
    {
        void AddUserRoleHistory(UserRoleHistory userRoleHistory);
        void DeleteUserRoleHistory(UserRoleHistory userRoleHistory, byte[] rowVersion);
        void UpdateUserRoleHistory(UserRoleHistory userRoleHistory, byte[] rowVersion);
        UserRoleHistory GetUserRoleHistory(Guid id);
    }
}
