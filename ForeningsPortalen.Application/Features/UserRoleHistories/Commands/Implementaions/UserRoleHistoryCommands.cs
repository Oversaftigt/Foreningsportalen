using ForeningsPortalen.Application.Features.Helpers;
using ForeningsPortalen.Application.Features.UserRoles.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;
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
        private readonly IUnitOfWork _unitOfWork;

        public UserRoleHistoryCommands(IUserRoleHistoryRepository userRoleHistoryRepository, IUnitOfWork unitOfWork)
        {
            _userRoleHistoryRepository = userRoleHistoryRepository;
            _unitOfWork = unitOfWork;
        }

        void IUserRoleHistoryCommands.CreateUserRoleHistory(UserRoleCreateRequestDto userRoleCreateRequestDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var newUserRoleHistory = UserRoleHistory.CreateUserRoleHistory(userRoleCreateRequestDto.UserId, userRoleCreateRequestDto.RoleId, 
                    userRoleCreateRequestDto.RoleAssigned, userRoleCreateRequestDto.RoleUnassigned);

                _userRoleHistoryRepository.AddUserRoleHistory(newUserRoleHistory);
                _unitOfWork.Commit();
            }
            catch
            {
                try
                {
                    _unitOfWork.Rollback();
                }
                catch(Exception ex)
                {
                    throw new Exception($"Rollback has failed: {ex.Message}");
                }
            }
        }

        void IUserRoleHistoryCommands.DeleteUserRoleHistory(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

        void IUserRoleHistoryCommands.UpdateUserRoleHistory(UserRoleUpdateRequestDto userRoleUpdateRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
