using HorseEggs.Core.DTOs.ProgramLearningOutcomes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.Services;

namespace HorseEggs.Core.Interfaces
{
    public interface IProgramLearningOutcomesService
    {
        Task Create(CreateProgramLearningOutcomesDto competenceDto);
        Task Update(UpdateProgramLearningOutcomesDto competenceDto);
        Task Delete(int id);
        Task<ServiceResponse<List<ProgramLearningOutcomesDto>, object>> GetAll();
        Task<ServiceResponse<List<ProgramLearningOutcomesDto>, object>> GetByUserId(string UserId);
        Task<ProgramLearningOutcomesDto?> Get(int id);
    }
}
