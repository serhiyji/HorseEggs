﻿// <auto-generated />
using System;
using HorseEggs.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HorseEggs.Infrastructure.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240208124240_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HorseEggs.Core.Entities.Competence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompetenceType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Competence");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.Competence_EP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompetenceId")
                        .HasColumnType("int");

                    b.Property<int>("EducationalProgramId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetenceId");

                    b.HasIndex("EducationalProgramId");

                    b.ToTable("Competence_EP");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.Competences_SEP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompetenceId")
                        .HasColumnType("int");

                    b.Property<int>("StandartEducationalProgramId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetenceId");

                    b.HasIndex("StandartEducationalProgramId");

                    b.ToTable("Competences_SEPs");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.EducationalComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EducationalComponents");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.EducationalComponent_Competences_EP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompetenceId")
                        .HasColumnType("int");

                    b.Property<int>("EducationalComponentId")
                        .HasColumnType("int");

                    b.Property<int>("EducationalProgramId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetenceId");

                    b.HasIndex("EducationalComponentId");

                    b.HasIndex("EducationalProgramId");

                    b.ToTable("EducationalComponent_Competences_EPs");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.EducationalComponent_ProgramLearningOutcomes_EP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EducationalComponentId")
                        .HasColumnType("int");

                    b.Property<int>("EducationalProgramId")
                        .HasColumnType("int");

                    b.Property<int>("ProgramLearningOutcomesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EducationalComponentId");

                    b.HasIndex("EducationalProgramId");

                    b.HasIndex("ProgramLearningOutcomesId");

                    b.ToTable("EducationalComponent_ProgramLearningOutcomes_EPs");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.EducationalProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EducationalProgramType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StandartEducationalProgramId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("StandartEducationalProgramId");

                    b.ToTable("EducationalPrograms");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.ProgramLearningOutcomes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgramLearningOutcomesType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("ProgramLearningOutcomes");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.ProgramLearningOutcomes_EP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EducationalProgramId")
                        .HasColumnType("int");

                    b.Property<int>("ProgramLearningOutcomesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EducationalProgramId");

                    b.HasIndex("ProgramLearningOutcomesId");

                    b.ToTable("ProgramLearningOutcomes_EP");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.ProgramLearningOutcomes_SEP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProgramLearningOutcomesId")
                        .HasColumnType("int");

                    b.Property<int>("StandartEducationalProgramId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgramLearningOutcomesId");

                    b.HasIndex("StandartEducationalProgramId");

                    b.ToTable("ProgramLearningOutcomes_SEPs");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.Specialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.StandartEducationalProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("StandartEducationalPrograms");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.Token.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<string>("JwtId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8ebdf7dd-87da-4cc7-80c5-97013734044f",
                            Name = "Ministry",
                            NormalizedName = "MINISTRY"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "e47dc735-351f-4bfc-a57a-77fd5bf25969",
                            RoleId = "8ebdf7dd-87da-4cc7-80c5-97013734044f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "e47dc735-351f-4bfc-a57a-77fd5bf25969",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "18145191-0f06-4f11-a59e-16d96bc95d8b",
                            Email = "admin@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EMAIL.COM",
                            NormalizedUserName = "ADMIN@EMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHAXjqtxVt9fn4n4TilbVksWWI18P8TZHl7BjSv63m7on9P03QoU8ggDYear4EgIHA==",
                            PhoneNumber = "+xx(xxx)xxx-xx-xx",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "e45614d2-b693-45f9-8567-24c3eea3cb93",
                            TwoFactorEnabled = false,
                            UserName = "admin@email.com",
                            FirstName = "John",
                            LastName = "Connor",
                            SurName = "Johnovych"
                        });
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.Competence", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.AppUser", "AppUser")
                        .WithMany("Competences")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.Competence_EP", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.Competence", "Competence")
                        .WithMany("Competence_EPs")
                        .HasForeignKey("CompetenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HorseEggs.Core.Entities.EducationalProgram", "EducationalProgram")
                        .WithMany("Competence_EPs")
                        .HasForeignKey("EducationalProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competence");

                    b.Navigation("EducationalProgram");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.Competences_SEP", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.Competence", "Competence")
                        .WithMany("Competences_SEPs")
                        .HasForeignKey("CompetenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HorseEggs.Core.Entities.StandartEducationalProgram", "StandartEducationalProgram")
                        .WithMany("Competences_SEPs")
                        .HasForeignKey("StandartEducationalProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competence");

                    b.Navigation("StandartEducationalProgram");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.EducationalComponent_Competences_EP", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.Competence", "Competence")
                        .WithMany("EducationalComponent_Competences_EPs")
                        .HasForeignKey("CompetenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HorseEggs.Core.Entities.EducationalComponent", "EducationalComponent")
                        .WithMany("EducationalComponent_Competences_EPs")
                        .HasForeignKey("EducationalComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HorseEggs.Core.Entities.EducationalProgram", "EducationalProgram")
                        .WithMany("EducationalComponent_Competences_EPs")
                        .HasForeignKey("EducationalProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competence");

                    b.Navigation("EducationalComponent");

                    b.Navigation("EducationalProgram");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.EducationalComponent_ProgramLearningOutcomes_EP", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.EducationalComponent", "EducationalComponent")
                        .WithMany("EducationalComponent_ProgramLearningOutcomes_EPs")
                        .HasForeignKey("EducationalComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HorseEggs.Core.Entities.EducationalProgram", "EducationalProgram")
                        .WithMany("EducationalComponent_ProgramLearningOutcomes_EPs")
                        .HasForeignKey("EducationalProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HorseEggs.Core.Entities.ProgramLearningOutcomes", "ProgramLearningOutcomes")
                        .WithMany("EducationalComponent_ProgramLearningOutcomes_EPs")
                        .HasForeignKey("ProgramLearningOutcomesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationalComponent");

                    b.Navigation("EducationalProgram");

                    b.Navigation("ProgramLearningOutcomes");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.EducationalProgram", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.AppUser", "AppUser")
                        .WithMany("EducationalPrograms")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HorseEggs.Core.Entities.StandartEducationalProgram", "StandartEducationalProgram")
                        .WithMany("EducationalPrograms")
                        .HasForeignKey("StandartEducationalProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("StandartEducationalProgram");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.ProgramLearningOutcomes", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.AppUser", "AppUser")
                        .WithMany("ProgramLearningOutcomes")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.ProgramLearningOutcomes_EP", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.EducationalProgram", "EducationalProgram")
                        .WithMany("ProgramLearningOutcomes_EPs")
                        .HasForeignKey("EducationalProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HorseEggs.Core.Entities.ProgramLearningOutcomes", "ProgramLearningOutcomes")
                        .WithMany("ProgramLearningOutcomes_EPs")
                        .HasForeignKey("ProgramLearningOutcomesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationalProgram");

                    b.Navigation("ProgramLearningOutcomes");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.ProgramLearningOutcomes_SEP", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.ProgramLearningOutcomes", "ProgramLearningOutcomes")
                        .WithMany("ProgramLearningOutcomes_SEPs")
                        .HasForeignKey("ProgramLearningOutcomesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HorseEggs.Core.Entities.StandartEducationalProgram", "StandartEducationalProgram")
                        .WithMany("ProgramLearningOutcomes_SEPs")
                        .HasForeignKey("StandartEducationalProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProgramLearningOutcomes");

                    b.Navigation("StandartEducationalProgram");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.StandartEducationalProgram", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.Specialty", "Specialty")
                        .WithMany("StandartEducationalPrograms")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialty");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.Token.RefreshToken", b =>
                {
                    b.HasOne("HorseEggs.Core.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.Competence", b =>
                {
                    b.Navigation("Competence_EPs");

                    b.Navigation("Competences_SEPs");

                    b.Navigation("EducationalComponent_Competences_EPs");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.EducationalComponent", b =>
                {
                    b.Navigation("EducationalComponent_Competences_EPs");

                    b.Navigation("EducationalComponent_ProgramLearningOutcomes_EPs");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.EducationalProgram", b =>
                {
                    b.Navigation("Competence_EPs");

                    b.Navigation("EducationalComponent_Competences_EPs");

                    b.Navigation("EducationalComponent_ProgramLearningOutcomes_EPs");

                    b.Navigation("ProgramLearningOutcomes_EPs");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.ProgramLearningOutcomes", b =>
                {
                    b.Navigation("EducationalComponent_ProgramLearningOutcomes_EPs");

                    b.Navigation("ProgramLearningOutcomes_EPs");

                    b.Navigation("ProgramLearningOutcomes_SEPs");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.Specialty", b =>
                {
                    b.Navigation("StandartEducationalPrograms");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.StandartEducationalProgram", b =>
                {
                    b.Navigation("Competences_SEPs");

                    b.Navigation("EducationalPrograms");

                    b.Navigation("ProgramLearningOutcomes_SEPs");
                });

            modelBuilder.Entity("HorseEggs.Core.Entities.AppUser", b =>
                {
                    b.Navigation("Competences");

                    b.Navigation("EducationalPrograms");

                    b.Navigation("ProgramLearningOutcomes");
                });
#pragma warning restore 612, 618
        }
    }
}