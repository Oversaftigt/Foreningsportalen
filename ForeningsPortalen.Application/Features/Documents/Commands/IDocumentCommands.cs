using ForeningsPortalen.Application.Features.Documents.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Documents.Commands
{
    public interface IDocumentCommands
    {
        /// <summary>
        /// Create a document, using a dto
        /// </summary>
        /// <param name="documentCreateRequestDto"></param>
        void CreateDocument(DocumentCreateRequestDto documentCreateRequestDto);

        /// <summary>
        /// Update an existing document, using a dto
        /// </summary>
        /// <param name="documentUpdateRequestDto"></param>
        void UpdateDocument(DocumentUpdateRequestDto documentUpdateRequestDto);

        /// <summary>
        /// Delete a document
        /// </summary>
        /// <param name="deleteDto"></param>
        void DeleteDocument(SharedEntityDeleteDto deleteDto);
    }
}
