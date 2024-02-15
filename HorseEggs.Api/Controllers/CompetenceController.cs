using HorseEggs.Core.DTOs.Competence;
using HorseEggs.Core.Interfaces;
using HorseEggs.Core.Validation.Competence;
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
        [HttpGet("getbyuserid")]
        public async Task<IActionResult> GetByUserId(string userid)
        {
            return Ok(await _competenceService.GetByUserId(userid));
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _competenceService.Get(id));
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateCompetenceDto model)
        {
            CreateCompetenceValidation validator = new CreateCompetenceValidation();
            var validationResult = await validator.ValidateAsync(model);
            if (validationResult.IsValid)
            {
                await _competenceService.Create(model);
                return Ok(validationResult);
            }
            return BadRequest(validationResult.Errors);
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(UpdateCompetenceDto model)
        {
            UpdateCompetenceValidation validator = new UpdateCompetenceValidation();
            var validationResult = await validator.ValidateAsync(model);
            if (validationResult.IsValid)
            {
                await _competenceService.Update(model);
                return Ok(validationResult);
            }
            return BadRequest(validationResult.Errors);
        }
        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody]int id)
        {
            await _competenceService.Delete(id);
            return Ok();
        }
    }
}
