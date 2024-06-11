
using ForeningsPortalen.Domain.Shared;
using ForeningsPortalen.Domain.Validation;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Text.RegularExpressions;

namespace ForeningsPortalen.Domain.Entities
{
    public class Address : Entity
    {
        protected Address()
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

        public Guid AddressId { get; private set; }
        public string StreetName { get; private set; }
        public int StreetNumber { get; private set; }
        public string? Floor { get; private set; }
        public string? Door { get; private set; }
        public string City { get; private set; }
        public int ZipCode { get; private set; }
        public Union Union { get; private set; }
        public IEnumerable<Member> Members { get; private set; }

        public static Address Create(string streetName, int streetNumber, string? floor, string? door, string city,
                                     int zipCode, Union union, IServiceProvider services)

        {
            StringBuilder fullAddress = new StringBuilder();
            fullAddress.Append($"{streetName} {streetNumber}");

            if (union is null)
            {
                throw new Exception("Creating an Address failed, because Union was not found");
            }
            if (streetName is null) throw new ArgumentNullException(nameof(streetName));
            if (city is null) throw new ArgumentNullException(nameof(city));
            if (services is null) throw new ArgumentNullException(nameof(services));
            if (streetNumber <= 0) throw new ArgumentOutOfRangeException(nameof(streetNumber), "Street number must be greater than 0");
            if (zipCode <= 999 || zipCode >= 9991) throw new ArgumentOutOfRangeException(nameof(zipCode), "Zipcode must be between 1000 and 9990");
            //Lav validering på Floor and Door

            if (floor is not null)
            {
                if (IsFloorValid(floor)) fullAddress.Append($", {floor}");
                else floor = string.Empty;
            }
            if (door is not null)
            {
                if (IsDoorValid(door)) fullAddress.Append($", {door}");
                else door = string.Empty;
            }
            var dawaService = services.GetService<IDawaAddressValidationService>();
            if (dawaService is null) throw new ArgumentNullException(nameof(dawaService));
            fullAddress.Append($", {zipCode} {city}");
            if (dawaService.AddressIsValid(fullAddress.ToString()) is false) throw new InvalidOperationException("Address does not exist or is not specified well enough");

            //Further validation to check if address is already in database

            var address = new Address(streetName, streetNumber, floor, door, city, zipCode, union);

            return address;
        }

        //Possible values that floor can be according to dawa's documentation: numbers from 1 to 99, st, kl, k2 up to k9
        //May be interpreted wrong and thus the validation logic is wrong
        protected static bool IsFloorValid(string Floor)
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
        //May be interpreted wrong and thus the validation logic is wrong
        protected static bool IsDoorValid(string Door)
        {
            string NumAndLetterpattern = @"^[1-9][0-9]{0,3}[a-zA-Z/-]*$"; //Door numbers are assumed to have numbers before letters/symbols
            string abbreviationPattern = @"(?i)^(?:mf\.?|t[hv]\.?)$"; //Or to be abbreviations like tv. or th
            string singleLetterPattern = @"^[a-zA-Z]$";

            string combinedPattern = $"({abbreviationPattern})|({NumAndLetterpattern})|({singleLetterPattern})";
            return Regex.IsMatch(Door, combinedPattern);
        }
    }
}
