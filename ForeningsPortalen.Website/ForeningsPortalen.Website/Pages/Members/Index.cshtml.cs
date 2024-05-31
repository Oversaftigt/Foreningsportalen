using ForeningsPortalen.Website.HelperServices;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Address;
using ForeningsPortalen.Website.Models.Union;
using ForeningsPortalen.Website.Pages.Admin.Unions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly IMemberService _memberService;
        public IndexModel(IMemberService addressService)
        {
            _memberService = addressService;
        }

        [BindProperty]
        public List<IndexMemberModel> Members { get; set; } = new();

        public async Task OnGetAsync()
        {
            var activeUnionId = User.Claims.FirstOrDefault(x => x.Type == "UnionId");
            if (activeUnionId != null)
            {
                var members = await _memberService.GetAllMembersAsync(Guid.Parse(activeUnionId.Value));

                if (members != null)
                {
                    members?.ToList().ForEach(dto => Members.Add(new IndexMemberModel
                    { FirstName = dto.FirstName, LastName = dto.LastName, EmailAddress = dto.Email, 
                      Phone = dto.PhoneNumber, Id = dto.Id, MoveInDate = dto.MoveInDate, MoveOutDate = dto.MoveOutDate}));
                }
            }
        }

    }
}
