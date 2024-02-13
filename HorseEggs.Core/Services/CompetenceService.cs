using AutoMapper;
using HorseEggs.Core.DTOs.Competence;
using HorseEggs.Core.Entities;
using HorseEggs.Core.Interfaces;
using HorseEggs.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Services
{
    internal class CompetenceService : ICompetenceService
    {
        private readonly IRepository<Competence> _competenceRepo;
        private readonly IMapper _mapper;
        public CompetenceService(IRepository<Competence> competenceRepo, IMapper mapper)
        {
            _competenceRepo = competenceRepo;
            _mapper = mapper;
        }
        public async Task Create(CreateCompetenceDto competenceDto)
        {
            await _competenceRepo.Insert(_mapper.Map<CreateCompetenceDto, Competence>(competenceDto));
            await _competenceRepo.Save();

        }

        public async Task<CompetenceDto?> Get(int id)
        {
            if (id < 0) return null;
            Competence? competence = await _competenceRepo.GetByID(id);
            if (competence == null) return null;
            return _mapper.Map<CompetenceDto?>(competence);
        }

        public async Task Delete(int id)
        {
            CompetenceDto? model = await Get(id);
            if (model == null) return;
            await _competenceRepo.Delete(id);
            await _competenceRepo.Save();
        }

        public async Task<List<CompetenceDto>> GetAll()
        {
            var result = await _competenceRepo.GetAll();
            return _mapper.Map<List<CompetenceDto>>(result);
        }

        public async Task<List<CompetenceDto>> GetByUserId(string UserId)
        {
            var result = await _competenceRepo.GetListBySpec(new CompetenceSpecification.GetByUserId(UserId));
            return _mapper.Map<List<CompetenceDto>>(result);
        }

        public async Task Update(UpdateCompetenceDto competenceDto)
        {
            await _competenceRepo.Update(_mapper.Map<UpdateCompetenceDto, Competence>(competenceDto));
            await _competenceRepo.Save();
        }
    }
}
