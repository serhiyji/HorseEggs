using HorseEggs.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Infrastructure.Initializers
{
    public static class DBInitializer
    {
        private static string MinistryUserId;
        public static void SeedMinistry(this ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            var UserId = Guid.NewGuid().ToString();
            MinistryUserId = UserId;
            var RoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = RoleId,
                Name = "Ministry",
                NormalizedName = "MINISTRY"
            });
            var adminUser = new AppUser
            {
                Id = UserId,
                UserName = "ministry@email.com",
                NormalizedUserName = "MINISTRY@EMAIL.COM",
                Email = "ministry@email.com",
                NormalizedEmail = "MINISTRY@EMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "+xx(xxx)xxx-xx-xx",
                PhoneNumberConfirmed = true,
            };
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Qwerty-1");
            modelBuilder.Entity<AppUser>().HasData(adminUser);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = RoleId,
                UserId = UserId
            });
        }
        public static void SeedUniversity(this ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            var UserId = Guid.NewGuid().ToString();
            var RoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = RoleId,
                Name = "University",
                NormalizedName = "UNIVERSITY"
            });
            var adminUser = new AppUser
            {
                Id = UserId,
                UserName = "university@email.com",
                NormalizedUserName = "UNIVERSITY@EMAIL.COM",
                Email = "university@email.com",
                NormalizedEmail = "UNIVERSITY@EMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "+xx(xxx)xxx-xx-xx",
                PhoneNumberConfirmed = true,
            };
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Qwerty-1");
            modelBuilder.Entity<AppUser>().HasData(adminUser);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = RoleId,
                UserId = UserId
            });
        }
        public static void SeedCompetence(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competence>().HasData(
                new Competence()
                {
                    Id = 1,
                    Code = "ЗК1",
                    Name = "ЗК1",
                    Description = "ЗК1",
                    AppUserId = MinistryUserId
                },
                new Competence()
                {
                    Id = 2,
                    Code = "ЗК2",
                    Name = "ЗК2",
                    Description = "ЗК2",
                    AppUserId = MinistryUserId
                },
                new Competence()
                {
                    Id = 3,
                    Code = "ЗК3",
                    Name = "ЗК3",
                    Description = "ЗК3",
                    AppUserId = MinistryUserId
                },
                new Competence()
                {
                    Id = 4,
                    Code = "ЗК4",
                    Name = "ЗК4",
                    Description = "ЗК4",
                    AppUserId = MinistryUserId
                },
                new Competence()
                {
                    Id = 5,
                    Code = "ЗК5",
                    Name = "ЗК5",
                    Description = "ЗК5",
                    AppUserId = MinistryUserId
                }
            );
        }
        public static void SeedProgramLearningOutcomes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgramLearningOutcomes>().HasData(
                new ProgramLearningOutcomes()
                {
                    Id = 1,
                    Code = "ПРН1",
                    Name = "ПРН1",
                    Description = "ПРН1",
                    AppUserId = MinistryUserId
                },
                new ProgramLearningOutcomes()
                {
                    Id = 2,
                    Code = "ПРН2",
                    Name = "ПРН2",
                    Description = "ПРН2",
                    AppUserId = MinistryUserId
                },
                new ProgramLearningOutcomes()
                {
                    Id = 3,
                    Code = "ПРН3",
                    Name = "ПРН3",
                    Description = "ПРН3",
                    AppUserId = MinistryUserId
                },
                new ProgramLearningOutcomes()
                {
                    Id = 4,
                    Code = "ПРН4",
                    Name = "ПРН4",
                    Description = "ПРН4",
                    AppUserId = MinistryUserId
                },
                new ProgramLearningOutcomes()
                {
                    Id = 5,
                    Code = "ПРН5",
                    Name = "ПРН5",
                    Description = "ПРН5",
                    AppUserId = MinistryUserId
                }
            );
        }

        public static void SeedStandartEducationalProgram(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StandartEducationalProgram>().HasData(
                new StandartEducationalProgram()
                {
                    Id = 1,
                    Year = 1,
                    Name = "Інженерія програмного забезпечення",
                    Code = "121",
                },
                new StandartEducationalProgram()
                {
                    Id = 2,
                    Year = 2,
                    Name = "Комп’ютерні науки",
                    Code = "122",
                },
                new StandartEducationalProgram()
                {
                    Id = 3,
                    Year = 3,
                    Name = "Комп’ютерна інженерія",
                    Code = "123",
                },
                new StandartEducationalProgram()
                {
                    Id = 4,
                    Year = 4,
                    Name = "Системний аналіз",
                    Code = "124",
                },
                new StandartEducationalProgram()
                {
                    Id = 5,
                    Year = 5,
                    Name = "Кібербезпека",
                    Code = "125",
                }
            );
        }
    }
}
