using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs
{
    public class UnionMemberUpdateMoveOutRequestDto
    {
        public Guid Id { get; set; }
        public Guid UnionId { get; set; }
        public DateOnly MoveOutDate { get; set; } = new DateOnly();
    }
}
