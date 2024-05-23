using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Boards.Queries.DTOs
{
    public class BoardQueryResultDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public List<User> Members { get; set; }
    }
}
