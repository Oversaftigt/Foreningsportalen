using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Helpers;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Domain.Validation;
using System.Security.Cryptography;

namespace ForeningsPortalen.Application.Features.Addresses.Commands.Implementations
{
    public class AddressCommands : IAddressCommands
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IUnionRepository _unionRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;

        public AddressCommands(IAddressRepository addressRepository, IUnionRepository unionRepository, IUnitOfWork unitOfWork, IServiceProvider serviceProvider)
        {
            _addressRepository = addressRepository;
            _unionRepository = unionRepository;
            _unitOfWork = unitOfWork;
            this._serviceProvider = serviceProvider;
        }

        void IAddressCommands.CreateAddress(AddressCreateRequestDto addressCreateRequestDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var union = _unionRepository.GetUnion(addressCreateRequestDto.UnionId);
                if (union is null) throw new Exception("Union not found");

                var address = Address.Create(addressCreateRequestDto.StreetName, addressCreateRequestDto.StreetNumber, 
                                                 addressCreateRequestDto.Floor, addressCreateRequestDto.Door,
                                                 addressCreateRequestDto.City, addressCreateRequestDto.ZipCode, 
                                                 union, _serviceProvider);

                _addressRepository.AddAddress(address);
                _unitOfWork.Commit();
            }
            catch
            {
                try
                {
                    _unitOfWork?.Rollback();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Rollback has failed: {ex.Message}");
                }
                throw;
            }
        }

        void IAddressCommands.UpdateAddress(AddressUpdateRequestDto addressUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        void IAddressCommands.DeleteAddress(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }
    }
}
