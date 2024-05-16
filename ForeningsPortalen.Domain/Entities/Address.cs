using _3.semesterProjekt.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.Entities
{
    public class Address : Entity
    {
        internal Address() : base(Guid.NewGuid())
        {

        }

        public Address(Guid id,string streetName, int streetNumber, string city, int zipCode, List<User> allResidents) : base(id)
        {
            this.Id = id; 
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
        public List<User> allResidents { get; set; }
    }
}
