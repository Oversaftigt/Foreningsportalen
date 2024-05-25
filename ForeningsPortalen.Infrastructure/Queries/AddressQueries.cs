using ForeningsPortalen.Application.Features.Addresses.Queries;
using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class AddressQueries : IAddressQueries
    {
        private readonly ForeningsPortalenContext _db;

        private DateOnly dateOfQuery;
        public AddressQueries(ForeningsPortalenContext foreningsPortalenContext)
        {
            _db = foreningsPortalenContext;
            dateOfQuery = DateOnly.FromDateTime(DateTime.Today.Date);
        }

        IEnumerable<AddressQueryResultDto> IAddressQueries.GetAddressesByUnion(Guid unionId)
        {

            var addresses = _db.Addresses.AsNoTracking()
                           .Select(a => new AddressQueryResultDto()
                           {
                               Id = a.AddressId,
                               Street = a.StreetName,
                               Number = a.StreetNumber,
                               CityName = a.City,
                               PostalCode = a.ZipCode,
                               UnionId = a.Union.UnionId,
                               AllTenants = a.Members.Select(m => m.UserId).ToList(),
                               RowVersion = a.RowVersion,
                           })
                           .Where(a => a.UnionId == unionId).ToList();

            if (!addresses.Any())
            {
                throw new Exception("No Addresses were not found");
            }

            return addresses;
        }


        AddressQueryResultDto IAddressQueries.GetAddressById(Guid addressId)
        {
            var address = _db.Addresses.AsNoTracking()
                         .Select(a => new AddressQueryResultDto()
                         {
                             Id = a.AddressId,
                             Street = a.StreetName,
                             Number = a.StreetNumber,
                             CityName = a.City,
                             PostalCode = a.ZipCode,
                             AllTenants = a.Members.Select(m => m.UserId).ToList(),
                             CurrentTenants = a.Members.Where(m => m.MoveOutDate == null || m.MoveOutDate >= dateOfQuery).Select(m => m.UserId),
                             RowVersion = a.RowVersion,
                         })
                         .First(a => a.Id == addressId);

            if (address == null)
            {
                throw new Exception("Address was not found");
            }
            return address;
        }
    }
}
