using ForeningsPortalen.Application.Features.Boards.Commands.DTOs;
using ForeningsPortalen.Application.Features.Helpers;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;
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
        private readonly IUnitOfWork _unitOfWork;
        public BoardCommands(IBoardRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        void IBoardCommands.CreateBoard(BoardCreateRequestDto boardCreateRequestDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var newBoard = Board.CreateBoard(boardCreateRequestDto.BoardEmail, boardCreateRequestDto.BoardMembers);

                _repository.AddBoard(newBoard);
                _unitOfWork.Commit();
            }
            catch
            {
                try
                {
                    _unitOfWork?.Rollback();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Rollback has failed: {ex.Message}");
                }
            }
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
