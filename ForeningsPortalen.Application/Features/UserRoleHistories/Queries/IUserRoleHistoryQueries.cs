using ForeningsPortalen.Application.Features.UserRoleHistories.Commands.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.UserRoleHistories.Queries
{
    public interface IUserRoleHistoryQueries
    {
        UserRoleHistoryCreateRequestDto GetUserRoleHistory(Guid id);
        List<UserRoleHistoryCreateRequestDto> GetAlleUserRoleHistories();
    }
}
