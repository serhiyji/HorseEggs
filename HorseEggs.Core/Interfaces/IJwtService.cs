using HorseEggs.Core.DTOs.Token;
using HorseEggs.Core.Entities.Token;
using HorseEggs.Core.Entities;
using HorseEggs.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HorseEggs.Core.Services.JwtService;
using HorseEggs.Core.Responses;

namespace HorseEggs.Core.Interfaces
{
    public interface IJwtService
    {
        Task Create(RefreshToken token);
        Task Delete(RefreshToken token);
        Task Update(RefreshToken token);
        Task<RefreshToken?> Get(string token);
        Task<IEnumerable<RefreshToken>> GetAll();
        Task<Tokens> GenerateJwtTokensAsync(AppUser user);
        Task<ServiceResponse> VerifyTokenAsync(TokenRequestDto tokenRequest);
        Task<IEnumerable<RefreshToken>> GetByUserIdAsync(string userId);
    }
}
