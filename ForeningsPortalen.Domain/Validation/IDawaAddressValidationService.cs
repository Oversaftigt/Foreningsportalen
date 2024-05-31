namespace ForeningsPortalen.Domain.Validation
{
    public interface IDawaAddressValidationService
    {
        bool AddressIsValid(string fullAddress);
    }
}
