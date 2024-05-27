using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Domain.Helpers;
using ForeningsPortalen.Domain.Validation;
using Moq;

namespace ForeningsPortalen.Domain.Test.UnitTest;

public class DomainUnitTest
{
    [Fact]
    public void CreateMemberTest()
    {
        // Arrange
        string firstName = "John";
        string lastName = "Doe";
        DateTime moveInDate = new DateTime(2022, 1, 1);
        var union = new Mock<Union>().Object;
        var address = new Mock<Address>().Object;
        string email = "john.doe@example.com";
        string phoneNumber = "1234567890";

        // Act
        var result = Member.Create(firstName, lastName, moveInDate, union, address, email, phoneNumber);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(firstName, result.FirstName);
        Assert.Equal(lastName, result.LastName);
        Assert.Equal(DateOnly.FromDateTime(moveInDate), result.MoveInDate);
        Assert.Equal(address, result.Address);
        Assert.Equal(email, result.Email);
        Assert.Equal(phoneNumber, result.PhoneNumber);
    }

    [Fact]
    public void CreateAddress()
    {
        // Arrange
        var streetName = "Main Street";
        var streetNumber = 123;
        var floor = "1";
        var door = "A";
        var city = "Copenhagen";
        var zipCode = 1000;
        var MockUnion = new Mock<Union>(); 

        var mockServiceProvider = new Mock<IServiceProvider>();
        var mockDawaService = new Mock<IDawaAddressValidationService>();

        mockServiceProvider.Setup(sp => sp.GetService(typeof(IDawaAddressValidationService)))
                           .Returns(mockDawaService.Object);

        mockDawaService.Setup(ds => ds.AddressIsValid(It.IsAny<string>())).Returns(true);

        // Act
        var address = Address.Create(streetName, streetNumber, floor, door, city, zipCode, MockUnion.Object, mockServiceProvider.Object);

        // Assert
        Assert.NotNull(address);
        Assert.Equal(streetName, address.StreetName);
        Assert.Equal(streetNumber, address.StreetNumber);
        Assert.Equal(floor, address.Floor);
        Assert.Equal(door, address.Door);
        Assert.Equal(city, address.City);
        Assert.Equal(zipCode, address.ZipCode);
        Assert.Equal(MockUnion.Object, address.Union);
    
    }

    [Fact]
    public void CreateUnion()
    {
        //Arrange
        var union = "Skanderborg Boligforening";

        //Act
        var newUnion = Union.Create(union);

        //Assert
        Assert.NotNull(newUnion);
        Assert.Equal(union, newUnion.Name); 
    }



}

