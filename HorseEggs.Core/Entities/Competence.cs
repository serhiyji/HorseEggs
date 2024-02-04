using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public enum CompetenceType { MinistryStandard = 1, MinistrySpecialty = 2, UniversityStandard = 3, UniversitySpecialty = 4 };
    public class Competence : IEntity // Компетентність
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Year {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CompetenceType CompetenceType {  get; set; }
        public int? SpecialtyId { get; set; }
        public Specialty? Specialty { get; set; }
        public IEnumerable<EducationalProgramComponent> EducationalProgramComponents { get; set; }
    }
}
