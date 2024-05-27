using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models.Address;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.Addresses
{
    public class IndexModel : PageModel
    {
        private readonly IAddressService _addressService;
        public IndexModel(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [BindProperty]
        public List<AddressIndexModel> Address { get; set; } = new();

        public async Task OnGetAsync()
        {
            var activeUnionId = User.Claims.FirstOrDefault(x => x.Type == "UnionId");
            if (activeUnionId != null)
            {
                var allAddresses = await _addressService.GetAllAddressesAsync(Guid.Parse(activeUnionId.Value));

                if (allAddresses != null)
                {
                    allAddresses?.ToList().ForEach(dto => Address.Add(new AddressIndexModel
                    { Street = dto.Street, StreetNumber = dto.Number, ZipCode = dto.PostalCode, City = dto.CityName, Id = dto.Id }));
                }
            }
        }

    }
}
