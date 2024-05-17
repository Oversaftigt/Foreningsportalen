using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.Implementations
{
    public class MemberCommands : IMemberCommands
    {
        private readonly IMemberRepository _UnionMemberRepository;
        private readonly IUnionRepository _UnionRepository;
        private readonly IAddressRepository _AddressRepository;

        public MemberCommands(IMemberRepository unionMemberRepository,
                                   IUnionRepository unionRepository,
                                   IAddressRepository addressRepository)
        {
            _UnionMemberRepository = unionMemberRepository;
            _UnionRepository = unionRepository;
            _AddressRepository = addressRepository;
        }
        void IMemberCommands.CreateUnionMember(MemberCreateRequestDto createRequestDto)
        {
            var union = _UnionRepository.GetOneUnion(createRequestDto.UnionId);
            if (union is null) throw new Exception("Union not found");
            var address = _AddressRepository.GetAddress(createRequestDto.AddressId);
            if (address is null) throw new Exception("Address not found");

            var newUnionMember = Domain.Entities.Member.Create(createRequestDto.FirstName,
                                                                    createRequestDto.LastName,
                                                                    createRequestDto.MoveInDate,
                                                                    union,
                                                                    address,
                                                                    createRequestDto.Email,
                                                                    createRequestDto.PhoneNumber);

            _UnionMemberRepository.CreateUnionMember(newUnionMember);
        }

        void IMemberCommands.DeleteUnionMember(MemberDeleteRequestDto deleteRequestDto)
        {
            throw new NotImplementedException();
        }

        void IMemberCommands.UpdateUnionMember(MemberUpdateRequestDto updateRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
