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
    public static class StandartEducationalProgramSpecification
    {
        public class GetByPagination : Specification<StandartEducationalProgram>
        {
            public GetByPagination(int page, int pageSize)
            {
                Query.Skip((page - 1) * pageSize).Take(pageSize);
            }
        }
    }
}
