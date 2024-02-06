using HorseEggs.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Infrastructure.Context
{
    internal class AppDBContext : IdentityDbContext
    {
        public AppDBContext() : base() { }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<AppUser> AppUser { get; set; }

        public DbSet<Competence> Competence { get; set; }
        public DbSet<Competences_SEP> Competences_SEPs { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Discipline_Competences_EP> Discipline_Competences_EPs { get; set; }
        public DbSet<Discipline_ProgramLearningOutcomes_EP> Discipline_ProgramLearningOutcomes_EPs { get; set; }
        public DbSet<EducationalProgram> EducationalPrograms { get; set; }
        public DbSet<ProgramLearningOutcomes> ProgramLearningOutcomes { get; set; }
        public DbSet<ProgramLearningOutcomes_SEP> ProgramLearningOutcomes_SEPs { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<StandartEducationalProgram> StandartEducationalPrograms { get; set; }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
