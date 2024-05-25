using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Union : Entity
    {
        public Union()
        {
        }

        internal Union(string name) 
        {
            this.name = name;
        }

        public Guid UnionId { get; set; }
        public string name { get; set; }
        public IEnumerable<Address>? Addresses { get; set; }
        public IEnumerable<Document>? Documents { get; set; }
        //public IEnumerable<User> Users { get; set; }

        public static Union Create(string unionName)
        {
            if (unionName is null) throw new ArgumentNullException(nameof(unionName));
            var newUnion = new Union(unionName);
            return newUnion;
        }
    }
}
