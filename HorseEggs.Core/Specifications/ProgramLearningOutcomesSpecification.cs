﻿using Ardalis.Specification;
using HorseEggs.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HorseEggs.Core.Specifications
{
    public class ProgramLearningOutcomesSpecification
    {
        public class GetByUserId : Specification<ProgramLearningOutcomes>
        {
            public GetByUserId(string UserId)
            {
                Query.Where(c => c.AppUserId == UserId);
            }
        }
    }
}
