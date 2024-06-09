using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Addresses.Queries
{
    //For infrastucture
    public interface IAddressQueries
    {
        /// <summary>
        /// Gets a list of addressed, based on which unionId is chosen
        /// </summary>
        /// <param name="unionId"></param>
        /// <returns></returns>
        IEnumerable<AddressQueryResultDto> GetAddressesByUnion(Guid unionId);
        
        /// <summary>
        /// Gets a specific address based on addressId
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        AddressQueryResultDto GetAddressById(Guid addressId);
    }
}
