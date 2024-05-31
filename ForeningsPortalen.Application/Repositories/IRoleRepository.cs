using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IRoleRepository
    {
        void AddRole(Role role);
        void UpdateRole(Role role, byte[] rowversion);
        void DeleteRole(Role role, byte[] rowversion);
        Role GetRole(Guid id);
    }
}
