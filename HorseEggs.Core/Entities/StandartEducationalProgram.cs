﻿using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class StandartEducationalProgram : IEntity // Стандарт міністерства
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
        public IEnumerable<Competences_SEP> Competences_SEPs { get; set; }
        public IEnumerable<ProgramLearningOutcomes_SEP> ProgramLearningOutcomes_SEPs { get; set; }

    }
}