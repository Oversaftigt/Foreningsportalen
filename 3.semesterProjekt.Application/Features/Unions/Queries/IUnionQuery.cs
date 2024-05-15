using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.semesterProjekt.Application.Features.Unions.Queries.DTOs;

namespace _3.semesterProjekt.Application.Features.Unions.Queries
{
    public interface IUnionQuery
    {
        UnionQueryResultDto GetUnionWithId(Guid id);
        UnionQueryResultDto GetAllUnions();
    }
}
