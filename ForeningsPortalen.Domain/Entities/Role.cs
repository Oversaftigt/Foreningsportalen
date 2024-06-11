using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Role : Entity
    {
        protected Role() { }

        internal Role(string roleName)
        {
            Name = roleName;
        }
        public Guid RoleId { get; private set; }
        public string Name { get; private set; }
        public bool IsBoardPosition { get; private set; }
        public ICollection<UserRoleHistory> UserHistories { get; private set; }

        public static Role CreateRole(string roleName)
        {
            var newRole = new Role(roleName);
            return newRole;
        }
    }
}

