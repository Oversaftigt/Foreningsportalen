using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Categories.Commands.DTOs;
using ForeningsPortalen.Application.Features.Helpers;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.Categories.Commands.Implementations
{
    public class CategoryCommands : ICategoryCommands
    {
        private readonly ICategoryRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;

        public CategoryCommands(ICategoryRepository repository, IUnitOfWork unitOfWork, IServiceProvider serviceProvider)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _serviceProvider = serviceProvider;
        }

        void ICategoryCommands.CreateCategory(CategoryCreateRequestDto categoryCreateRequestDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var newCategory = Category.CreateCategory(categoryCreateRequestDto.Name, categoryCreateRequestDto.DurationType, 
                    categoryCreateRequestDto.MaxBookingsOfThisCategory, _serviceProvider);

                _repository.AddCategory(newCategory);
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

        void ICategoryCommands.UpdateCategory(CategoryUpdateRequestDto categoryUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        void ICategoryCommands.DeleteCategory(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }
    }
}
