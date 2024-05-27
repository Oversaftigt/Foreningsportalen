namespace ForeningsPortalen.Website.Models.Member
{
    public class UpdateMemberModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateOnly? MoveOutDate { get; set; }
        public Guid RoleId { get; set; }
        public byte[] RowVersion { get; set; } = [];
    }
}
