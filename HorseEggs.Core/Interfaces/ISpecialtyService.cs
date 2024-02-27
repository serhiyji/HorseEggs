using HorseEggs.Core.DTOs.Specialty;
using HorseEggs.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Interfaces
{
    public interface ISpecialtyService
    {
        Task Create(CreateSpecialtyDto createSpecialtyDto);
        Task Update(UpdateSpecialtyDto updateSpecialtyDto);
        Task Delete(int id);
        Task<PaginationResponse<List<SpecialtyDto>, object>> GetAll(int page = 1, int pageSize = 10);
        Task<SpecialtyDto?> Get(int id);
    }
}
