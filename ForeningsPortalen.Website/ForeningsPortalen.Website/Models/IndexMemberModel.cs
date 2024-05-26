using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models
{
    public class IndexMemberModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly? MoveInDate { get; set; }
        public DateOnly? MoveOutDate { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
