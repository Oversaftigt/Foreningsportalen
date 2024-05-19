using ForeningsPortalen.Application.Features.Boards.Repositories;
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
    }
}
