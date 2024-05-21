using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Address : Entity
    {
        public Address()
        {

        }

        internal Address(string streetName, int streetNumber, string floor, string door, string city, int zipCode, Union union)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            Floor = floor;
            Door = door;
            City = city;
            ZipCode = zipCode;
            Union = union;

        }

        public Guid AddressId { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string? Floor {  get; set; }
        public string? Door { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public Union Union { get; set; }
        public IEnumerable<Member> Members { get; set; }

        public static Address Create(string streetName, int streetNumber, string? floor, string? door,string city, int zipCode, Union union)
        {
            if (union is null)
            {
            throw new Exception("Creating an Address failed, because Union was not found");
            }
                if (streetName == null) throw new ArgumentNullException(nameof(streetName));
                if (streetNumber <= 0) throw new ArgumentNullException(nameof(streetNumber));
                //Lav validering på Floor and Door
                if (city == null) throw new ArgumentNullException(nameof(city));
                if (zipCode <= 999) throw new ArgumentNullException(nameof(zipCode));
                
                var address = new Address(streetName, streetNumber, floor, door, city, zipCode, union);
                return address;

                //lav validering på om den allerede eksistere i databasen ? Senere
        }
    }
}
