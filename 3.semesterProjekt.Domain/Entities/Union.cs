using _3.semesterProjekt.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class Union : Entity
    {
        public Union(Guid id) : base(Guid.NewGuid())
        {
        }

        public Union(Guid id, string name, List<Address> addressInformation, Board? board, List<Document> documents, List<User> users) : base(id)
        {
            this.id = id;
            this.name = name;
            AddressInformation = addressInformation;
            Board = board;
            Documents = documents;
            Users = users;
        }
        public string name { get; set; }
        public List<Address> AddressInformation { get; set; }
        public Board? Board { get; set; }
        public List<Document> Documents { get; set; }
        public List<User> Users { get; set; }
    }
}
