using FluentValidation;
using HorseEggs.Core.DTOs.Competence;
using HorseEggs.Core.DTOs.ProgramLearningOutcomes;
using HorseEggs.Core.Interfaces;
using HorseEggs.Core.Validation.Competence;
using HorseEggs.Core.Validation.ProgramLearningOutcomes;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HorseEggs.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramLearningOutcomesController : Controller
    {
        private readonly IProgramLearningOutcomesService _programLearningOutcomesService;
        public ProgramLearningOutcomesController(IProgramLearningOutcomesService programLearningOutcomesService)
        {
            _programLearningOutcomesService = programLearningOutcomesService;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _programLearningOutcomesService.GetAll());
        }
        [HttpGet("getbyuserid")]
        public async Task<IActionResult> GetByUserId(string userid)
        {
            return Ok(await _programLearningOutcomesService.GetByUserId(userid));
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _programLearningOutcomesService.Get(id));
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateProgramLearningOutcomesDto model)
        {
            CreateProgramLearningOutcomesValidation validator = new CreateProgramLearningOutcomesValidation();
            var validationResult = await validator.ValidateAsync(model);
            if (validationResult.IsValid)
            {
                await _programLearningOutcomesService.Create(model);
                return Ok(validationResult);
            }
            return BadRequest(validationResult.Errors);
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] UpdateProgramLearningOutcomesDto model)
        {
            UpdateProgramLearningOutcomesValidation validator = new UpdateProgramLearningOutcomesValidation();
            var validationResult = await validator.ValidateAsync(model);
            if (validationResult.IsValid)
            {
                await _programLearningOutcomesService.Update(model);
                return Ok(validationResult);
            }
            return BadRequest(validationResult.Errors);
        }
        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            await _programLearningOutcomesService.Delete(id);
            return Ok();
        }
    }
}
