using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public enum CompetenceType { Ministry = 1, University = 2};
    public class Competence : IEntity // Компетентність
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CompetenceType CompetenceType {  get; set; }
        public int? SpecialtyId { get; set; }
        public Specialty? Specialty { get; set; }
        public IEnumerable<Discipline_Competences_EP> Discipline_Competences_EPs { get; set; }
        public IEnumerable<Competences_SEP> Competences_SEPs { get; set; }
    }
}
