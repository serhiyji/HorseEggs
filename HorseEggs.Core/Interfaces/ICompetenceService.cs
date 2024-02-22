using HorseEggs.Core.DTOs.Competence;
using HorseEggs.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Interfaces
{
    public interface ICompetenceService
    {
        Task Create(CreateCompetenceDto competenceDto);
        Task Update(UpdateCompetenceDto competenceDto);
        Task Delete(int id);
        Task<PaginationResponse<List<CompetenceDto>, object>> GetAll(int page = 1, int pageSize = 10, string userId = null);
        Task<PaginationResponse<List<CompetenceDto>, object>> GetByUserId(string UserId);
        Task<CompetenceDto?> Get(int id);
    }
}
