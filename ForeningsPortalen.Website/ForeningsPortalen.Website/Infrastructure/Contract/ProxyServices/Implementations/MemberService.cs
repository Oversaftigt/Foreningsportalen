using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Member;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using System.Net.Http;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations
{
    public class MemberService : IMemberService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<MemberService> _logger;

        public MemberService(IHttpClientFactory httpClientFactory, ILogger<MemberService> logger)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
            _logger = logger;
        }

        async Task IMemberService.PutMemberAsync(MemberUpdateRequestDto memberUpdateRequest)
        {
            throw new NotImplementedException();
        }
        async Task IMemberService.PostMemberAsync(MemberCreateRequestDto memberCreateRequest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_httpClient.BaseAddress}api/Member", memberCreateRequest);

            if (response.IsSuccessStatusCode) return;

            var message = await response.Content.ReadAsStringAsync();
            throw new Exception(message);
        }
        async Task<MemberQueryResultDto?> IMemberService.GetMemberAsync(int id, string identityName)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<MemberQueryResultDto>?> IMemberService.GetAllMembersAsync(Guid unionId)
        {
            try
            {

                var request = new HttpRequestMessage(HttpMethod.Get, $"{_httpClient.BaseAddress}api/member/union/{unionId}/member");

                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var addresses = await response.Content.ReadFromJsonAsync<IEnumerable<MemberQueryResultDto>>();

                return addresses;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }

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
