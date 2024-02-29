using AutoMapper;
using HorseEggs.Core.DTOs.StandartEducationalProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.AutoMapper.StandartEducationalProgram
{
    public class AutoMapperStandartEducationalProgramProfile : Profile
    {
        public AutoMapperStandartEducationalProgramProfile()
        {
            CreateMap<Entities.StandartEducationalProgram, StandartEducationalProgramDto>().ReverseMap();
            CreateMap<Entities.StandartEducationalProgram, CreateStandartEducationalProgramDto>().ReverseMap();
            CreateMap<Entities.StandartEducationalProgram, UpdateStandartEducationalProgramDto>().ReverseMap();
        }
    }
}
