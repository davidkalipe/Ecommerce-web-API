using AutoMapper;
using Ecommerce_web_api.DTOs;
using Ecommerce_web_api.Models;

namespace Ecommerce_web_api.Helpers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserInfoDto>().ReverseMap();
    }
}