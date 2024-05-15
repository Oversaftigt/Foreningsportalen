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
        void IUserCommands.CreateUser(UserCreateRequestDto userCreateDto)
        {

            var newUser = Domain.Entities.User.Create(userCreateDto.Email, userCreateDto.PhoneNumber);
            _UserRepository.AddUser(newUser);
        }

        void IUserCommands.DeleteUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        void IUserCommands.UpdateUser(UserUpdateRequestDto userEditDto)
        {
            throw new NotImplementedException();
        }

    }
}
