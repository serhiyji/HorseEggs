using Ardalis.Specification;
using HorseEggs.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Specifications
{
    public class SpecialtySpecification
    {
        public class GetByPagination : Specification<Specialty>
        {
            public GetByPagination(int page, int pageSize)
            {
                Query.Skip((page - 1) * pageSize).Take(pageSize);
            }
        }
    }
}
