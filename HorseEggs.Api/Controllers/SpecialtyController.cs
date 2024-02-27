using HorseEggs.Core.DTOs.Competence;
using HorseEggs.Core.DTOs.Specialty;
using HorseEggs.Core.Interfaces;
using HorseEggs.Core.Validation.Competence;
using HorseEggs.Core.Validation.Specialty;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HorseEggs.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialtyController : Controller
    {
        private readonly ISpecialtyService _specialtyService;
        public SpecialtyController(ISpecialtyService specialtyService)
        {
            _specialtyService = specialtyService;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll(int page, int pageSize)
        {
            return Ok(await _specialtyService.GetAll(page, pageSize));
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _specialtyService.Get(id));
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateSpecialtyDto model)
        {
            CreateSpecialtyValidation validator = new CreateSpecialtyValidation();
            var validationResult = await validator.ValidateAsync(model);
            if (validationResult.IsValid)
            {
                await _specialtyService.Create(model);
                return Ok(validationResult);
            }
            return BadRequest(validationResult.Errors);
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] UpdateSpecialtyDto model)
        {
            UpdateSpecialtyValidation validator = new UpdateSpecialtyValidation();
            var validationResult = await validator.ValidateAsync(model);
            if (validationResult.IsValid)
            {
                await _specialtyService.Update(model);
                return Ok(validationResult);
            }
            return BadRequest(validationResult.Errors);
        }
        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            await _specialtyService.Delete(id);
            return Ok();
        }
    }
}
