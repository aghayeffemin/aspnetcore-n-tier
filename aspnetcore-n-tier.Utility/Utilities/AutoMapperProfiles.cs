using aspnetcore_n_tier.DTO.DTOs;
using aspnetcore_n_tier.Entity.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace aspnetcore_n_tier.Utility.Utilities
{
    public static class AutoMapperProfiles
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                CreateMap<User, UserToListDTO>().ReverseMap();
                CreateMap<User, UserToAddDTO>().ReverseMap();
                CreateMap<User, UserToUpdateDTO>().ReverseMap();
            }
        }
    }
}
