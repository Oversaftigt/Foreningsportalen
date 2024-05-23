using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class User : Entity
    {
        internal User()
        {
        }

        internal User(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }

        //public User(Guid id) : base(id)
        //{
        //}

        public static User Create(string email, string phoneNumber)
        {
            var user = new User(email, phoneNumber);
            return user;
        }

        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<UserRoleHistory> RoleHistories { get; set; } = new List<UserRoleHistory>();


    }
}
