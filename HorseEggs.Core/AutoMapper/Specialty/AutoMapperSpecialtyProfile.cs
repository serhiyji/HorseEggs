using AutoMapper;
using HorseEggs.Core.DTOs.Specialty;
using HorseEggs.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.AutoMapper.Specialty
{
    public class AutoMapperSpecialtyProfile : Profile
    {
        public AutoMapperSpecialtyProfile()
        {
            CreateMap<Entities.Specialty, SpecialtyDto>().ReverseMap();
            CreateMap<Entities.Specialty, CreateSpecialtyDto>().ReverseMap();
            CreateMap<Entities.Specialty, UpdateSpecialtyDto>().ReverseMap();
        }
    }
}
