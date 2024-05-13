using _3.semesterProjekt.Domain.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class Address
    {
        public int Id { get; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZioCode { get; set; }
        public List<User> allResidents { get; set; }
    }
}
