using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Boards.Commands.DTOs
{
    public class BoardUpdateRequestDto
    {
        public Guid Id{ get; set; }
        public string BoardEmail { get; set; }

        // public Union Union { get; set; }     Den er en 1..1 og den ligger på en union.
        public List<User> BoardMembers { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
