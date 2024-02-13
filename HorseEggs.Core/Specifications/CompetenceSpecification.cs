using Ardalis.Specification;
using HorseEggs.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Specifications
{
    public static class CompetenceSpecification
    {
        public class GetByUserId : Specification<Competence>
        {
            public GetByUserId(string UserId)
            {
                Query.Where(c => c.AppUserId == UserId);
            }
        }
    }
}
