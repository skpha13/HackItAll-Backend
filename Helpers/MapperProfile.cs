using HackItAll_Backend.DTOs.Car;
using HackItAll_Backend.Models;

namespace backend.Helpers;

public class MapperProfile : AutoMapper.Profile
{
    public MapperProfile()
    {
        CreateMap<Car, CarBrandDto>();
        CreateMap<Car, CarModelDto>();
        CreateMap<string, CarBrandDto>()
            .ForMember(c => c.brand, opt => opt.MapFrom(src => src)); ;
    }
}