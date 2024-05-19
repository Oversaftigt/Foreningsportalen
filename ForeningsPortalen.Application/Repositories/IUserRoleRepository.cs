using ForeningsPortalen.Domain.Entities;
using Microsoft.VisualBasic;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUserRoleRepository
    {
        void AddUserRole(UserRole userRole);
        void DeleteUserRole(UserRole userRole, byte[] rowVersion);
        void UpdateUserRole(UserRole userRole, byte[] rowVersion);
        UserRole GetUserRole(Guid id);
    }
}