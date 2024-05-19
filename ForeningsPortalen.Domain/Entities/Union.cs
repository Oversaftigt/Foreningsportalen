using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Union : Entity
    {
        internal Union() : base(Guid.NewGuid())
        {
        }

        internal Union(Guid id, string name/*, Board? board, List<User> users*/) : base(id)
        {
            this.name = name;
            //Board = board;
            //Users = users;
        }
        public string name { get; set; }
        public List<Address> Addresses { get; set; }
        //public List<User> Users { get; set; }
        //public Board? Board { get; set; }
        //public List<User> Users { get; set; }

        public static Union Create(string unionName)
        {
            if (unionName is null) throw new ArgumentNullException(nameof(unionName));
            var newUnion = new Union(Guid.NewGuid(), unionName);
            return newUnion;
        }
    }
}
