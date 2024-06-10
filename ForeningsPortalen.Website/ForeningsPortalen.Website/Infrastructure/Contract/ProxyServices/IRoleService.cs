using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Role;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IRoleService
    {
        /// <summary>
        /// Get a list of all roles
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<RoleQueryRequestDto>> GetAllRolesAsync();
    }
}