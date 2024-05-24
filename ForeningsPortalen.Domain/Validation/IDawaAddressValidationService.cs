using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.Validation
{
    public interface IDawaAddressValidationService
    {
        bool AddressIsValid(string fullAddress);
    }
}
