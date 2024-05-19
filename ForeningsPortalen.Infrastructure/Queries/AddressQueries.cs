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

            var adresses = _db.Addresses.AsNoTracking()
                           .Select(a => new AddressQueryResultDto()
                           {
                               Id = a.Id,
                               Street = a.StreetName,
                               StreetNumber = a.StreetNumber,
                               City = a.City,
                               ZipCode = a.ZipCode,
                               UnionId = a.Union.Id,
                               Members = a.Members.Select(m => m.Id).ToList(),
                               CurrentMember = a.Members.FirstOrDefault(m => m.MoveOutDate == null || m.MoveOutDate >= dateOfQuery),
                               RowVersion = a.RowVersion,
                           })
                           .Where(a => a.UnionId == unionId).ToList();

            return adresses;
        }

        AddressQueryResultDto IAddressQueries.GetAddressById(Guid addressId)
        {
            var address = _db.Addresses.AsNoTracking()
                         .Select(a => new AddressQueryResultDto()
                         {
                             Id = a.Id,
                             Street = a.StreetName,
                             StreetNumber = a.StreetNumber,
                             City = a.City,
                             ZipCode = a.ZipCode,
                             Members = a.Members.Select(m => m.Id).ToList(),
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
