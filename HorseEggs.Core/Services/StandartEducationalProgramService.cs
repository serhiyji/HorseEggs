using AutoMapper;
using HorseEggs.Core.DTOs.Specialty;
using HorseEggs.Core.DTOs.StandartEducationalProgram;
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
    internal class StandartEducationalProgramService : IStandartEducationalProgramService
    {
        private readonly IRepository<StandartEducationalProgram> _standartEducationalProgramRepo;
        private readonly IMapper _mapper;
        public StandartEducationalProgramService(IRepository<StandartEducationalProgram> standartEducationalProgramRepo, IMapper mapper)
        {
            _standartEducationalProgramRepo = standartEducationalProgramRepo;
            _mapper = mapper;
        }
        public async Task Create(CreateStandartEducationalProgramDto createStandartEducationalProgramDto)
        {
            await _standartEducationalProgramRepo.Insert(_mapper.Map<CreateStandartEducationalProgramDto, StandartEducationalProgram>(createStandartEducationalProgramDto));
            await _standartEducationalProgramRepo.Save();
        }

        public async Task Delete(int id)
        {
            StandartEducationalProgramDto? model = await Get(id);
            if (model == null) return;
            await _standartEducationalProgramRepo.Delete(id);
            await _standartEducationalProgramRepo.Save();
        }

        public async Task<StandartEducationalProgramDto?> Get(int id)
        {
            if (id < 0) return null;
            StandartEducationalProgram? competence = await _standartEducationalProgramRepo.GetByID(id);
            if (competence == null) return null;
            return _mapper.Map<StandartEducationalProgramDto?>(competence);
        }

        public async Task<PaginationResponse<List<StandartEducationalProgramDto>, object>> GetAll(int page = 1, int pageSize = 10)
        {
            var result = await _standartEducationalProgramRepo.GetListBySpec(new StandartEducationalProgramSpecification.GetByPagination(page, pageSize));
            var res = await _standartEducationalProgramRepo.GetAll();
            return new PaginationResponse<List<StandartEducationalProgramDto>, object>(
                    success: true, message: "", payload: _mapper.Map<List<StandartEducationalProgramDto>>(result),
                    pageNumber: page, pageSize: pageSize, totalCount: res.Count()
                );
        }

        public async Task Update(UpdateStandartEducationalProgramDto updateStandartEducationalProgramDto)
        {
            await _standartEducationalProgramRepo.Update(_mapper.Map<UpdateStandartEducationalProgramDto, StandartEducationalProgram>(updateStandartEducationalProgramDto));
            await _standartEducationalProgramRepo.Save();
        }
    }
}
