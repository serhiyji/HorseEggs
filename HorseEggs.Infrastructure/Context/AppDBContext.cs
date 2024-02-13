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
        public DbSet<EducationalComponent> EducationalComponents { get; set; }
        public DbSet<EducationalComponent_Competences_EP> EducationalComponent_Competences_EPs { get; set; }
        public DbSet<EducationalComponent_ProgramLearningOutcomes_EP> EducationalComponent_ProgramLearningOutcomes_EPs { get; set; }
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

            modelBuilder.Entity<EducationalComponent_Competences_EP>()
                .HasOne(EducationalComponent_competences_ep => EducationalComponent_competences_ep.EducationalComponent)
                .WithMany(EducationalComponent => EducationalComponent.EducationalComponent_Competences_EPs)
                .HasForeignKey(EducationalComponent_competences_ep => EducationalComponent_competences_ep.EducationalComponentId);

            modelBuilder.Entity<EducationalComponent_Competences_EP>()
                .HasOne(EducationalComponent_competences_ep => EducationalComponent_competences_ep.EducationalProgram)
                .WithMany(educational_program => educational_program.EducationalComponent_Competences_EPs)
                .HasForeignKey(EducationalComponent_competences_ep => EducationalComponent_competences_ep.EducationalProgramId);

            modelBuilder.Entity<EducationalComponent_Competences_EP>()
                .HasOne(EducationalComponent_competences_ep => EducationalComponent_competences_ep.Competence)
                .WithMany(competences => competences.EducationalComponent_Competences_EPs)
                .HasForeignKey(EducationalComponent_competences_ep => EducationalComponent_competences_ep.CompetenceId);

            modelBuilder.Entity<EducationalComponent_ProgramLearningOutcomes_EP>()
                .HasOne(EducationalComponent_program_learning_outcomes_ep => EducationalComponent_program_learning_outcomes_ep.EducationalComponent)
                .WithMany(EducationalComponent => EducationalComponent.EducationalComponent_ProgramLearningOutcomes_EPs)
                .HasForeignKey(EducationalComponent_program_learning_outcomes_ep => EducationalComponent_program_learning_outcomes_ep.EducationalComponentId);

            modelBuilder.Entity<EducationalComponent_ProgramLearningOutcomes_EP>()
                .HasOne(EducationalComponent_program_learning_outcomes_ep => EducationalComponent_program_learning_outcomes_ep.EducationalProgram)
                .WithMany(educational_program => educational_program.EducationalComponent_ProgramLearningOutcomes_EPs)
                .HasForeignKey(EducationalComponent_program_learning_outcomes_ep => EducationalComponent_program_learning_outcomes_ep.EducationalProgramId);

            modelBuilder.Entity<EducationalComponent_ProgramLearningOutcomes_EP>()
                .HasOne(EducationalComponent_program_learning_outcomes_ep => EducationalComponent_program_learning_outcomes_ep.ProgramLearningOutcomes)
                .WithMany(program_learning_outcomes => program_learning_outcomes.EducationalComponent_ProgramLearningOutcomes_EPs)
                .HasForeignKey(EducationalComponent_program_learning_outcomes_ep => EducationalComponent_program_learning_outcomes_ep.ProgramLearningOutcomesId);

            modelBuilder.Entity<EducationalProgram>()
                .HasOne(educational_program => educational_program.StandartEducationalProgram)
                .WithMany(standart_educational_program => standart_educational_program.EducationalPrograms)
                .HasForeignKey(educational_program => educational_program.StandartEducationalProgramId);

            modelBuilder.Entity<Competence_EP>()
                .HasOne(competence_ep => competence_ep.Competence)
                .WithMany(competence => competence.Competence_EPs)
                .HasForeignKey(competence_ep => competence_ep.CompetenceId);

            modelBuilder.Entity<Competence_EP>()
                .HasOne(competence_ep => competence_ep.EducationalProgram)
                .WithMany(educational_program => educational_program.Competence_EPs)
                .HasForeignKey(competence_ep => competence_ep.EducationalProgramId);

            modelBuilder.Entity<ProgramLearningOutcomes_EP>()
                .HasOne(program_learning_lutcomes_ep => program_learning_lutcomes_ep.ProgramLearningOutcomes)
                .WithMany(program_learning_outcomes => program_learning_outcomes.ProgramLearningOutcomes_EPs)
                .HasForeignKey(program_learning_lutcomes_ep => program_learning_lutcomes_ep.ProgramLearningOutcomesId);

            modelBuilder.Entity<ProgramLearningOutcomes_EP>()
                .HasOne(program_learning_lutcomes_ep => program_learning_lutcomes_ep.EducationalProgram)
                .WithMany(educational_program => educational_program.ProgramLearningOutcomes_EPs)
                .HasForeignKey(program_learning_lutcomes_ep => program_learning_lutcomes_ep.EducationalProgramId);

            modelBuilder.Entity<EducationalComponent_EducationalProgram>()
                .HasOne(educational_component_educational_program => educational_component_educational_program.EducationalComponent)
                .WithMany(educational_component => educational_component.EducationalComponent_EducationalPrograms)
                .HasForeignKey(educational_component_educational_program => educational_component_educational_program.EducationalComponentId);

            modelBuilder.Entity<EducationalComponent_EducationalProgram>()
                .HasOne(educational_component_educational_program => educational_component_educational_program.EducationalProgram)
                .WithMany(educational_program => educational_program.EducationalComponent_EducationalPrograms)
                .HasForeignKey(educational_component_educational_program => educational_component_educational_program.EducationalProgramId);

            modelBuilder.SeedMinistry();
            modelBuilder.SeedUniversity();
            modelBuilder.SeedCompetence();
        }
    }
}
