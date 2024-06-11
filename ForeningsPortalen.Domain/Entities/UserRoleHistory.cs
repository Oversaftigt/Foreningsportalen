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
        public Guid UserId { get; private set; }
        public User User { get; private set; }

        public Guid RoleId { get; private set; }
        public Role Role { get; private set; }

        public DateOnly FromDate { get; private set; }
        public DateOnly? ToDate { get; private set; }

        public static UserRoleHistory CreateUserRoleHistory(User user, Role role, DateOnly fromDate)
        {
            var newUserRoleHistory = new UserRoleHistory(user, role, fromDate);
            return newUserRoleHistory;
        }

    }
}