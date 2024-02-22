using AutoMapper;
using HorseEggs.Core.DTOs.Competence;
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

        public async Task<PaginationResponse<List<CompetenceDto>, object>> GetAll(int page, int pageSize, string userId)
        {
            var result = await _competenceRepo.GetListBySpec(new CompetenceSpecification.GetByPagination(page, pageSize, userId));
            var res = await _competenceRepo.GetListBySpec(new CompetenceSpecification.GetByUserId(userId));
            return new PaginationResponse<List<CompetenceDto>, object>(
                    success:true, message:"", payload: _mapper.Map<List<CompetenceDto>>(result),
                    pageNumber: page, pageSize: pageSize, totalCount: res.Count()
                );
        }

        public async Task<PaginationResponse<List<CompetenceDto>, object>> GetByUserId(string UserId)
        {
            var result = await _competenceRepo.GetListBySpec(new CompetenceSpecification.GetByUserId(UserId));
            return new PaginationResponse<List<CompetenceDto>, object>(true, "", payload: _mapper.Map<List<CompetenceDto>>(result));
        }

        public async Task Update(UpdateCompetenceDto competenceDto)
        {
            await _competenceRepo.Update(_mapper.Map<UpdateCompetenceDto, Competence>(competenceDto));
            await _competenceRepo.Save();
        }
    }
}
