using AutoMapper;
using HorseEggs.Core.DTOs.Competence;
using HorseEggs.Core.DTOs.Specialty;
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
    internal class SpecialtyService : ISpecialtyService
    {
        private readonly IRepository<Specialty> _specialtyRepo;
        private readonly IMapper _mapper;
        public SpecialtyService(IRepository<Specialty> specialtyRepo, IMapper mapper)
        {
            _specialtyRepo = specialtyRepo;
            _mapper = mapper;
        }
        public async Task Create(CreateSpecialtyDto createSpecialtyDto)
        {
            await _specialtyRepo.Insert(_mapper.Map<CreateSpecialtyDto, Specialty>(createSpecialtyDto));
            await _specialtyRepo.Save();
        }

        public async Task Delete(int id)
        {
            SpecialtyDto? model = await Get(id);
            if (model == null) return;
            await _specialtyRepo.Delete(id);
            await _specialtyRepo.Save();
        }

        public async Task<SpecialtyDto?> Get(int id)
        {
            if (id < 0) return null;
            Specialty? competence = await _specialtyRepo.GetByID(id);
            if (competence == null) return null;
            return _mapper.Map<SpecialtyDto?>(competence);
        }

        public async Task<PaginationResponse<List<SpecialtyDto>, object>> GetAll(int page = 1, int pageSize = 10)
        {
            var result = await _specialtyRepo.GetListBySpec(new SpecialtySpecification.GetByPagination(page, pageSize));
            var res = await _specialtyRepo.GetAll();
            return new PaginationResponse<List<SpecialtyDto>, object>(
                    success: true, message: "", payload: _mapper.Map<List<SpecialtyDto>>(result),
                    pageNumber: page, pageSize: pageSize, totalCount: res.Count()
                );
        }

        public async Task Update(UpdateSpecialtyDto updateSpecialtyDto)
        {
            await _specialtyRepo.Update(_mapper.Map<UpdateSpecialtyDto, Specialty>(updateSpecialtyDto));
            await _specialtyRepo.Save();
        }
    }
}
