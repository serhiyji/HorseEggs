using FluentValidation;
using HorseEggs.Core.DTOs.Competence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Validation.Competence
{
    public class CreateCompetenceValidation : AbstractValidator<CreateCompetenceDto>
    {
        public CreateCompetenceValidation()
        {
            RuleFor(c => c.Code).NotEmpty();
            RuleFor(c => c.Name).NotEmpty().MinimumLength(10).MaximumLength(256);
            RuleFor(c => c.Description).NotEmpty().MaximumLength(1024);
            RuleFor(c => c.AppUserId).NotEmpty();
        }
    }
}
