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
        public Guid RoleId { get; set; }
        public string Name { get; set; }
        public bool IsBoardPosition { get; set; }
        public ICollection<UserRoleHistory> UserHistories { get; set; }

        public static Role CreateRole(string roleName)
        {
            var newRole = new Role(roleName);
            return newRole;
        }
    }
}

