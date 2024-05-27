using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Role;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleQueryRequestDto>> GetAllRolesAsync();
    }
}