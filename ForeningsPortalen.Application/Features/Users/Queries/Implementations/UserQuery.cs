using ForeningsPortalen.Application.Features.Users.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.Queries.Implementations
{
    public class UserQuery : IUserQuery
    {
        private readonly IUserQueries _UserQueries;

        public UserQuery(IUserQueries userQueries)
        {
            _UserQueries = userQueries;
        }
        UserQueryResultDto IUserQuery.GetUserById(Guid userId)
        {
            var user = _UserQueries.GetUserById(userId);

            if (user is not null)
            {
                return user;
            }

            var ex = new Exception("No user exists with that Id");
            throw ex;
        }

        IEnumerable<UserQueryResultDto> IUserQuery.GetUsersByUnionId(Guid unionId)
        {
            throw new NotImplementedException();
        }
    }
}
