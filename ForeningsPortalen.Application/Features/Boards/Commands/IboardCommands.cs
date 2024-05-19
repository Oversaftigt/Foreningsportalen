using ForeningsPortalen.Application.Features.Boards.Commands.DTOs;
using ForeningsPortalen.Application.Features.Unions.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Boards.Commands
{
    public interface IBoardCommands
    {
        //Create, Update og delete

        void UpdateBoard(BoardUpdateRequestDto boardUpdateRequestDto);
        void CreateBoard(BoardCreateRequestDto boardCreateRequestDto);
        void DeleteBoard(SharedEntityDeleteDto deleteDto);
    }
}
