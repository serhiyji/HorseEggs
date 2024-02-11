﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HorseEggs.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationalComponents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationalComponentType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalComponents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompetenceType = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competence_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgramLearningOutcomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramLearningOutcomesType = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramLearningOutcomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramLearningOutcomes_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JwtId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsRevoked = table.Column<bool>(type: "bit", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StandartEducationalPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialtyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandartEducationalPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StandartEducationalPrograms_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competences_SEPs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetenceId = table.Column<int>(type: "int", nullable: false),
                    StandartEducationalProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competences_SEPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competences_SEPs_Competence_CompetenceId",
                        column: x => x.CompetenceId,
                        principalTable: "Competence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Competences_SEPs_StandartEducationalPrograms_StandartEducationalProgramId",
                        column: x => x.StandartEducationalProgramId,
                        principalTable: "StandartEducationalPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandartEducationalProgramId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalPrograms_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EducationalPrograms_StandartEducationalPrograms_StandartEducationalProgramId",
                        column: x => x.StandartEducationalProgramId,
                        principalTable: "StandartEducationalPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramLearningOutcomes_SEPs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramLearningOutcomesId = table.Column<int>(type: "int", nullable: false),
                    StandartEducationalProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramLearningOutcomes_SEPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramLearningOutcomes_SEPs_ProgramLearningOutcomes_ProgramLearningOutcomesId",
                        column: x => x.ProgramLearningOutcomesId,
                        principalTable: "ProgramLearningOutcomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramLearningOutcomes_SEPs_StandartEducationalPrograms_StandartEducationalProgramId",
                        column: x => x.StandartEducationalProgramId,
                        principalTable: "StandartEducationalPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competence_EP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetenceId = table.Column<int>(type: "int", nullable: false),
                    EducationalProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competence_EP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competence_EP_Competence_CompetenceId",
                        column: x => x.CompetenceId,
                        principalTable: "Competence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Competence_EP_EducationalPrograms_EducationalProgramId",
                        column: x => x.EducationalProgramId,
                        principalTable: "EducationalPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalComponent_Competences_EPs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalProgramId = table.Column<int>(type: "int", nullable: false),
                    EducationalComponentId = table.Column<int>(type: "int", nullable: false),
                    CompetenceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalComponent_Competences_EPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalComponent_Competences_EPs_Competence_CompetenceId",
                        column: x => x.CompetenceId,
                        principalTable: "Competence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalComponent_Competences_EPs_EducationalComponents_EducationalComponentId",
                        column: x => x.EducationalComponentId,
                        principalTable: "EducationalComponents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalComponent_Competences_EPs_EducationalPrograms_EducationalProgramId",
                        column: x => x.EducationalProgramId,
                        principalTable: "EducationalPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalComponent_EducationalProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalComponentId = table.Column<int>(type: "int", nullable: false),
                    EducationalProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalComponent_EducationalProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalComponent_EducationalProgram_EducationalComponents_EducationalComponentId",
                        column: x => x.EducationalComponentId,
                        principalTable: "EducationalComponents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalComponent_EducationalProgram_EducationalPrograms_EducationalProgramId",
                        column: x => x.EducationalProgramId,
                        principalTable: "EducationalPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationalComponent_ProgramLearningOutcomes_EPs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalProgramId = table.Column<int>(type: "int", nullable: false),
                    EducationalComponentId = table.Column<int>(type: "int", nullable: false),
                    ProgramLearningOutcomesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalComponent_ProgramLearningOutcomes_EPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalComponent_ProgramLearningOutcomes_EPs_EducationalComponents_EducationalComponentId",
                        column: x => x.EducationalComponentId,
                        principalTable: "EducationalComponents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalComponent_ProgramLearningOutcomes_EPs_EducationalPrograms_EducationalProgramId",
                        column: x => x.EducationalProgramId,
                        principalTable: "EducationalPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalComponent_ProgramLearningOutcomes_EPs_ProgramLearningOutcomes_ProgramLearningOutcomesId",
                        column: x => x.ProgramLearningOutcomesId,
                        principalTable: "ProgramLearningOutcomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramLearningOutcomes_EP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramLearningOutcomesId = table.Column<int>(type: "int", nullable: false),
                    EducationalProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramLearningOutcomes_EP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramLearningOutcomes_EP_EducationalPrograms_EducationalProgramId",
                        column: x => x.EducationalProgramId,
                        principalTable: "EducationalPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramLearningOutcomes_EP_ProgramLearningOutcomes_ProgramLearningOutcomesId",
                        column: x => x.ProgramLearningOutcomesId,
                        principalTable: "ProgramLearningOutcomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b1bd789-61df-4137-a28b-72a146ebafe3", null, "Ministry", "MINISTRY" },
                    { "ead3d48c-7f89-41ff-b44b-e1138e909b2d", null, "University", "UNIVERSITY" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SurName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "55507d97-e5d0-4de2-91b5-71b5ed6130e8", 0, "bc52c901-2ecf-4b8a-bfa8-4d1e4de7cc3e", "AppUser", "university@email.com", true, "John", "Connor", false, null, "UNIVERSITY@EMAIL.COM", "UNIVERSITY@EMAIL.COM", "AQAAAAIAAYagAAAAEB8ZjpblZRHwx6FPiQ6oso/GNvCo9JpiCM8K7pdrE9ECT1EukGBBrMD+c5OTj69SnQ==", "+xx(xxx)xxx-xx-xx", true, "f681e3ff-846a-4acf-bd5b-bef0f3a1acad", "Johnovych", false, "university@email.com" },
                    { "a3b914e2-8809-40fb-815a-19fec6301d9a", 0, "a54d7cdd-ff37-41d2-8a54-b66ef6cb71ad", "AppUser", "ministry@email.com", true, "John", "Connor", false, null, "MINISTRY@EMAIL.COM", "MINISTRY@EMAIL.COM", "AQAAAAIAAYagAAAAEMZuAUTdTVpnxQ5rpKJowwzyL92OlzkocIU8PfEpNYM0mkWuqobMf9Hl/ogU2MTK6w==", "+xx(xxx)xxx-xx-xx", true, "f38d2eed-f6bb-4047-b5f9-ee7ca7a6c199", "Johnovych", false, "ministry@email.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ead3d48c-7f89-41ff-b44b-e1138e909b2d", "55507d97-e5d0-4de2-91b5-71b5ed6130e8" },
                    { "7b1bd789-61df-4137-a28b-72a146ebafe3", "a3b914e2-8809-40fb-815a-19fec6301d9a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Competence_AppUserId",
                table: "Competence",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Competence_EP_CompetenceId",
                table: "Competence_EP",
                column: "CompetenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Competence_EP_EducationalProgramId",
                table: "Competence_EP",
                column: "EducationalProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Competences_SEPs_CompetenceId",
                table: "Competences_SEPs",
                column: "CompetenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Competences_SEPs_StandartEducationalProgramId",
                table: "Competences_SEPs",
                column: "StandartEducationalProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalComponent_Competences_EPs_CompetenceId",
                table: "EducationalComponent_Competences_EPs",
                column: "CompetenceId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalComponent_Competences_EPs_EducationalComponentId",
                table: "EducationalComponent_Competences_EPs",
                column: "EducationalComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalComponent_Competences_EPs_EducationalProgramId",
                table: "EducationalComponent_Competences_EPs",
                column: "EducationalProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalComponent_EducationalProgram_EducationalComponentId",
                table: "EducationalComponent_EducationalProgram",
                column: "EducationalComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalComponent_EducationalProgram_EducationalProgramId",
                table: "EducationalComponent_EducationalProgram",
                column: "EducationalProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalComponent_ProgramLearningOutcomes_EPs_EducationalComponentId",
                table: "EducationalComponent_ProgramLearningOutcomes_EPs",
                column: "EducationalComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalComponent_ProgramLearningOutcomes_EPs_EducationalProgramId",
                table: "EducationalComponent_ProgramLearningOutcomes_EPs",
                column: "EducationalProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalComponent_ProgramLearningOutcomes_EPs_ProgramLearningOutcomesId",
                table: "EducationalComponent_ProgramLearningOutcomes_EPs",
                column: "ProgramLearningOutcomesId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalPrograms_AppUserId",
                table: "EducationalPrograms",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalPrograms_StandartEducationalProgramId",
                table: "EducationalPrograms",
                column: "StandartEducationalProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramLearningOutcomes_AppUserId",
                table: "ProgramLearningOutcomes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramLearningOutcomes_EP_EducationalProgramId",
                table: "ProgramLearningOutcomes_EP",
                column: "EducationalProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramLearningOutcomes_EP_ProgramLearningOutcomesId",
                table: "ProgramLearningOutcomes_EP",
                column: "ProgramLearningOutcomesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramLearningOutcomes_SEPs_ProgramLearningOutcomesId",
                table: "ProgramLearningOutcomes_SEPs",
                column: "ProgramLearningOutcomesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramLearningOutcomes_SEPs_StandartEducationalProgramId",
                table: "ProgramLearningOutcomes_SEPs",
                column: "StandartEducationalProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StandartEducationalPrograms_SpecialtyId",
                table: "StandartEducationalPrograms",
                column: "SpecialtyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Competence_EP");

            migrationBuilder.DropTable(
                name: "Competences_SEPs");

            migrationBuilder.DropTable(
                name: "EducationalComponent_Competences_EPs");

            migrationBuilder.DropTable(
                name: "EducationalComponent_EducationalProgram");

            migrationBuilder.DropTable(
                name: "EducationalComponent_ProgramLearningOutcomes_EPs");

            migrationBuilder.DropTable(
                name: "ProgramLearningOutcomes_EP");

            migrationBuilder.DropTable(
                name: "ProgramLearningOutcomes_SEPs");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Competence");

            migrationBuilder.DropTable(
                name: "EducationalComponents");

            migrationBuilder.DropTable(
                name: "EducationalPrograms");

            migrationBuilder.DropTable(
                name: "ProgramLearningOutcomes");

            migrationBuilder.DropTable(
                name: "StandartEducationalPrograms");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Specialties");
        }
    }
}