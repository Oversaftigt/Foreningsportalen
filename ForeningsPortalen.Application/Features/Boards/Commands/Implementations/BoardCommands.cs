using ForeningsPortalen.Application.Features.Boards.Commands.DTOs;
using ForeningsPortalen.Application.Features.Boards.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Boards.Commands.Implementations
{
    public class BoardCommands : IboardCommands
    {
        private readonly IBoardRepository _repository;
        public BoardCommands(IBoardRepository repository)
        {
            _repository = repository;
        }

        void IboardCommands.CreateBoard(BoardCreateRequestDto boardCreateRequestDto)
        {
            throw new NotImplementedException();
        }

        void IboardCommands.DeleteBoard(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

        void IboardCommands.UpdateBoard(BoardUpdateRequestDto boardUpdateRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
