using ForeningsPortalen.Application.Features.Unions.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Unions.Commands.Implementations
{
    public class UnionCommand : IUnionCommands
    {
        private readonly IUnionRepository _repository;
        //private readonly IUnitOfWork _unitOfWork;
        public UnionCommand(IUnionRepository repository/*, IUnitOfWork unitOfWork*/)
        {
            _repository = repository;
            //_unitOfWork = unitOfWork;
        }

        void IUnionCommands.CreateUnion(UnionCommandCreateDto unionCreateDto)
        {
            var union = Domain.Entities.Union.Create(unionCreateDto.name);
            _repository.CreateUnion(union);
        }

        void IUnionCommands.DeleteUnion(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

        void IUnionCommands.UpdateUnion(UnionCommandUpdateDto unionUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
