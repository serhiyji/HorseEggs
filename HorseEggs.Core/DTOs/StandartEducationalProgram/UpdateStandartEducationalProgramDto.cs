using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.DTOs.StandartEducationalProgram
{
    public class UpdateStandartEducationalProgramDto
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
