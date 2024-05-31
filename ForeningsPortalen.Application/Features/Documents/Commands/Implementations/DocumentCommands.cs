using ForeningsPortalen.Application.Features.Documents.Commands.DTOs;

using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Crosscut.TransactionHandling;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Documents.Commands.Implementations
{
    public class DocumentCommands : IDocumentCommands
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly IMemberRepository _memberRepository;
        private readonly IUnitOfWork _unitOfWork;
        public DocumentCommands(IDocumentRepository documentRepository, IMemberRepository memberRepository, IUnitOfWork unitOfWork)
        {
            _documentRepository = documentRepository;
            _memberRepository = memberRepository;
            _unitOfWork = unitOfWork;
        }

        void IDocumentCommands.CreateDocument(DocumentCreateRequestDto documentCreateRequestDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var member = _memberRepository.GetUnionMember(documentCreateRequestDto.MemberId);
                if (member == null)
                {
                    throw new ArgumentNullException("Member not found");
                }

                var newDocument = Document.CreateDocument(member, documentCreateRequestDto.DocumentName,documentCreateRequestDto.DocumentPath);

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
                throw;
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
