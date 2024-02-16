using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.DTOs.ProgramLearningOutcomes
{
    public class UpdateProgramLearningOutcomesDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AppUserId { get; set; }
    }
}
