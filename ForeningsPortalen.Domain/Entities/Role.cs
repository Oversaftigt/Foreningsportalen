using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Role : Entity
    {
        public Role() { }

        internal Role(string roleName)
        {
            RoleName = roleName;
        }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<UserRoleHistory> UserHistories { get; set; } = new List<UserRoleHistory>();
    }
}

