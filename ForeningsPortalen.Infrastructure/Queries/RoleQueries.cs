using ForeningsPortalen.Application.Features.Roles.Queries;
using ForeningsPortalen.Application.Features.Roles.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class RoleQueries : IRoleQueries
    {
        private readonly ForeningsPortalenContext _dbContext;
        public RoleQueries(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        IEnumerable<RoleQueryResultDto> IRoleQueries.GetAllRoles()
        {
            var roles = _dbContext.Roles.AsNoTracking()
                        .Select(a => new RoleQueryResultDto
                        {
                            Id = a.RoleId,
                            RoleName = a.Name,
                            Rowversion = a.RowVersion
                        }).ToList();

            if (roles is null)
            {
                throw new Exception("Error finding all roles");
            }

            return roles;
        }
    }
}
