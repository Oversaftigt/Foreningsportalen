using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Crosscut.TransactionHandling;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.Implementations
{
    public class MemberCommands : IMemberCommands
    {
        private readonly IMemberRepository _UnionMemberRepository;
        private readonly IUnionRepository _UnionRepository;
        private readonly IAddressRepository _AddressRepository;
        private readonly IUnitOfWork _UnitOfWork;

        public MemberCommands(IMemberRepository unionMemberRepository,
                                   IUnionRepository unionRepository,
                                   IAddressRepository addressRepository,
                                   IUnitOfWork unitOfWork)
        {
            _UnionMemberRepository = unionMemberRepository;
            _UnionRepository = unionRepository;
            _AddressRepository = addressRepository;
            _UnitOfWork = unitOfWork;
        }
        void IMemberCommands.CreateUnionMember(MemberCreateRequestDto createRequestDto)
        {
            try
            {
                _UnitOfWork.BeginTransaction();

                var union = _UnionRepository.GetUnion(createRequestDto.UnionId);
                if (union is null) throw new Exception("Union not found when trying to create member");
                var address = _AddressRepository.GetAddress(createRequestDto.AddressId);
                if (address is null) throw new Exception("Address not found when trying to create member");

                var newUnionMember = Domain.Entities.Member.Create(createRequestDto.FirstName,
                                                                        createRequestDto.LastName,
                                                                        createRequestDto.MoveInDate,
                                                                        union,
                                                                        address,
                                                                        createRequestDto.Email,
                                                                        createRequestDto.PhoneNumber);

                _UnionMemberRepository.CreateUnionMember(newUnionMember);
                _UnitOfWork.Commit();
            }
            catch
            {
                try
                {
                    _UnitOfWork?.Rollback();
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

