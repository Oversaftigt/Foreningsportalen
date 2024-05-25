using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Models.Address;
using ForeningsPortalen.Website.Contract;

namespace ForeningsPortalen.Website.Pages.Addresses
{
    public class DetailsModel : PageModel
    {
        private readonly IAddressService _addressService;

        public DetailsModel(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public AddressIndexModel Address { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var dto = await _addressService.GetAddressAsync(id);

            if (dto != null)
            {
                Address = new AddressIndexModel()
                { Street = dto.Street, StreetNumber = dto.StreetNumber, ZipCode = dto.ZipCode, City = dto.City, Id = dto.Id };
            }
            //if (address == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    Address = address;
            //}
            return Page();
        }
    }
}
