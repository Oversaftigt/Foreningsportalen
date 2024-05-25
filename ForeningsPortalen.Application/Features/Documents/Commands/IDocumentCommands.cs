using ForeningsPortalen.Application.Features.Documents.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Documents.Commands
{
    public interface IDocumentCommands
    {
        void CreateDocument(DocumentCreateRequestDto documentCreateRequestDto);
        void UpdateDocument(DocumentUpdateRequestDto documentUpdateRequestDto);
        void DeleteDocument(SharedEntityDeleteDto deleteDto);
    }
}
