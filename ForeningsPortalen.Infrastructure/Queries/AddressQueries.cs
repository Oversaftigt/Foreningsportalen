using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries.DTOs;
using ForeningsPortalen.Application.Repositories;
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
                               StreetNumber = a.StreetNumber,
                               City = a.City,
                               ZipCode = a.ZipCode,
                               UnionId = a.Union.UnionId,
                               Members = a.Members.Select(m => m.UserId).ToList(),
                               CurrentMember = a.Members.FirstOrDefault(m => m.MoveOutDate == null || m.MoveOutDate >= dateOfQuery),
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
                             StreetNumber = a.StreetNumber,
                             City = a.City,
                             ZipCode = a.ZipCode,
                             Members = a.Members.Select(m => m.UserId).ToList(),
                             CurrentMember = a.Members.FirstOrDefault(m => m.MoveOutDate == null || m.MoveOutDate >= dateOfQuery),
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
