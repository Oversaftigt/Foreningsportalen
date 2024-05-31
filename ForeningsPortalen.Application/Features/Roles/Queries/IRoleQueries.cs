using ForeningsPortalen.Application.Features.Roles.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Roles.Queries
{
    public interface IRoleQueries
    {
        //(Indeholder query-metoder. Metoder skal bruge FeatureQueryResultDto som returtype. 
        //Dette interface implementeres af FeatureQueries i infrastruktur)
        IEnumerable<RoleQueryResultDto> GetAllRoles();
    }
}
