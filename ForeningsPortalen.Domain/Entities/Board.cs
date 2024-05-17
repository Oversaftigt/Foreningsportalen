namespace ForeningsPortalen.Domain.Entities
{
    public class Board
    {
        public int Id { get; }
        public string BoardEmail { get; set; }

        // public Union Union { get; set; }     Den er en 1..1 og den ligger på en union.
        public List<User> BoardMembers { get; set; }
    }
}
