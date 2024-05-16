using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Categories.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Categories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Categories.Commands.Implementations
{
    public class CategoryCommand : ICategoryCommand
    {
        private readonly ICategoryRepository _repo;

        public CategoryCommand(ICategoryRepository repo)
        {
            _repo = repo;
        }

        void ICategoryCommand.CreateCategory(AddressCreateRequestDto addressCreateRequestDto)
        {
            throw new NotImplementedException();
        }

        void ICategoryCommand.UpdateCategory(AddressUpdateRequestDto addressUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        void ICategoryCommand.DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
