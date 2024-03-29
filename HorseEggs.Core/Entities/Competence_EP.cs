﻿using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class Competence_EP : IEntity
    {
        public int Id { get; set; }
        public int CompetenceId { get; set; }
        public Competence Competence { get; set; }
        public int EducationalProgramId {  get; set; }
        public EducationalProgram EducationalProgram { get; set; }
    }
}
