using HorseEggs.Core.DTOs.User;
using HorseEggs.Core.Services;
using HorseEggs.Core.Validation.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopNewsApi.Core.Services;

namespace HorseEggs.Api.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly UserService _userService;
        public AuthController(UserService userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] UserLoginDto model)
        {
            var validationResult = await new LoginUserValidation().ValidateAsync(model);
            if (validationResult.IsValid)
            {
                ServiceResponse response = await _userService.LoginUserAsync(model);
                return Ok(response);
            }
            return BadRequest(validationResult.Errors.FirstOrDefault());
        }
        [AllowAnonymous]
        [HttpPost("registrationuniversity")]
        public async Task<IActionResult> RegistrationUniversity(RegistrationUniversityDto model)
        {
            RegistrationUniversityValidation validaor = new RegistrationUniversityValidation();
            var validationResult = await validaor.ValidateAsync(model);
            if (validationResult.IsValid)
            {
                ServiceResponse response = await _userService.RegistrationUniversity(model);
                if (response.Success)
                {
                    return Ok(response.Message);
                }
                return Ok(response.Errors.FirstOrDefault());
            }
            return Ok(validationResult.Errors.FirstOrDefault());
        }
    }
}
