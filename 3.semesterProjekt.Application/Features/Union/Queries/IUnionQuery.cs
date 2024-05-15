using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.semesterProjekt.Application.Features.Union.Queries.DTOs;

namespace _3.semesterProjekt.Application.Features.Union.Queries
{
    public interface IUnionQuery
    {
        UnionQueryResultDto GetUnionWithId(Guid id);
        UnionQueryResultDto GetAllUnions();
    }
}
