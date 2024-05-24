using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Union : Entity
    {
        public Union()
        {
        }

        internal Union(string name/*, Board? board, List<User> users*/) 
        {
            this.name = name;
            //Board = board;
            //Users = users;
        }
        public Guid UnionId { get; set; }
        public string name { get; set; }
        public List<Address>? Addresses { get; set; }
        public List<Member> Board { get; set; }
        public List<Category>? Categories { get; set; }
        //public List<User> Users { get; set; }
        //public Board? Board { get; set; }
        //public List<User> Users { get; set; }

        public static Union Create(string unionName)
        {
            if (unionName is null) throw new ArgumentNullException(nameof(unionName));
            var newUnion = new Union(unionName);
            return newUnion;
        }
    }
}
