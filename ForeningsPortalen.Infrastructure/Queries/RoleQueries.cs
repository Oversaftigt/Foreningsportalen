using ForeningsPortalen.Application.Features.Documents.Queries.DTOs;
using ForeningsPortalen.Application.Features.Roles.Queries;
using ForeningsPortalen.Application.Features.Roles.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class RoleQueries : IRoleQueries
    {
        private readonly ForeningsPortalenContext _dbContext;
        public RoleQueries(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        List<RoleQueryResultDto> IRoleQueries.GetAllRoles()
        {
            var result = _dbContext.Roles.AsNoTracking()
                .Select(r => new RoleQueryResultDto
                {
                    Id = r.RoleId,
                    RoleName = r.RoleName,
                    UserHistories = r.UserHistories,
                    Rowversion = r.RowVersion,
                }).ToList();
            if (!result.Any())
            {
                throw new Exception("Roles were not found");
            }
            return result;
        }

        RoleQueryResultDto IRoleQueries.GetRole(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
