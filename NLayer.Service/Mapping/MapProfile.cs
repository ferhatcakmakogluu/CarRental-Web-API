using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Account, AccountDto>().ReverseMap();
            CreateMap<CarFeature, CarFeatureDto>().ReverseMap();
            CreateMap<User, UserWithCarsDto>();
        }
    }
}
