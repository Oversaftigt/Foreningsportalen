using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Address : Entity
    {
        internal Address() : base(Guid.NewGuid())
        {

        }

        public Address(Guid id, string streetName, int streetNumber, string city, int zipCode) : base(id)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            City = city;
            ZipCode = zipCode;

        }


        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public List<Member> allResidents { get; set; }

        public static Address Create(string streetName, int streetNumber, string city, int zipCode)
        {
            Address address = new Address(Guid.NewGuid(), streetName, streetNumber, city, zipCode);
            return address;
        }

    }
}
