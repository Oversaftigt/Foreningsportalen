using ForeningsPortalen.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Documents.Commands.Implementations
{
    public class DocumentCommands : IDocumentCommands
    {
        private readonly IDocumentRepository _documentRepository;
        public DocumentCommands(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }
    }
}
