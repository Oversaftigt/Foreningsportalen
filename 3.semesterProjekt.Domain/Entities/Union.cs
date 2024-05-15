using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class Union
    {
        public int id { get; }
        public string name { get; set; }

        public List<Address> AddressInformation { get; set; }
        public Board? Board { get; set; }
        public List<Document> Documents { get; set; }
        public List<User> Users { get; set; }
    }
}
