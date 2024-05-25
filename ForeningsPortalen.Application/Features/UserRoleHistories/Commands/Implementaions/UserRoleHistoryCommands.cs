using ForeningsPortalen.Application.Features.Helpers;
using ForeningsPortalen.Application.Features.UserRoleHistories.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.UserRoleHistories.Commands.Implementaions
{
    public class UserRoleHistoryCommands : IUserRoleHistoryCommands
    {
        private readonly IUserRoleHistoryRepository _userRoleHistoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _RoleRepository;

        public UserRoleHistoryCommands(IUserRoleHistoryRepository userRoleHistoryRepository, IUnitOfWork unitOfWork, IUserRepository userRepository, IRoleRepository roleRepository)
        {
            _userRoleHistoryRepository = userRoleHistoryRepository;
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _RoleRepository = roleRepository;
        }

        void IUserRoleHistoryCommands.CreateUserRoleHistory(UserRoleHistoryCreateRequestDto userRoleHistoryCreateRequestDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var user = _userRepository.GetUser(userRoleHistoryCreateRequestDto.UserId);
                if (user == null)
                {
                    throw new ArgumentNullException();
                }

                var role = _RoleRepository.GetRole(userRoleHistoryCreateRequestDto.RoleId);
                if (role == null)
                {
                    throw new ArgumentNullException();
                }


                var newUserRoleHistory = UserRoleHistory.CreateUserRoleHistory(user, role,
                    userRoleHistoryCreateRequestDto.RoleAssigned);

                _userRoleHistoryRepository.AddUserRoleHistory(newUserRoleHistory);
                _unitOfWork.Commit();
            }
            catch
            {
                try
                {
                    _unitOfWork.Rollback();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Rollback has failed: {ex.Message}");
                }
            }
        }

        void IUserRoleHistoryCommands.DeleteUserRoleHistory(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

        void IUserRoleHistoryCommands.UpdateUserRoleHistory(UserRoleHistoryUpdateRequestDto userRoleHistoryUpdateRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
