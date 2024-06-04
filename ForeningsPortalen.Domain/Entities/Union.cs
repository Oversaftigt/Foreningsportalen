using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace ForeningsPortalen.Domain.Entities
{
    public class Union : Entity
    {
        protected Union()
        {
        }

        internal Union(string name)
        {
            this.Name = name;
        }

        public Guid UnionId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Address>? Addresses { get; set; }
        public IEnumerable<Document>? Documents { get; set; }
        //public IEnumerable<User> Users { get; set; }

        public static Union Create(string unionName, IServiceProvider services)
        {
            if (unionName is null) throw new ArgumentNullException(nameof(unionName));
            if (services is null) throw new ArgumentNullException(nameof(services));

            var domainService = services.GetService<IUnionDomainService>();
            if (domainService is null) throw new ArgumentNullException(nameof(domainService));

            if (Union.IsUnionNameTaken(domainService.OtherUnions(), unionName) is true)
                throw new InvalidOperationException("Union with that name already exists");

            var newUnion = new Union(unionName);
            return newUnion;
        }

        public void Update(string unionName, IServiceProvider services)
        {
            if (unionName is null) throw new ArgumentNullException(nameof(unionName));
            if (services is null) throw new ArgumentNullException(nameof(services));

            var domainService = services.GetService<IUnionDomainService>();
            if (domainService is null) throw new ArgumentNullException(nameof(domainService));

            if (Union.IsUnionNameTaken(domainService.OtherUnions(), unionName) is true)
                throw new InvalidOperationException("Union with that name already exists");

            Name = unionName;
        }

        private static bool IsUnionNameTaken(IEnumerable<Union> otherUnions, string thisUnionName)
        {
            return otherUnions.Any(x => x.Name.ToLower().Trim() == thisUnionName.ToLower().Trim());
        }

    }
}
