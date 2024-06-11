using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.DomainServices
{
    public interface IUnionDomainService
    {
        /// <summary>
        /// Gets a list of all the unions in the database
        /// </summary>
        /// <returns></returns>
        IEnumerable<Union> OtherUnions();
    }
}
