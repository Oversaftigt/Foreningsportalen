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
        //(Indeholder query-metoder. Metoder skal bruge FeatureQueryResultDto som returtype. 
        //Dette interface implementeres af FeatureQueries i infrastruktur)

        UserRoleHistoryCreateRequestDto GetUserRoleHistory(Guid id);
        List<UserRoleHistoryCreateRequestDto> GetAlleUserRoleHistories();
    }
}
