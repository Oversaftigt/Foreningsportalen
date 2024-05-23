using ForeningsPortalen.Application.Features.Boards.Queries;
using ForeningsPortalen.Application.Features.Boards.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class BoardQueries : IBoardQueries
    {
        private readonly ForeningsPortalenContext _dbContext;
        public BoardQueries(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        BoardQueryResultDto IBoardQueries.GelAllBoards()
        {
            throw new NotImplementedException();
        }

        BoardQueryResultDto IBoardQueries.GelOneBoardById(Guid id)
        {
            var board = _dbContext.Board.AsNoTracking()
              .Select(b => new BoardQueryResultDto()
              {
                  Id = id,
                  Email = b.BoardEmail,
                  Members = b.BoardMembers
              })
              .FirstOrDefault(b => b.Id == id);

            if (board == null)
            {
                throw new Exception("No members were found");
            }

            return board;
        }
    }
}

