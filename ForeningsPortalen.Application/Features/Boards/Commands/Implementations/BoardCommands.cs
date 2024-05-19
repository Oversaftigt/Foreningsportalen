using ForeningsPortalen.Application.Features.Boards.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Boards.Commands.Implementations
{
    public class BoardCommands : IBoardCommands
    {
        private readonly IBoardRepository _repository;
        public BoardCommands(IBoardRepository repository)
        {
            _repository = repository;
        }

        void IBoardCommands.CreateBoard(BoardCreateRequestDto boardCreateRequestDto)
        {
            throw new NotImplementedException();
        }

        void IBoardCommands.DeleteBoard(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

        void IBoardCommands.UpdateBoard(BoardUpdateRequestDto boardUpdateRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
