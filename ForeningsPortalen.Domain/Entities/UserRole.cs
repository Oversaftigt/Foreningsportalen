namespace ForeningsPortalen.Domain.Entities
{
    public class UserRole
    {
        public DateOnly RoleAssigned { get; set; }
        public DateOnly RoleUnassigned { get; set; }

        public User UserId { get; set; }
        public Role RoleId { get; set; }
    }
}
