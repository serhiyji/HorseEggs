using FluentValidation;
using HorseEggs.Core.DTOs.Specialty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Validation.Specialty
{
    public class CreateSpecialtyValidation : AbstractValidator<CreateSpecialtyDto>
    {
        public CreateSpecialtyValidation()
        {
            RuleFor(s => s.Code).NotEmpty().MinimumLength(1).MaximumLength(16);
            RuleFor(s => s.Name).NotEmpty().MinimumLength(1).MaximumLength(256);
        }
    }
}
