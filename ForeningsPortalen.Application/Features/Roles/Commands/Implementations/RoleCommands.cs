using ForeningsPortalen.Application.Features.Helpers;
using ForeningsPortalen.Application.Features.Roles.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Roles.Commands.Implementations
{
    public class RoleCommands : IRoleCommands
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUnitOfWork _unitOfWork;
        public RoleCommands(IRoleRepository roleRepository, IUnitOfWork unitOfWork)
        {
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        void IRoleCommands.CreateRoles(RoleCreateRequestDto roleCreateRequestDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var newRole = Role.CreateRole(roleCreateRequestDto.RoleName);

                _roleRepository.AddRole(newRole);
                _unitOfWork.Commit();
            }
            catch
            {
                try
                {
                    _unitOfWork?.Rollback();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Rollback has failed: {ex.Message}");
                }
            }
        }

        void IRoleCommands.DeleteRoles(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

        void IRoleCommands.UpdateRoles(RoleUpdateRequestDto roleUpdateRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
