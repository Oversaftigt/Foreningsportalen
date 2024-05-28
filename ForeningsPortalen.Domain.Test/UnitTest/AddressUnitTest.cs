using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Domain.Validation;
using ForeningsPortalen.Infrastructure.ThirdPartyIntegrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.Test.UnitTest
{
    public class AddressUnitTest
    {
        private readonly IDawaAddressValidationService dawa;

        public AddressUnitTest(IDawaAddressValidationService dawa)
        {
            this.dawa = dawa;
        }

        [Fact]
        public void AddressIsValid_ValidAddress_IsValidAddressConfirmedByDawa()
        {
            //Arrange

            string address = "Boulevarden 25, 7100 Vejle";
            string address2 = "Borger gade 4, STTV, 6000 Kolding";

            //Act
            bool addressResult = dawa.AddressIsValid(address);
            bool address2Result = dawa.AddressIsValid(address2);

            //Assert
            Assert.True(addressResult);
            Assert.True(address2Result);

        }
    }
}
