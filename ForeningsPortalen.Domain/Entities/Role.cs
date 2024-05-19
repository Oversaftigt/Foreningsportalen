using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Role : Entity
    {
        public Role() : base(Guid.NewGuid()) { }

        public Role(Guid id, string roleName) : base(id)
        {
            RoleName = roleName;
        }

        public string RoleName { get; set; }
        public ICollection<UserRoleHistory> UserHistories { get; set; } = new List<UserRoleHistory>();
    }
}

