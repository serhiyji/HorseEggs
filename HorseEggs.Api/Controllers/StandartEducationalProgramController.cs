using HorseEggs.Core.DTOs.StandartEducationalProgram;
using HorseEggs.Core.Interfaces;
using HorseEggs.Core.Validation.StandartEducationalProgram;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HorseEggs.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class StandartEducationalProgramController : Controller
    {
        private readonly IStandartEducationalProgramService _standartEducationalProgramService;
        public StandartEducationalProgramController(IStandartEducationalProgramService specialtyService)
        {
            _standartEducationalProgramService = specialtyService;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll(int page, int pageSize)
        {
            return Ok(await _standartEducationalProgramService.GetAll(page, pageSize));
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _standartEducationalProgramService.Get(id));
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateStandartEducationalProgramDto model)
        {
            CreateStandartEducationalProgramValidation validator = new CreateStandartEducationalProgramValidation();
            var validationResult = await validator.ValidateAsync(model);
            if (validationResult.IsValid)
            {
                await _standartEducationalProgramService.Create(model);
                return Ok(validationResult);
            }
            return BadRequest(validationResult.Errors);
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] UpdateStandartEducationalProgramDto model)
        {
            UpdateStandartEducationalProgramValidation validator = new UpdateStandartEducationalProgramValidation();
            var validationResult = await validator.ValidateAsync(model);
            if (validationResult.IsValid)
            {
                await _standartEducationalProgramService.Update(model);
                return Ok(validationResult);
            }
            return BadRequest(validationResult.Errors);
        }
        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            await _standartEducationalProgramService.Delete(id);
            return Ok();
        }
    }
}
