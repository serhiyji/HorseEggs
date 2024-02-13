﻿using HorseEggs.Core.AutoMapper.Competence;
using HorseEggs.Core.AutoMapper.User;
using HorseEggs.Core.Interfaces;
using HorseEggs.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core
{
    public static class ServiceExtensions
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient<UserService>();
            services.AddTransient<EmailService>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<ICompetenceService, CompetenceService>();
        }

        public static void AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperUserProfile));
            services.AddAutoMapper(typeof(AutoMapperCompetenceProfile));
        }
    }
}
