using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Users.Commands.Implementations
{
    public class UserCommands : IUserCommands
    {
        public Task CreateUser(UserCreateRequestDto userCreateDto)
        {
           //UnitOfWork
           //Entities
            throw new NotImplementedException();
        }

        public Task DeleteUser(Guid userId)
        {
            //UnitOfWork
            //Entities
            throw new NotImplementedException();
        }

        public Task UpdateUser(UserEditRequestDto userEditDto)
        {
            //UnitOfWork
            //Entities
            throw new NotImplementedException();
        }
    }
}
