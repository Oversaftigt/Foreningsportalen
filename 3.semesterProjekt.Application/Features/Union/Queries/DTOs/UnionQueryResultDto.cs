using _3.semesterProjekt.Domain.Entities;

namespace _3.semesterProjekt.Application.Features.Union.Queries.DTOs
{
    public class UnionQueryResultDto
    {
        public int id { get; }
        public string name { get; set; }
        public List<Address> AddressInformation { get; set; }
        //public Board Board { get; set; }
        //public List<Document> Documents { get; set; }
        //public List<User> Users { get; set; }
    }
}