using ForeningsPortalen.Application.Features.Boards.Queries.DTOs;
using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Boards.Queries
{
    public interface IBoardQueries
    {
        // Read one and Read all

        BoardQueryResultDto GelOneBoardById(Guid id);
        BoardQueryResultDto GelAllBoards();
    }
}
