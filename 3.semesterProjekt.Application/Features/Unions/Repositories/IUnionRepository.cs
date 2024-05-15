using _3.semesterProjekt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Unions.Repositories
{
    public interface IUnionRepository
    {
        Union GetOneUnion(Guid id);
        void CreateUnion(Union union);
        void UpdateUnion();
        void DeleteUnion();

    }
}
