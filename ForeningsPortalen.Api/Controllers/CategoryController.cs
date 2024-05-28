using ForeningsPortalen.Application.Features.Categories.Commands;
using ForeningsPortalen.Application.Features.Categories.Commands.DTOs;
using ForeningsPortalen.Application.Features.Categories.Queries;
using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryCommands _command;
        private readonly ICategoryQueries _queries;

        public CategoryController(ICategoryCommands command, ICategoryQueries queries)
        {
            _command = command;
            _queries = queries;
        }
        

        [HttpGet("union/{unionId}/categories")]
        public ActionResult<IEnumerable<CategoryQueryResultDto>> GetCategoriesByUnionId(Guid unionId)
        {
            try
            {
                var result = _queries.GetCategoriesByUnionId(unionId);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult PostCategory([FromBody] CategoryCreateRequestDto categoryCreateRequestDto)
        {
            try
            {
                _command.CreateCategory(categoryCreateRequestDto);
                return Created();
            }
            catch(Exception ex) 
            {
                return BadRequest(new {message = ex.Message});
            }
        }
    }
}
