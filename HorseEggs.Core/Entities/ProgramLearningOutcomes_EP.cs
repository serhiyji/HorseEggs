using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class ProgramLearningOutcomes_EP : IEntity
    {
        public int Id { get; set; }
        public int ProgramLearningOutcomesId { get; set; }
        public ProgramLearningOutcomes ProgramLearningOutcomes { get; set; }
        public int EducationalProgramId {  get; set; }
        public EducationalProgram EducationalProgram { get; set; }
    }
}
