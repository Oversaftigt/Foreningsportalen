using ForeningsPortalen.Application.Features.Addresses.Commands;
using ForeningsPortalen.Application.Features.Addresses.Commands.Implementations;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Crosscut.TransactionHandling;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.Implementations
{
    public class MemberCommands : IMemberCommands
    {
        private readonly IMemberRepository _unionMemberRepository;
        private readonly IUnionRepository _unionRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IUnitOfWork _unitOfWork;


        public MemberCommands(IMemberRepository unionMemberRepository,
                                   IUnionRepository unionRepository,
                                   IAddressRepository addressRepository,
                                   IUnitOfWork unitOfWork)
        {
            _unionMemberRepository = unionMemberRepository;
            _unionRepository = unionRepository;
            _addressRepository = addressRepository;
            _unitOfWork = unitOfWork;
        }
        void IMemberCommands.CreateUnionMember(MemberCreateRequestDto createRequestDto)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                var union = _unionRepository.GetUnion(createRequestDto.UnionId);
                if (union is null) throw new Exception("Union not found when trying to create member");
                var address = _addressRepository.GetAddress(createRequestDto.AddressId);
                if (address is null) throw new Exception("Address not found when trying to create member");

                var newUnionMember = Domain.Entities.Member.Create(createRequestDto.FirstName,
                                                                        createRequestDto.LastName,
                                                                        createRequestDto.MoveInDate,
                                                                        union,
                                                                        address,
                                                                        createRequestDto.Email,
                                                                        createRequestDto.PhoneNumber);


                _unionMemberRepository.CreateUnionMember(newUnionMember);
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

        void IMemberCommands.DeleteUnionMember(SharedEntityDeleteDto deleteRequestDto)
        {
            throw new NotImplementedException();
        }

        void IMemberCommands.UpdateUnionMember(MemberUpdateRequestDto updateRequestDto)
        {
            throw new NotImplementedException();
        }

    }

}

