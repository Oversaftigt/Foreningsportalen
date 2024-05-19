using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Documents.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Documents.Commands
{
    public interface IDocumentCommands
    {
        
        void CreateDocument(DocumentCreateRequestDto documentCreateRequestDto);
        void UpdateDocument(DocumentUpdateRequestDto documentUpdateRequestDto);
        void DeleteDocument(SharedEntityDeleteDto deleteDto);
    }
}
