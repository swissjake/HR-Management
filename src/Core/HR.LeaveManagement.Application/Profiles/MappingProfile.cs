using AutoMapper;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Domain;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
    }
}