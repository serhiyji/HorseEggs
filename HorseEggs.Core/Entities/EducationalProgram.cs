using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public enum EducationalProgramType { Ministry = 1, University = 2 };
    public class EducationalProgram : IEntity // Освітня рограма
    {
        public int Id { get; set; }
        public int Year {  get; set; }
        public string Name { get; set; }
        public EducationalProgramType EducationalProgramType { get; set; }
        public int SpecialtyId {  get; set; }
        public Specialty Specialty { get; set; }
        public IEnumerable<Discipline_Competences_EP> Discipline_Competences_EPs { get; set; }
        public IEnumerable<Discipline_ProgramLearningOutcomes_EP> Discipline_ProgramLearningOutcomes_EPs { get; set; }
    }
}
