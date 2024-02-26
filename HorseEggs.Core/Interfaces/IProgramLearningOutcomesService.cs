using HorseEggs.Core.DTOs.ProgramLearningOutcomes;
using HorseEggs.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Interfaces
{
    public interface IProgramLearningOutcomesService
    {
        Task Create(CreateProgramLearningOutcomesDto competenceDto);
        Task Update(UpdateProgramLearningOutcomesDto competenceDto);
        Task Delete(int id);
        Task<PaginationResponse<List<ProgramLearningOutcomesDto>, object>> GetAll(int page = 1, int pageSize = 10, string userId = null);
        Task<ServiceResponse<List<ProgramLearningOutcomesDto>, object>> GetByUserId(string UserId);
        Task<ProgramLearningOutcomesDto?> Get(int id);
    }
}
