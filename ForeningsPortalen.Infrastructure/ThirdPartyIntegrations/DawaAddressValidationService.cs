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
            //Uri.EscapeDataString gør en string brugbar til en URI ved at erstatte ting såsom mellemrum
            //med et hexadecimal (fx mellemrum bliver til %20)
            var request = new HttpRequestMessage(HttpMethod.Get, _baseAddress+$"?betegnelse={Uri.EscapeDataString(fullAddress)}");
            HttpResponseMessage? response = _client.Send(request);
            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            //jsondocument bruges til at få værdien af en enkelt property fra den fulde json fra apikald
            using JsonDocument jsonDoc = JsonDocument.Parse(responseBody);
            JsonElement root = jsonDoc.RootElement;

            //Der tjekkes på den enkelte property kaldt "kategori", 
            string category = root.GetProperty("kategori").GetString();

            if (category is "A" or "B")
            {
                return true;
            } 
            return false;
            
        }
    }
}
