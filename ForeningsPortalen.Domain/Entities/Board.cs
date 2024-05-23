using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Board : Entity
    {
        public Board()
        {
        }

        internal Board(string boardEmail, List<User> boardMembers)
        {
            BoardEmail = boardEmail;
            BoardMembers = boardMembers;
        }

        public Guid BoardId { get; set; }
        public string BoardEmail { get; set; }

        // public Union Union { get; set; }     Den er en 1..1 og den ligger på en union.
        public List<User> BoardMembers { get; set; }

        public static Board CreateBoard(string boardEmail, List<User> boardMembers)
        {
            var newBoard = new Board(boardEmail, boardMembers);
            return newBoard;
        }


    }
}
