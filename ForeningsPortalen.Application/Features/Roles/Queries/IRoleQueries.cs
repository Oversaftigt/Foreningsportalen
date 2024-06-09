using ForeningsPortalen.Application.Features.Roles.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Roles.Queries
{
    public interface IRoleQueries
    {
        /// <summary>
        /// Get a list of all roles
        /// </summary>
        /// <returns></returns>
        IEnumerable<RoleQueryResultDto> GetAllRoles();
    }
}
