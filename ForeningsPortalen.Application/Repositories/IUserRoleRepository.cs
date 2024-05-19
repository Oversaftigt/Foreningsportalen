﻿using ForeningsPortalen.Domain.Entities;
using Microsoft.VisualBasic;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUserRoleRepository
    {
        void AddUserRole(UserRoleHistory userRole);
        void DeleteUserRole(UserRoleHistory userRole, byte[] rowVersion);
        void UpdateUserRole(UserRoleHistory userRole, byte[] rowVersion);
        UserRoleHistory GetUserRole(Guid id);
    }
}