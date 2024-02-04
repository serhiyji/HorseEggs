using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class EducationalProgram : IEntity
    {
        public int Id { get; set; }
        public int Year {  get; set; }
        public string Name { get; set; }
        public int SpecialtyId {  get; set; }
        public Specialty Specialty { get; set; }
        public IEnumerable<EducationalProgramComponent> EducationalProgramComponents { get; set; }
    }
}
