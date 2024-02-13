using FluentValidation;
using HorseEggs.Core.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Validation.User
{
    public class RegistrationUniversityValidation : AbstractValidator<RegistrationUniversityDto>
    {
        public RegistrationUniversityValidation()
        {
            RuleFor(r => r.Email).NotEmpty().EmailAddress();
            RuleFor(r => r.Password).NotEmpty().MinimumLength(6);
            RuleFor(r => r.ConfirmPassword).NotEmpty().MinimumLength(6).Equal(p => p.Password);
        }
    }
}
