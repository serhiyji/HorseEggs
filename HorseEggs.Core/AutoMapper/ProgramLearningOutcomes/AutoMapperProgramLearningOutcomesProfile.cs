using AutoMapper;
using HorseEggs.Core.DTOs.ProgramLearningOutcomes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.AutoMapper.ProgramLearningOutcomes
{
    public class AutoMapperProgramLearningOutcomesProfile : Profile
    {
        public AutoMapperProgramLearningOutcomesProfile()
        {
            CreateMap<Entities.ProgramLearningOutcomes, ProgramLearningOutcomesDto>().ReverseMap();
            CreateMap<Entities.ProgramLearningOutcomes, CreateProgramLearningOutcomesDto>().ReverseMap();
            CreateMap<Entities.ProgramLearningOutcomes, UpdateProgramLearningOutcomesDto>().ReverseMap();
        }
    }
}
