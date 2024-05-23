using ForeningsPortalen.Application.Features.Users.BaseUsers.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Users.BaseUsers.Queries
{
    public interface IUserQueries
    {
        IEnumerable<UserQueryResultDto> GetUserByUnionId(Guid unionId);
        UserQueryResultDto GetUserById(Guid userId);
    }
}
