using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Board : Entity
    {
        internal Board(Guid id) : base(id)
        {
        }

        public Board(Guid id, string boardEmail, List<User> boardMembers) : base(id)
        {
            BoardEmail = boardEmail;
            BoardMembers = boardMembers;
        }

        public string BoardEmail { get; set; }

        // public Union Union { get; set; }     Den er en 1..1 og den ligger på en union.
        public List<User> BoardMembers { get; set; }
    }
}
