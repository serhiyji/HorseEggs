using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class ProgramLearningOutcomes : IEntity // – Програмні результати навчання
    {
        public int Id { get; set; }
        [Required, MaxLength(16)]
        public string Code { get; set; }
        [Required, MaxLength(256)]
        public string Name { get; set; }
        [Required, MaxLength(1024)]
        public string Description { get; set; }
        public IEnumerable<EducationalComponent_ProgramLearningOutcomes_EP> EducationalComponent_ProgramLearningOutcomes_EPs { get; set; }
        public IEnumerable<ProgramLearningOutcomes_SEP> ProgramLearningOutcomes_SEPs { get; set; }
        public IEnumerable<ProgramLearningOutcomes_EP> ProgramLearningOutcomes_EPs { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
