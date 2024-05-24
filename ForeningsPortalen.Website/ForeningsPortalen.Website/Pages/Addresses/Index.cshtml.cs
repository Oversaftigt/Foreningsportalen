using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Contract;
using ForeningsPortalen.Website.Contract.Proxy_s;
using ForeningsPortalen.Website.Models.Address;

namespace ForeningsPortalen.Website.Pages.Addresses
{
    public class IndexModel : PageModel
    {
        private readonly IAddressService _addressService;
        public IndexModel(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IList<AddressIndexModel> Address { get; set; }

        public async Task OnGetAsync()
        {
            var sessionValue = HttpContext.Session.GetString("Union");
            if (sessionValue != null)
            {
                
                var businessModel = await _addressService.GetAllAddressesAsync(Guid.Parse(sessionValue));

                if (businessModel != null)
                {
                    Address = new List<AddressIndexModel>();
                    businessModel?.ToList().ForEach(dto => Address.Add(new AddressIndexModel
                    { Street = dto.Street, StreetNumber = dto.StreetNumber, ZipCode = dto.ZipCode, City = dto.City , Id = dto.Id }));
                }
            }
        }

    }
}
