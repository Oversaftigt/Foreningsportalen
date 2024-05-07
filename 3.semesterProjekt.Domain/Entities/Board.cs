using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class Board
    {
        public int Id { get;}
        public string BoardEmail { get; set; }

        public Union Union { get; set; }
        public List<User> BoardMembers { get; set; }
    }
}
