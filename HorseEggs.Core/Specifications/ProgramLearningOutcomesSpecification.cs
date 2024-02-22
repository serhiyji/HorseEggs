using Ardalis.Specification;
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

        public class GetByPagination : Specification<ProgramLearningOutcomes>
        {
            public GetByPagination(int page, int pageSize, string userId = null)
            {
                if (string.IsNullOrEmpty(userId))
                {
                    Query.Skip((page - 1) * pageSize).Take(pageSize);
                }
                else
                {
                    Query.Where(c => c.AppUserId == userId).Skip((page - 1) * pageSize).Take(pageSize);
                }
            }
        }
    }
}
