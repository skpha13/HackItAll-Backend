﻿using HackItAll_Backend.DTOs.Battery;
using HackItAll_Backend.DTOs.Car;
using HackItAll_Backend.DTOs.Model;
using HackItAll_Backend.DTOs.Reservation;
using HackItAll_Backend.DTOs.Station;
using HackItAll_Backend.Models;

namespace backend.Helpers;

public class MapperProfile : AutoMapper.Profile
{
    public MapperProfile()
    {
        CreateMap<Car, CarBrandDto>();
        CreateMap<Car, CarModelDto>();
        CreateMap<string, CarBrandDto>()
            .ForMember(c => c.brand, opt => opt.MapFrom(src => src));
        CreateMap<string, CarModelDto>()
            .ForMember(c => c.model, opt => opt.MapFrom(src => src));

        CreateMap<Model, ModelDto>();
        CreateMap<ModelDto, Model>();

        CreateMap<Station, StationDto>();

        CreateMap<Battery, BatteryDto>()
            .ForMember(b => b.model,
            opt => opt.MapFrom(src => new ModelDto {
                id = src.model.Id,
                name = src.model.name,
            }
            )) ;
        CreateMap<BatteryDto, Battery>();

        CreateMap<Station, StationWithBatteriesDto>()
            .ForMember(s => s.batteries, opt => opt.MapFrom(src => src.batteries.Select(
                b =>

                    new BatteryDto
                    {
                        id = b.Id,
                        maxCapacity = b.maxCapacity,
                        model = new ModelDto
                        {
                            id = b.model.Id,
                            name = b.model.name,
                        },
                        reservationDto = new ReservationDto
                        {
                            name = b.model.name,
                            batteryId = b.Id
                        },
                        capacity = b.capacity,
                        state = b.state,
                        percentage = 100.0f * b.capacity / b.maxCapacity,

                    }
                ))); ;
        CreateMap<StationWithBatteriesDto, Station>();

        CreateMap<Battery, BatteryWithStationDto>();

        CreateMap<Reservation, ReservationDto>();
        CreateMap<ReservationDto, Reservation>();
    }
}