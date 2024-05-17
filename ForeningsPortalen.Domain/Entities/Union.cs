using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Union : Entity
    {
        public Union() : base(Guid.NewGuid())
        {
        }

        public Union(Guid id, string name, List<Address> addressInformation, Board? board, List<User> users) : base(id)
        {
            this.name = name;
            AddressInformation = addressInformation;
            Board = board;
            Users = users;
        }
        public string name { get; set; }
        public List<Address> AddressInformation { get; set; }
        public Board? Board { get; set; }
        public List<User> Users { get; set; }
    }
}
