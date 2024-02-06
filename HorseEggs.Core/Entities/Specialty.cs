using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class Specialty : IEntity // Освітня компонента
    {
        public int Id { get; set; }
        public string Code {  get; set; }
        public string Name { get; set; }
        public IEnumerable<Competence> Competences { get; set; }
        public IEnumerable<EducationalProgram> EducationalPrograms { get; set;}
        public IEnumerable<ProgramLearningOutcomes> ProgramLearningOutcomess { get; set;}
        public IEnumerable<StandartEducationalProgram> StandartEducationalPrograms { get; set;}
    }
}
