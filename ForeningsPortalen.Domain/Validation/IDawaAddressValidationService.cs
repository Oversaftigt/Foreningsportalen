namespace ForeningsPortalen.Domain.Validation
{
    public interface IDawaAddressValidationService
    {
        /// <summary>
        /// Returns true or false, to see if an address is valid
        /// </summary>
        /// <param name="fullAddress"></param>
        /// <returns></returns>
        bool AddressIsValid(string fullAddress);
    }
}
