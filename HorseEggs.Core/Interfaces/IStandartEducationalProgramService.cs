using HorseEggs.Core.DTOs.Competence;
using HorseEggs.Core.DTOs.StandartEducationalProgram;
using HorseEggs.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Interfaces
{
    public interface IStandartEducationalProgramService
    {
        Task Create(CreateStandartEducationalProgramDto createStandartEducationalProgramDto);
        Task Update(UpdateStandartEducationalProgramDto updateStandartEducationalProgramDto);
        Task Delete(int id);
        Task<PaginationResponse<List<StandartEducationalProgramDto>, object>> GetAll(int page = 1, int pageSize = 10);
        Task<StandartEducationalProgramDto?> Get(int id);
    }
}
