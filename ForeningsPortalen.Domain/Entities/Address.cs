using ForeningsPortalen.Domain.Shared;
using ForeningsPortalen.Domain.Validation;
using System.Text.RegularExpressions;

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
        public string? Floor { get; set; }
        public string? Door { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public Union Union { get; set; }
        public List<Member> Members { get; set; }

        public static Address Create(string streetName, int streetNumber, string? floor, string? door, string city,
                                     int zipCode, Union union, IDawaAddressValidation dawaAddressValidation)

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

            if (dawaAddressValidation is null) throw new ArgumentNullException(nameof(dawaAddressValidation));

            string fullAddress = $"{streetName} {streetNumber}, {zipCode} {city}";
            if (dawaAddressValidation.AddressIsValid(fullAddress) is false) throw new InvalidOperationException("Address does not exist");
            var address = new Address(streetName, streetNumber, floor, door, city, zipCode, union);
            return address;

            //lav validering på om den allerede eksistere i databasen ? Senere

        }

        //Possible values that floor can be according to dawa's documentation: numbers from 1 to 99, st, kl, k2 up to k9
        protected bool IsFloorValid()
        {
            if (Floor == "st" || Floor == "kl" ||
                Regex.IsMatch(Floor, @"^k[1-9]$") ||
                (int.TryParse(Floor, out int floorNumber) && floorNumber >= 1 && floorNumber <= 99))
            {
                return true;
            }
            return false;
        }

        //Possible values that door can be according to dawa's documentation:
        //Numbers from 1 to 9999, small letters as well as the symbols / and -
        protected bool IsDoorValid()
        {
            string pattern = @"^[1-9][0-9]{0,3}[a-z/-]*$";
            return Regex.IsMatch(Door, pattern);
        }
    }
}
