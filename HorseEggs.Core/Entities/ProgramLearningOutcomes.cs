using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public enum ProgramLearningOutcomesType { Ministry = 1, University = 2 }
    public class ProgramLearningOutcomes : IEntity // – Програмні результати навчання
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProgramLearningOutcomesType ProgramLearningOutcomesType { get; set; }
        public IEnumerable<EducationalComponent_ProgramLearningOutcomes_EP> EducationalComponent_ProgramLearningOutcomes_EPs { get; set; }
        public IEnumerable<ProgramLearningOutcomes_SEP> ProgramLearningOutcomes_SEPs { get; set; }
        public IEnumerable<ProgramLearningOutcomes_EP> ProgramLearningOutcomes_EPs { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
