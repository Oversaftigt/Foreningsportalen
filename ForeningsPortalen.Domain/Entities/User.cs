using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class User : Entity
    {
        protected User()
        {
        }

        internal User(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public static User Create(string email, string phoneNumber)
        {
            var user = new User(email, phoneNumber);
            return user;
        }

        public Guid UserId { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public ICollection<UserRoleHistory> RoleHistories { get; private set; }


    }
}
