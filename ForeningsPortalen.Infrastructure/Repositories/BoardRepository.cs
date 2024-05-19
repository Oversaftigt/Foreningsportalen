using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public BoardRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        void IBoardRepository.AddBoard(Board board)
        {
            throw new NotImplementedException();
        }

        void IBoardRepository.DeleteBoard(Board board, byte[] rowversion)
        {
            throw new NotImplementedException();
        }

        Board IBoardRepository.GetBoard(Guid id)
        {
            throw new NotImplementedException();
        }

        void IBoardRepository.UpdateBoard(Board board, byte[] rowversion)
        {
            throw new NotImplementedException();
        }
    }
}
