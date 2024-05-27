using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models.Address;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
                { Street = dto.Street, StreetNumber = dto.Number, ZipCode = dto.PostalCode, City = dto.CityName, Id = dto.Id };
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
