using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Domain.Validation;
using ForeningsPortalen.Infrastructure.ThirdPartyIntegrations;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.Test.UnitTest
{
    public class AddressUnitTest
    {

        private readonly IConfigurationRoot _config;

        public AddressUnitTest()
        {

            _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        }

        [Fact]
        public void AddressIsValid_ValidAddress_IsValidAddressConfirmedByDawa()
        {
            //Arrange
            DawaAddressValidationService dawaValidationService = new(new HttpClient(), _config);
            string address = "Boulevarden 25, 7100 Vejle";
            string address2 = "Borger gade 4, STTV, 6000 Kolding";

            //Act
            bool addressResult = dawaValidationService.AddressIsValid(address);
            bool address2Result = dawaValidationService.AddressIsValid(address2);

            //Assert
            Assert.True(addressResult);
            Assert.True(address2Result);

        }
    }
}
