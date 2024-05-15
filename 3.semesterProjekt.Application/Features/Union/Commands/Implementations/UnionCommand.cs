using _3.semesterProjekt.Application.Features.Union.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Union.Commands.Implementations
{
    public class UnionCommand : IUnionCommands
    {
        private readonly IUnionRepository _repository;
        public UnionCommand(IUnionRepository repository)
        {
            _repository = repository;
        }
    }
}
