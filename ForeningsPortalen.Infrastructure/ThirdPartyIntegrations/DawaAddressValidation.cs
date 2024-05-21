using ForeningsPortalen.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.ThirdPartyIntegrations
{
    public class DawaAddressValidation : IDawaAddressValidation
    {
        bool IDawaAddressValidation.AddressIsValid(string fullAddress)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.dataforsyningen.dk/datavask/adresser?betegnelse={Uri.EscapeDataString(fullAddress)}");
            HttpResponseMessage? response = client.Send(request);
            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            using JsonDocument jsonDoc = JsonDocument.Parse(responseBody);
            JsonElement root = jsonDoc.RootElement;

            string kategori = root.GetProperty("Kategori").GetString();

            if (kategori == "A" || kategori == "B")
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
