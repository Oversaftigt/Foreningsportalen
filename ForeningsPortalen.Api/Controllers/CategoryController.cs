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

        [HttpGet]
        public ActionResult<IEnumerable<CategoryQueryResultDto>> GetCategories()
        {
            var result = _queries.GetCategories();
            if (result == null)
            {
                return BadRequest("Ingen Kategorier er fundet");
            }
            return Ok(result);
        }

        [HttpPost]
        public ActionResult PostCategory([FromBody] CategoryCreateRequestDto categoryCreateRequestDto)
        {
            try
            {
                _command.CreateCategory(categoryCreateRequestDto);
                return Created();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public ActionResult PutCategory([FromBody] CategoryUpdateRequestDto categoryUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
