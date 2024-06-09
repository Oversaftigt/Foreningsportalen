using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Address;
using ForeningsPortalen.Website.Models.Member;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Security.Claims;

namespace ForeningsPortalen.Website.Pages.Members
{
    public class DetailsModel : PageModel
    {
        private readonly IMemberService _memberService;
        private readonly IAddressService _addressService;
        public DetailsModel(IMemberService memberService, IAddressService addressService)
        {
            _memberService = memberService;
            _addressService = addressService;
        }

        public MemberDetailsModel Member { get; set; } = default!;
        public AddressIndexModel Address { get; set; } = default!;

        public async Task OnGetAsync(string email)
        {
            var memberDetails = await _memberService.GetMemberByEmailAsync(email);

            if (memberDetails != null)
            {
                Member = new MemberDetailsModel()
                {
                    FirstName = memberDetails.FirstName,
                    LastName = memberDetails.LastName,
                    EmailAddress = memberDetails.Email,
                    Phone = memberDetails.PhoneNumber,
                    Id = memberDetails.Id,
                    MoveInDate = memberDetails.MoveInDate,
                    MoveOutDate = memberDetails.MoveOutDate,
                    AddressId = memberDetails.CurrentAddress
                };
            }
            var addressDetails = await _addressService.GetAddressAsync(memberDetails.CurrentAddress);
            if (addressDetails != null)
            {
                Address = new AddressIndexModel
                {
                    Id = addressDetails.Id,
                    Street = addressDetails.Street,
                    StreetNumber = addressDetails.Number,
                    Floor = addressDetails.Level,
                    Door = addressDetails.Door,
                    City = addressDetails.CityName,
                    ZipCode = addressDetails.PostalCode,
                };

            }

            Redirect("/Index");
        }

        //private async Task GetMemberDetails(string email)
        //{
            

        //}

    }
}
