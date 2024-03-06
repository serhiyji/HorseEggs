using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class StandartEducationalProgram : IEntity // Стандарт міністерства
    {
        public int Id { get; set; }
        [Required]
        public int Year { get; set; }
        [Required, MaxLength(256)]
        public string Name { get; set; }
        [Required, MaxLength(16)]
        public string Code { get; set; }
        public IEnumerable<Competences_SEP> Competences_SEPs { get; set; }
        public IEnumerable<ProgramLearningOutcomes_SEP> ProgramLearningOutcomes_SEPs { get; set; }
        public IEnumerable<EducationalProgram> EducationalPrograms { get; set; }
    }
}
