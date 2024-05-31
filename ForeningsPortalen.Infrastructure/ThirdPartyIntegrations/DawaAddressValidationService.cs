using ForeningsPortalen.Domain.Validation;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace ForeningsPortalen.Infrastructure.ThirdPartyIntegrations
{
    public class DawaAddressValidationService : IDawaAddressValidationService
    {
        private readonly HttpClient _client;
        private readonly string _baseAddress;

        public DawaAddressValidationService(HttpClient client, IConfiguration configuration)
        {
            this._client = client;
            _baseAddress = configuration["DawaBaseUri"];
        }

        public bool AddressIsValid(string fullAddress)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, _baseAddress+$"?betegnelse={Uri.EscapeDataString(fullAddress)}");
            HttpResponseMessage? response = _client.Send(request);
            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            //using jsondocument to get the value of a single property from the full json from the api
            using JsonDocument jsonDoc = JsonDocument.Parse(responseBody);
            JsonElement root = jsonDoc.RootElement;

            string category = root.GetProperty("kategori").GetString();

            if (category == "A" || category == "B")
            {
            return true;
            }
            else
            {
                return false;
            }
        }
    }
}
