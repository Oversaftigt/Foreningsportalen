using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class Document
    {
        public int Id { get; }
        public required string Title { get; set; }
        public DateOnly Date { get; set; }

    }
}
