using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Unions.Queries.DTOs
{
    public class UnionQueryResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Address>? AddressInformation { get; set; }
        public byte[] RowVersion { get; set; }
        //public Board Board { get; set; }
        //public List<Document> Documents { get; set; }
        //public List<User> Users { get; set; }
    }
}