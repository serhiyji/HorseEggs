using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public enum EducationalComponentType { Standart = 1, ForEducationalProgram = 2 };
    public class EducationalComponent : IEntity // Освітня компонента
    {
        public int Id { get; set; }
        public string Code {  get; set; }
        public string Name { get; set; }
        public IEnumerable<EducationalComponent_Competences_EP> EducationalComponent_Competences_EPs { get; set; }
        public IEnumerable<EducationalComponent_ProgramLearningOutcomes_EP> EducationalComponent_ProgramLearningOutcomes_EPs { get; set; }
        public IEnumerable<EducationalComponent_EducationalProgram> EducationalComponent_EducationalPrograms { get; set; }
    }
}
