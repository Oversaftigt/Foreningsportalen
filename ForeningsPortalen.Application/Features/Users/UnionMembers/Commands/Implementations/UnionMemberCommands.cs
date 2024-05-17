using ForeningsPortalen.Application.Features.Addresses.Repositories;
using ForeningsPortalen.Application.Features.Unions.Repositories;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Repositories;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.Implementations
{
    public class UnionMemberCommands : IUnionMemberCommands
    {
        private readonly IUnionMemberRepository _UnionMemberRepository;
        private readonly IUnionRepository _UnionRepository;
        private readonly IAddressRepository _AddressRepository;

        public UnionMemberCommands(IUnionMemberRepository unionMemberRepository,
                                   IUnionRepository unionRepository,
                                   IAddressRepository addressRepository)
        {
            _UnionMemberRepository = unionMemberRepository;
            _UnionRepository = unionRepository;
            _AddressRepository = addressRepository;
        }
        void IUnionMemberCommands.CreateUnionMember(UnionMemberCreateRequestDto createRequestDto)
        {
            var union = _UnionRepository.GetOneUnion(createRequestDto.UnionId);
            if (union is null) throw new Exception("Union not found");
            var address = _AddressRepository.GetAddressById(createRequestDto.AddressId);
            if (address is null) throw new Exception("Address not found");
            var newUnionMember = Domain.Entities.UnionMember.Create(createRequestDto.FirstName,
                                                                    createRequestDto.LastName,
                                                                    createRequestDto.MoveInDate,
                                                                    union,
                                                                    address);
            _UnionMemberRepository.CreateUnionMember(newUnionMember);
        }

        void IUnionMemberCommands.DeleteUnionMember(UnionMemberDeleteRequestDto deleteRequestDto)
        {
            throw new NotImplementedException();
        }

        void IUnionMemberCommands.UpdateUnionMember(UnionMemberUpdateRequestDto updateRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
