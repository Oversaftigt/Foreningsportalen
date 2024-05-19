using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IBoardRepository
    {
        void AddBoard(Board board);
        void UpdateBoard(Board board, byte[] rowversion);
        void DeleteBoard(Board board, byte[] rowversion);
        Board GetBoard(Guid id);
    }
}
