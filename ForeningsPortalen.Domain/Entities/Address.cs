using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Address : Entity
    {
        internal Address() : base(Guid.NewGuid())
        {

        }

        public Address(Guid id, string streetName, int streetNumber, string city, int zipCode, List<Member> allResidents) : base(id)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            City = city;
            ZipCode = zipCode;
            this.allResidents = allResidents;
        }


        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public List<Member> allResidents { get; set; }

        public static Address Create(string streetName, int streetNumber, string city, int zipCode, List<Member> allResidents)
        {
            Address address = new Address(Guid.NewGuid(), streetName, streetNumber, city, zipCode, allResidents);
            return address;
        }

    }
}
