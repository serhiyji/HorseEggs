using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class Specialty : IEntity // Спеціальність
    {
        public int Id { get; set; }
        [Required, MaxLength(16)]
        public string Code {  get; set; }
        [Required, MaxLength(256)]
        public string Name { get; set; }
        public IEnumerable<StandartEducationalProgram> StandartEducationalPrograms { get; set;}
    }
}
