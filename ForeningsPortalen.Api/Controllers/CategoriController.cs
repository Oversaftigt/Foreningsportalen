using ForeningsPortalen.Application.Features.Categories.Commands.DTOs;
using ForeningsPortalen.Application.Features.Categories.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;
using ForeningsPortalen.Application.Features.Categories.Queries.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriController : ControllerBase
    {
        private readonly ICategoryCommand _command;
        private readonly ICategoryQueries _queries;

        public CategoriController(ICategoryCommand command, ICategoryQueries queries)
        {
            _command = command;
            _queries = queries;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryQueryResultDto>> GetCategories()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult PostCategory([FromBody] CategoryCreateRequestDto categoryCreateRequestDto)
        {
            throw new NotImplementedException();
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
