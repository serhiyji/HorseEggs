using HorseEggs.Core.DTOs.Competence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.Services;

namespace HorseEggs.Core.Interfaces
{
    public interface ICompetenceService
    {
        Task Create(CreateCompetenceDto competenceDto);
        Task Update(UpdateCompetenceDto competenceDto);
        Task Delete(int id);
        Task<ServiceResponse<List<CompetenceDto>, object>> GetAll();
        Task<List<CompetenceDto>> GetByUserId(string UserId);
        Task<CompetenceDto?> Get(int id);
    }
}
