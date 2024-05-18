using ForeningsPortalen.Application.Features.Boards.Queries;
using ForeningsPortalen.Application.Features.Boards.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;
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
            throw new NotImplementedException();
        }
    }
}
