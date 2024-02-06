using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public enum PassType { Exam = 1, Test = 2 }; // Екзамен , Залік
    public class Discipline : IEntity // Дисципліна
    {
        public int Id { get; set; }
        public string Code {  get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public PassType PassType { get; set; }
        public IEnumerable<Discipline_Competences_EP> Discipline_Competences_EPs { get; set; }
        public IEnumerable<Discipline_ProgramLearningOutcomes_EP> Discipline_ProgramLearningOutcomes_EPs { get; set; }
    }
}
