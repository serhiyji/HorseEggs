using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class AppUser : IdentityUser
    {
        public IEnumerable<ProgramLearningOutcomes> ProgramLearningOutcomes { get; set;}
        public IEnumerable<Competence> Competences { get; set;}
        public IEnumerable<EducationalProgram> EducationalPrograms { get; set;}
    }
}
