using _3.semesterProjekt.Application.Features.Union.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Union.Queries
{
    public interface IUnionQueries
    {
        UnionQueryResultDto GelOneUnionById(Guid id);
        UnionQueryResultDto GelAllUnions();
    }
}
