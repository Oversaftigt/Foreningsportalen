using _3.semesterProjekt.Application.Features.Users.Commands.DTOs;
using _3.semesterProjekt.Application.Features.Users.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Users.Commands.Implementations
{
    public class UserCommands : IUserCommands
    {
        private readonly IUserRepository _UserRepository;

        public UserCommands(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }
        void IUserCommands.CreateUser(UserCreateRequestDto userCreateRequest)
        {

            var newUser = Domain.Entities.User.Create(userCreateRequest.Email, userCreateRequest.PhoneNumber);
            _UserRepository.AddUser(newUser);
        }

        void IUserCommands.DeleteUser(UserDeleteRequestDto userDeleteRequest)
        {
            var userToDelete = _UserRepository.GetUser(userDeleteRequest.Id);

            if (userToDelete is null)
            {
                throw new Exception("The requested user for deletion does not exist");
            }
            _UserRepository.DeleteUser(userToDelete, userDeleteRequest.RowVersion);
        }

        void IUserCommands.UpdateUser(UserUpdateRequestDto userEditRequest)
        {
            
        }

    }
}
