using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ForeningsPortalen.Website.Contract;
using Microsoft.EntityFrameworkCore.Metadata;
using ForeningsPortalen.Website.DTOs.Address;
using ForeningsPortalen.Website.Models.Address;

namespace ForeningsPortalen.Website.Pages.Addresses
{
    public class CreateModel : PageModel
    {
        private readonly IAddressService _addressService;

        public CreateModel(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CreateAddressModel Address { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var sessionValue = HttpContext.Session.GetString("Union");
            if (sessionValue != null)
            {               
                var dto = new AddressCreateRequestDto
            {
                StreetName = Address.Street,
                StreetNumber = Address.StreetNumber,
                Floor = Address.Floor,
                Door = Address.Door,
                ZipCode = Address.ZipCode,
                City = Address.City,
                UnionId = Guid.Parse(sessionValue)
            };
                
                await _addressService.PostAddressAsync(dto);
            }

            return RedirectToPage("./Index");
        }
    }
}
