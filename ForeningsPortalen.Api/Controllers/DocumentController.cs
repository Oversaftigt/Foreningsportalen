using ForeningsPortalen.Application.Features.Documents.Commands;
using ForeningsPortalen.Application.Features.Documents.Commands.DTOs;
using ForeningsPortalen.Application.Features.Documents.Queries;
using ForeningsPortalen.Application.Features.Documents.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentCommands _command;
        private readonly IDocumentQueries _queries;

        public DocumentController(IDocumentCommands commands, IDocumentQueries queries)
        {
            _command = commands;
            _queries = queries;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DocumentQueryResultDto>> GetDocument() 
        {
            //Denne
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult PostDocument([FromBody] DocumentCreateRequestDto documentCreateRequestDto)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult PutDocument([FromBody] DocumentUpdateRequestDto documentUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult DeleteDocument(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
