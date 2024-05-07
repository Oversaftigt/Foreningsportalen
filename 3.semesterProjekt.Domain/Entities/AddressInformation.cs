using _3.semesterProjekt.Domain.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class AddressInformation
    {
        public int Id { get; }
        public Address Address { get; set; }
        public List<User> allResidents { get; set; }
    }
}
