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

        public class GetByPagination : Specification<Competence>
        {
            public GetByPagination(int page, int pageSize, string userId)
            {
                if(string.IsNullOrEmpty(userId))
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
