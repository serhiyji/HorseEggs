using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class EducationalProgram : IEntity // Освітня рограма
    {
        public int Id { get; set; }
        public int Year {  get; set; }
        public string Name { get; set; }
        public IEnumerable<EducationalComponent_Competences_EP> EducationalComponent_Competences_EPs { get; set; }
        public IEnumerable<EducationalComponent_ProgramLearningOutcomes_EP> EducationalComponent_ProgramLearningOutcomes_EPs { get; set; }
        public IEnumerable<Competence_EP> Competence_EPs { get; set; }
        public IEnumerable<ProgramLearningOutcomes_EP> ProgramLearningOutcomes_EPs { get; set; }
        public IEnumerable<EducationalComponent_EducationalProgram> EducationalComponent_EducationalPrograms { get; set; }
        public int StandartEducationalProgramId {  get; set; }
        public StandartEducationalProgram StandartEducationalProgram { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
