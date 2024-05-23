using ForeningsPortalen.Application.Features.Users.BaseUsers.Queries;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Queries.DTOs;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class UserQueries : IUserQueries
    {
        UserQueryResultDto IUserQueries.GetUserById(Guid userId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserQueryResultDto> IUserQueries.GetUserByUnionId(Guid unionId)
        {
            throw new NotImplementedException();
        }
    }
}
