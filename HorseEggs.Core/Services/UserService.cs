﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using HorseEggs.Core.DTOs.Token;
using HorseEggs.Core.DTOs.User;
using HorseEggs.Core.Entities.Token;
using HorseEggs.Core.Entities;
using HorseEggs.Core.Interfaces;
using TopNewsApi.Core.Services;
using static HorseEggs.Core.Services.JwtService;

namespace HorseEggs.Core.Services
{
    public class UserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly EmailService _emailService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IJwtService _jwtService;

        public UserService(
                UserManager<AppUser> userManager, 
                SignInManager<AppUser> signInManager, 
                RoleManager<IdentityRole> roleManager, 
                EmailService emailService, 
                IMapper mapper, 
                IConfiguration configuration,
                IJwtService jwtService
            )
        {
            this._signInManager = signInManager;
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._emailService = emailService;
            this._mapper = mapper;
            this._configuration = configuration;
            this._jwtService = jwtService;
        }

        #region SignIn, SignOut
        public async Task<ServiceResponse> LoginUserAsync(UserLoginDto model)
        {
            AppUser? user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return new ServiceResponse(false, "User or password incorect.");
            }
            SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, lockoutOnFailure: true);
            if (result.Succeeded)
            {
                Tokens? tokens = await _jwtService.GenerateJwtTokensAsync(user);
                await _signInManager.SignInAsync(user, model.RememberMe);
                return new ServiceResponse(true, "User successfully loged in.", accessToken: tokens.Token, refreshToken: tokens.refreshToken.Token);
            }
            if (result.IsNotAllowed)
            {
                return new ServiceResponse(false, "Confirm your email please");
            }
            if (result.IsLockedOut)
            {
                return new ServiceResponse(false, "Useris locked. Connect with your site admistrator.");
            }
            return new ServiceResponse(false, "User or password incorect");
        }
        public async Task<ServiceResponse> SignOutAsync()
        {
            await _signInManager.SignOutAsync();
            return new ServiceResponse(true);
        }
        #endregion
    }
}
