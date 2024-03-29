﻿using FluentValidation;
using HorseEggs.Core.DTOs.ProgramLearningOutcomes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Validation.ProgramLearningOutcomes
{
    public class CreateProgramLearningOutcomesValidation : AbstractValidator<CreateProgramLearningOutcomesDto>
    {
        public CreateProgramLearningOutcomesValidation()
        {
            RuleFor(c => c.Code).NotEmpty().MaximumLength(16);
            RuleFor(c => c.Name).NotEmpty().MinimumLength(1).MaximumLength(256);
            RuleFor(c => c.Description).NotEmpty().MaximumLength(1024);
            RuleFor(c => c.AppUserId).NotEmpty();
        }
    }
}
