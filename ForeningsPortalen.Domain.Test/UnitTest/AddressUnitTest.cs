using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Domain.Validation;
using ForeningsPortalen.Infrastructure.ThirdPartyIntegrations;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        [Theory]
        [InlineData("Boulevarden 25, 7100 Vejle", true)]
        [InlineData("Boulevarden 19E, 7100 Vejle", true)]
        [InlineData("Borger gade 4, STTV, 6000 Kolding", true)]
        [InlineData("Rante mester vej 8, 4, 2400 København NV", true)]
        [InlineData("Main Street 123, 1, A, 1000 København", false)]
        [InlineData("Boulevarden 25B, 7100 Vejle", false)]
        [InlineData("VerdensLængsteVej 9999, 9990 Skagen", false)]
        public void AddressIsValid_ShouldValidateCorrectly(string address, bool expected)
        {
            //Arrange
            DawaAddressValidationService dawaValidationService = new(new HttpClient(), _config);

            //Act
            bool addressResult = dawaValidationService.AddressIsValid(address);

            //Assert
            Assert.Equal(addressResult, expected);
        }

        [Theory]
        [InlineData("st", true)]
        [InlineData("kl", true)]
        [InlineData("1", true)]
        [InlineData("78", true)]
        [InlineData("99", true)]
        [InlineData("k1", true)]
        [InlineData("k5", true)]
        [InlineData("k9", true)]
        [InlineData("Hej", false)]
        [InlineData("0", false)]
        [InlineData("100", false)]
        [InlineData("k10", false)]
        [InlineData("k0", false)]
        public void IsFloorValid_ShouldValidateCorrectly(string floor, bool expected)
        {
            var methodInfo = typeof(Address).GetMethod("IsFloorValid", BindingFlags.NonPublic | BindingFlags.Static);
            if (methodInfo == null)
            {
                throw new InvalidOperationException("Could not find method IsFloorValid.");
            }

            // Act
            var result = (bool)methodInfo.Invoke(null, new object[] { floor });

            // Assert
            Assert.Equal(result, expected);

        }

        [Theory]
        [InlineData("2", true)]
        [InlineData("tv", true)]
        [InlineData("a", true)]
        [InlineData("1kn3", false)]
        public void IsDoorValid_ShouldValidateCorrectly(string door, bool expected)
        {
            var methodInfo = typeof(Address).GetMethod("IsDoorValid", BindingFlags.NonPublic | BindingFlags.Static);
            if (methodInfo == null)
            {
                throw new InvalidOperationException("Could not find method IsDoorValid.");
            }

            // Act
            var result = (bool)methodInfo.Invoke(null, new object[] { door });

            // Assert
            Assert.Equal(result, expected);


        }
    }
}
