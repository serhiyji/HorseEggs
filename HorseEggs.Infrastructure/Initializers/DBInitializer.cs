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
        public static void SeedMinistry(this ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            var UserId = Guid.NewGuid().ToString();
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
    }
}
