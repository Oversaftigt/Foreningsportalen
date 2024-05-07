using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class Login
    {
        public int Id { get; }
        public required string UserName { get; set; }
        public required string Password { get; set; }

        public User User { get; set; }
    }
}
