using FluentValidation;
using HorseEggs.Core.DTOs.StandartEducationalProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Validation.StandartEducationalProgram
{
    public class CreateStandartEducationalProgramValidation : AbstractValidator<CreateStandartEducationalProgramDto>
    {
        public CreateStandartEducationalProgramValidation()
        {
            RuleFor(s => s.Year).NotEmpty();
            RuleFor(s => s.Name).NotEmpty().MinimumLength(1).MaximumLength(256);
            RuleFor(s => s.SpecialtyId).NotEmpty();
        }
    }
}
