using AutoMapper;
using HorseEggs.Core.DTOs.ProgramLearningOutcomes;
using HorseEggs.Core.Entities;
using HorseEggs.Core.Interfaces;
using HorseEggs.Core.Responses;
using HorseEggs.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Services
{
    internal class ProgramLearningOutcomesService : IProgramLearningOutcomesService
    {
        private readonly IRepository<ProgramLearningOutcomes> _programLearningOutcomesRepo;
        private readonly IMapper _mapper;
        public ProgramLearningOutcomesService(IRepository<ProgramLearningOutcomes> ProgramLearningOutcomesRepo, IMapper mapper)
        {
            _programLearningOutcomesRepo = ProgramLearningOutcomesRepo;
            _mapper = mapper;
        }
        public async Task Create(CreateProgramLearningOutcomesDto createProgramLearningOutcomesDto)
        {
            await _programLearningOutcomesRepo.Insert(_mapper.Map<CreateProgramLearningOutcomesDto, ProgramLearningOutcomes>(createProgramLearningOutcomesDto));
            await _programLearningOutcomesRepo.Save();
        }

        public async Task<ProgramLearningOutcomesDto?> Get(int id)
        {
            if (id < 0) return null;
            ProgramLearningOutcomes? competence = await _programLearningOutcomesRepo.GetByID(id);
            if (competence == null) return null;
            return _mapper.Map<ProgramLearningOutcomesDto?>(competence);
        }

        public async Task Delete(int id)
        {
            ProgramLearningOutcomesDto? model = await Get(id);
            if (model == null) return;
            await _programLearningOutcomesRepo.Delete(id);
            await _programLearningOutcomesRepo.Save();
        }

        public async Task<ServiceResponse<List<ProgramLearningOutcomesDto>, object>> GetAll(int page = 1, int pageSize = 10, string userId = null)
        {
            var result = await _programLearningOutcomesRepo.GetListBySpec(new ProgramLearningOutcomesSpecification.GetByPagination(page, pageSize, userId));
            return new ServiceResponse<List<ProgramLearningOutcomesDto>, object>(success: true, message: "", payload: _mapper.Map<List<ProgramLearningOutcomesDto>>(result));
        }

        public async Task<ServiceResponse<List<ProgramLearningOutcomesDto>, object>> GetByUserId(string UserId)
        {
            var result = await _programLearningOutcomesRepo.GetListBySpec(new ProgramLearningOutcomesSpecification.GetByUserId(UserId));
            return new ServiceResponse<List<ProgramLearningOutcomesDto>, object>(success: true, message: "", payload: _mapper.Map<List<ProgramLearningOutcomesDto>>(result));
        }

        public async Task Update(UpdateProgramLearningOutcomesDto updateProgramLearningOutcomesDto)
        {
            await _programLearningOutcomesRepo.Update(_mapper.Map<UpdateProgramLearningOutcomesDto, ProgramLearningOutcomes>(updateProgramLearningOutcomesDto));
            await _programLearningOutcomesRepo.Save();
        }
    }
}
