using ForeningsPortalen.Website.DTOs.Member;

namespace ForeningsPortalen.WebApp.Proxy_s
{
    public class MemberService
    {
        private readonly HttpClient _httpClient;

        public MemberService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Create(MemberCreateRequestDto memberCreateRequest)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Member", memberCreateRequest);

            if (response.IsSuccessStatusCode) return;

            var message = await response.Content.ReadAsStringAsync();
            throw new Exception(message);
        }

        //async Task ILevSundtService.Edit(BmiEditRequestDto bmiEditRequestDto)
        //{
        //    var response = await _httpClient.PutAsJsonAsync("api/Bmi", bmiEditRequestDto);

        //    if (response.IsSuccessStatusCode) return;

        //    var messages = await response.Content.ReadAsStringAsync();
        //    throw new Exception(messages);
        //}

        //async Task<BmiQueryResultDto?> ILevSundtService.Get(int id, string userId)
        //{
        //    return await _httpClient.GetFromJsonAsync<BmiQueryResultDto>($"api/Bmi/{id}/{userId}");
        //}

        //async Task<IEnumerable<BmiQueryResultDto>?> ILevSundtService.GetAll(string userId)
        //{
        //    return await _httpClient.GetFromJsonAsync<IEnumerable<BmiQueryResultDto>>($"api/Bmi/{userId}");
        //}
    }
}
