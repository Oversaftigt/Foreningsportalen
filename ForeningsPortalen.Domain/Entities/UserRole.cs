using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class UserRole : Entity
    {
        public UserRole(Guid id) : base(id)
        {
        }

        public DateOnly RoleAssigned { get; set; }
        public DateOnly RoleUnassigned { get; set; }

        public User UserId { get; set; }
        public Role RoleId { get; set; }
    }
}
