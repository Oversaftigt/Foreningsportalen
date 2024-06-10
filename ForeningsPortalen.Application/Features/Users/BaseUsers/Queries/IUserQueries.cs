using ForeningsPortalen.Application.Features.Users.BaseUsers.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Users.BaseUsers.Queries
{
    public interface IUserQueries
    {
        /// <summary>
        /// Get a list of users, belonging to a specific union, using unionId
        /// </summary>
        /// <param name="unionId"></param>
        /// <returns></returns>
        IEnumerable<UserQueryResultDto> GetUserByUnionId(Guid unionId);

        /// <summary>
        /// Get a specific user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        UserQueryResultDto GetUserById(Guid userId);
    }
}
