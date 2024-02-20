using HorseEggs.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Entities
{
    public class Competence : IEntity // Компетентність
    {
        public int Id { get; set; }
        [Required, MaxLength(16)]
        public string Code { get; set; }
        [Required, MaxLength(256)]
        public string Name { get; set; }
        [Required, MaxLength(1024)]
        public string Description { get; set; }
        public IEnumerable<EducationalComponent_Competences_EP> EducationalComponent_Competences_EPs { get; set; }
        public IEnumerable<Competences_SEP> Competences_SEPs { get; set; }
        public IEnumerable<Competence_EP> Competence_EPs { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
