﻿using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class EducationalComponent : IEntity // Освітня компонента
    {
        public int Id { get; set; }
        [Required, MaxLength(16)]
        public string Code {  get; set; }
        [Required, MaxLength(256)]
        public string Name { get; set; }
        public IEnumerable<EducationalComponent_Competences_EP> EducationalComponent_Competences_EPs { get; set; }
        public IEnumerable<EducationalComponent_ProgramLearningOutcomes_EP> EducationalComponent_ProgramLearningOutcomes_EPs { get; set; }
        public IEnumerable<EducationalComponent_EducationalProgram> EducationalComponent_EducationalPrograms { get; set; }
    }
}
