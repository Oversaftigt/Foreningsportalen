using ForeningsPortalen.Application.Features.Unions.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;

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
            throw new NotImplementedException();
        }

        void IUnionCommands.DeleteUnion(Guid id)
        {
            throw new NotImplementedException();
        }

        void IUnionCommands.UpdateUnion(UnionCommandUpdateDto unionUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
