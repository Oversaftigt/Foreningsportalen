using _3.semesterProjekt.Application.Features.Unions.Commands.DTOs;
using _3.semesterProjekt.Application.Features.Unions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Unions.Commands.Implementations
{
    public class UnionCommand : IUnionCommands
    {
        private readonly IUnionRepository _repository;
        public UnionCommand(IUnionRepository repository)
        {
            _repository = repository;
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
