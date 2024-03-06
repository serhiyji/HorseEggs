using FluentValidation;
using HorseEggs.Core.DTOs.StandartEducationalProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Validation.StandartEducationalProgram
{
    public class UpdateStandartEducationalProgramValidation : AbstractValidator<UpdateStandartEducationalProgramDto>
    {
        public UpdateStandartEducationalProgramValidation()
        {
            RuleFor(s => s.Year).NotEmpty();
            RuleFor(s => s.Name).NotEmpty().MinimumLength(1).MaximumLength(256);
            RuleFor(s => s.Specialty).NotEmpty().MinimumLength(1).MaximumLength(16);
            RuleFor(s => s.SpecialtyName).NotEmpty().MinimumLength(1).MaximumLength(256);
        }
    }
}
