using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class UserRoleHistory : Entity
    {
        public UserRoleHistory()
        {
        }

        internal UserRoleHistory(User user, Role role, DateOnly fromDate, DateOnly toDate)
        {
            User = user;
            Role = role;
            FromDate = fromDate;
            ToDate = toDate;
        }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; }

        public DateOnly FromDate { get; set; }
        public DateOnly ToDate { get; set; }

        public static UserRoleHistory CreateUserRoleHistory(User user, Role role, DateOnly fromDate, DateOnly toDate)
        {
            var newUserRoleHistory = new UserRoleHistory(user, role, fromDate, toDate);
            return newUserRoleHistory;
        }

    }
}