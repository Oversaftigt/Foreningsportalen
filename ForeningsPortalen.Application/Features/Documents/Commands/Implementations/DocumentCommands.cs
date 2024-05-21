﻿using ForeningsPortalen.Application.Features.Documents.Commands.DTOs;
using ForeningsPortalen.Application.Features.Helpers;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;
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
        private readonly IUnitOfWork _unitOfWork;
        public DocumentCommands(IDocumentRepository documentRepository, IUnitOfWork unitOfWork)
        {
            _documentRepository = documentRepository;
            _unitOfWork = unitOfWork;
        }

        void IDocumentCommands.CreateDocument(DocumentCreateRequestDto documentCreateRequestDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var newDocument = Document.CreateDocument(documentCreateRequestDto.Title, documentCreateRequestDto.Member, documentCreateRequestDto.Date);

                _documentRepository.AddDocument(newDocument);
                _unitOfWork.Commit();
            }
            catch
            {
                try
                {
                    _unitOfWork?.Rollback();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Rollback has failed: {ex.Message}");
                }
            }

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
