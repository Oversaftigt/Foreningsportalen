using ForeningsPortalen.Application.Features.Unions.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Crosscut.TransactionHandling;

namespace ForeningsPortalen.Application.Features.Unions.Commands.Implementations
{
    public class UnionCommand : IUnionCommands
    {
        private readonly IUnionRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;
        public UnionCommand(IUnionRepository repository, IUnitOfWork unitOfWork, IServiceProvider serviceProvider)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _serviceProvider = serviceProvider;
        }

        void IUnionCommands.CreateUnion(UnionCommandCreateDto unionCreateDto)
        {
            var union = Domain.Entities.Union.Create(unionCreateDto.UnionName, _serviceProvider);
            _repository.AddUnion(union);
        }


        void IUnionCommands.UpdateUnion(UnionCommandUpdateDto unionUpdateDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var union = _repository.GetUnion(unionUpdateDto.id);
                if (union is null) throw new Exception("Union not found");

                union.Update(unionUpdateDto.UnionName, _serviceProvider);

                _repository.UpdateUnion(union, unionUpdateDto.RowVersion);
                _unitOfWork.Commit();
            }
            catch (Exception e)
            {

                try
                {
                    _unitOfWork.Rollback();
                }
                catch (Exception ex)
                {

                    throw new Exception($"Rollback failed: {ex.Message}", e);
                }
                throw;
            }
        }

        void IUnionCommands.DeleteUnion(SharedEntityDeleteDto deleteDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var union = _repository.GetUnion(deleteDto.Id);
                if (union is null) throw new Exception("Union not found");

                _repository.DeleteUnion(union, deleteDto.RowVersion);

                _unitOfWork.Commit();
            }
            catch (Exception e)
            {
                try
                {
                    _unitOfWork.Rollback();
                }
                catch (Exception ex)
                {

                    throw new Exception($"Rollback failed: {ex.Message}");
                }
                throw;
            }
        }
    }
}
