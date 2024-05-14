using _3.semesterProjekt.Application.Features.Users.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Users.Queries.Implementations
{
    internal class UserQuery : IUserQuery
    { 
        public Task<UserDto> GetUserById(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetUsersByUnionId(Guid unionId)
        {
            throw new NotImplementedException();
        }
    }
}
