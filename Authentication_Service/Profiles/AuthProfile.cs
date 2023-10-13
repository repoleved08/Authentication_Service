using AutoMapper;
using HMS_Authentication.Models;
using HMS_Authentication.Models.Dto;

namespace HMS_Authentication.Profiles
{
    public class AuthProfile : Profile
    {
        public AuthProfile()
        {
            CreateMap<RegisterRequestDto, ApplicationUser>()
            .ForMember(dest=>dest.UserName, u=>u.MapFrom(reg=>reg.Email));
        }
    }
}
