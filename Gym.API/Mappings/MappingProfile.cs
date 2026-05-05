using AutoMapper;
using Gym.API.DTOs.Request;
using Gym.API.DTOs.Response;
using Gym.Domain.Entities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Member, MemberResponseDTO>();
        CreateMap<MemberRequestDTO, Member>();
    }
}