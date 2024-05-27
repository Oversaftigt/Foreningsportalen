using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class UserRoleHistory : Entity
    {
        protected UserRoleHistory()
        {
        }

        internal UserRoleHistory(User user, Role role, DateOnly fromDate)
        {
            User = user;
            Role = role;
            FromDate = fromDate;
        }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; }

        public DateOnly FromDate { get; set; }
        public DateOnly? ToDate { get; set; }

        public static UserRoleHistory CreateUserRoleHistory(User user, Role role, DateOnly fromDate)
        {
            var newUserRoleHistory = new UserRoleHistory(user, role, fromDate);
            return newUserRoleHistory;
        }

    }
}