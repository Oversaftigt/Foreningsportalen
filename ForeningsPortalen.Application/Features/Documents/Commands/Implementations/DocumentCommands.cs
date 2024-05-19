using ForeningsPortalen.Application.Features.Documents.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
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

        void IDocumentCommands.CreateDocument(DocumentCreateRequestDto documentCreateRequestDto)
        {
            throw new NotImplementedException();
        }

        void IDocumentCommands.DeleteDocument(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

        void IDocumentCommands.UpdateDocument(DocumentUpdateRequestDto documentUpdateRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
