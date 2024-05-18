using ForeningsPortalen.WebApp.DTOs;
using ForeningsPortalen.WebApp.ViewModels;

namespace ForeningsPortalen.WebApp.ViewModels.AddressViews
{
    public class RegisterAddressesViewModel : BaseLayoutViewModel
    {
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}
