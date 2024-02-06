using HorseEggs.Core.Entities;
using HorseEggs.Core.Entities.Token;
using HorseEggs.Infrastructure.Initializers;
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
        public DbSet<RefreshToken> RefreshTokens { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>()
                .HasMany(user => user.Competences)
                .WithOne(competences => competences.AppUser)
                .HasForeignKey(competences => competences.AppUserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AppUser>()
                .HasMany(user => user.EducationalPrograms)
                .WithOne(educational_programs => educational_programs.AppUser)
                .HasForeignKey(educational_programs => educational_programs.AppUserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AppUser>()
                .HasMany(user => user.ProgramLearningOutcomes)
                .WithOne(program_learning_outcomes => program_learning_outcomes.AppUser)
                .HasForeignKey(program_learning_outcomes => program_learning_outcomes.AppUserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EducationalProgram>()
                .HasOne(educational_program => educational_program.Specialty)
                .WithMany(specialty => specialty.EducationalPrograms)
                .HasForeignKey(educational_program => educational_program.SpecialtyId);

            modelBuilder.Entity<Competence>()
                .HasOne(competences => competences.Specialty)
                .WithMany(specialty => specialty.Competences)
                .HasForeignKey(competences => competences.SpecialtyId);

            modelBuilder.Entity<ProgramLearningOutcomes>()
                .HasOne(program_learning_outcomes => program_learning_outcomes.Specialty)
                .WithMany(specialty => specialty.ProgramLearningOutcomess)
                .HasForeignKey(program_learning_outcomes => program_learning_outcomes.SpecialtyId);

            modelBuilder.Entity<StandartEducationalProgram>()
                .HasOne(standart_educational_program => standart_educational_program.Specialty)
                .WithMany(specialty => specialty.StandartEducationalPrograms)
                .HasForeignKey(standart_educational_program => standart_educational_program.SpecialtyId);

            modelBuilder.Entity<Competences_SEP>()
                .HasOne(competences_sep => competences_sep.StandartEducationalProgram)
                .WithMany(standart_educational_program => standart_educational_program.Competences_SEPs)
                .HasForeignKey(competences_sep => competences_sep.StandartEducationalProgramId);

            modelBuilder.Entity<Competences_SEP>()
                .HasOne(competences_sep => competences_sep.Competence)
                .WithMany(competences => competences.Competences_SEPs)
                .HasForeignKey(competences_sep => competences_sep.CompetenceId);

            modelBuilder.Entity<ProgramLearningOutcomes_SEP>()
                .HasOne(program_learning_outcomes_sep => program_learning_outcomes_sep.StandartEducationalProgram)
                .WithMany(standart_educational_program => standart_educational_program.ProgramLearningOutcomes_SEPs)
                .HasForeignKey(program_learning_outcomes_sep => program_learning_outcomes_sep.StandartEducationalProgramId);

            modelBuilder.Entity<ProgramLearningOutcomes_SEP>()
                .HasOne(program_learning_outcomes_sep => program_learning_outcomes_sep.ProgramLearningOutcomes)
                .WithMany(program_learning_outcomes => program_learning_outcomes.ProgramLearningOutcomes_SEPs)
                .HasForeignKey(program_learning_outcomes_sep => program_learning_outcomes_sep.ProgramLearningOutcomesId);

            modelBuilder.Entity<Discipline_Competences_EP>()
                .HasOne(discipline_competences_ep => discipline_competences_ep.Discipline)
                .WithMany(discipline => discipline.Discipline_Competences_EPs)
                .HasForeignKey(discipline_competences_ep => discipline_competences_ep.DisciplineId);

            modelBuilder.Entity<Discipline_Competences_EP>()
                .HasOne(discipline_competences_ep => discipline_competences_ep.EducationalProgram)
                .WithMany(educational_program => educational_program.Discipline_Competences_EPs)
                .HasForeignKey(discipline_competences_ep => discipline_competences_ep.EducationalProgramId);

            modelBuilder.Entity<Discipline_Competences_EP>()
                .HasOne(discipline_competences_ep => discipline_competences_ep.Competence)
                .WithMany(competences => competences.Discipline_Competences_EPs)
                .HasForeignKey(discipline_competences_ep => discipline_competences_ep.CompetenceId);


            modelBuilder.Entity<Discipline_ProgramLearningOutcomes_EP>()
                .HasOne(discipline_program_learning_outcomes_ep => discipline_program_learning_outcomes_ep.Discipline)
                .WithMany(discipline => discipline.Discipline_ProgramLearningOutcomes_EPs)
                .HasForeignKey(discipline_program_learning_outcomes_ep => discipline_program_learning_outcomes_ep.DisciplineId);

            modelBuilder.Entity<Discipline_ProgramLearningOutcomes_EP>()
                .HasOne(discipline_program_learning_outcomes_ep => discipline_program_learning_outcomes_ep.EducationalProgram)
                .WithMany(educational_program => educational_program.Discipline_ProgramLearningOutcomes_EPs)
                .HasForeignKey(discipline_program_learning_outcomes_ep => discipline_program_learning_outcomes_ep.EducationalProgramId);

            modelBuilder.Entity<Discipline_ProgramLearningOutcomes_EP>()
                .HasOne(discipline_program_learning_outcomes_ep => discipline_program_learning_outcomes_ep.ProgramLearningOutcomes)
                .WithMany(program_learning_outcomes => program_learning_outcomes.Discipline_ProgramLearningOutcomes_EPs)
                .HasForeignKey(discipline_program_learning_outcomes_ep => discipline_program_learning_outcomes_ep.ProgramLearningOutcomesId);

            modelBuilder.SeedMinistry();
        }
    }
}
