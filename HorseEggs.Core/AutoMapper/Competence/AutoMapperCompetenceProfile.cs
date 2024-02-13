using AutoMapper;
using HorseEggs.Core.DTOs.Competence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.AutoMapper.Competence
{
    public class AutoMapperCompetenceProfile : Profile
    {
        public AutoMapperCompetenceProfile()
        {
            CreateMap<Entities.Competence, CompetenceDto>().ReverseMap();
            CreateMap<Entities.Competence, CreateCompetenceDto>().ReverseMap();
            CreateMap<Entities.Competence, UpdateCompetenceDto>().ReverseMap();
        }
    }
}
