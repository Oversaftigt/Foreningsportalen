using ForeningsPortalen.Application.Features.Boards.Commands;
using ForeningsPortalen.Application.Features.Boards.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IBoardCommands _boardCommands;
        private readonly IBoardQueries _boardQueries;
        public BoardController(IBoardCommands boardCommands, IBoardQueries boardQueries)
        {
            _boardCommands = boardCommands;
            _boardQueries = boardQueries;
        }
        [HttpGet("{boardId}")]
        public IActionResult GetBoardById(Guid id)
        {
            var result = _boardQueries.GelOneBoardById(id);
            if (result == null)
            {
                return BadRequest("No boards found");

            }
            return Ok(result);
        }
    }
}
