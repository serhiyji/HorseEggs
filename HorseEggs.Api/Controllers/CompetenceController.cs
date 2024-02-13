using HorseEggs.Core.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HorseEggs.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CompetenceController : Controller
    {
        private readonly ICompetenceService _competenceService;
        public CompetenceController(ICompetenceService competenceService)
        {
            _competenceService = competenceService;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _competenceService.GetAll());
        }
    }
}
