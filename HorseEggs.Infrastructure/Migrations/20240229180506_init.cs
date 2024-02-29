using System;
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Code = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
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
                    Code = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
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
                    Code = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
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
                    { "18d4496c-b925-4872-9579-d1e9c3f4c3e1", null, "Ministry", "MINISTRY" },
                    { "6c3d1549-1ebc-464d-bf3f-eb591eef712f", null, "University", "UNIVERSITY" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "30a1f01d-c1b4-4252-8662-746626dec2eb", 0, "0f3c4e78-af6b-471c-9ba4-54e6e7b6ecbb", "AppUser", "ministry@email.com", true, false, null, "MINISTRY@EMAIL.COM", "MINISTRY@EMAIL.COM", "AQAAAAIAAYagAAAAEBwnxd3nH7K/G+D+QvNLOKytRfCZR4q5MSzerIoI806Hmkky7T7W2RMnw8CHwBt3RA==", "+xx(xxx)xxx-xx-xx", true, "2731435e-7c72-4827-aa65-d53527b857dd", false, "ministry@email.com" },
                    { "c516c67c-83d2-4507-9829-efc83105763e", 0, "3bfdeb86-c1f1-4d3e-b90c-01de9f9144e8", "AppUser", "university@email.com", true, false, null, "UNIVERSITY@EMAIL.COM", "UNIVERSITY@EMAIL.COM", "AQAAAAIAAYagAAAAEDa3hTC5Grd27agvSIUnm/RTeAJjMxzOjoa48e6tB8FdIxklMEOc3aLlRHdVr4XHUw==", "+xx(xxx)xxx-xx-xx", true, "c7e039c2-8861-42ee-b31c-3630981b5b34", false, "university@email.com" }
                });

            migrationBuilder.InsertData(
                table: "Specialties",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "121", "Інженерія програмного забезпечення" },
                    { 2, "122", "Комп’ютерні науки" },
                    { 3, "123", "Комп’ютерна інженерія" },
                    { 4, "124", "Системний аналіз" },
                    { 5, "125", "Кібербезпека" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "18d4496c-b925-4872-9579-d1e9c3f4c3e1", "30a1f01d-c1b4-4252-8662-746626dec2eb" },
                    { "6c3d1549-1ebc-464d-bf3f-eb591eef712f", "c516c67c-83d2-4507-9829-efc83105763e" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "AppUserId", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "30a1f01d-c1b4-4252-8662-746626dec2eb", "ЗК1", "ЗК1", "ЗК1" },
                    { 2, "30a1f01d-c1b4-4252-8662-746626dec2eb", "ЗК2", "ЗК2", "ЗК2" },
                    { 3, "30a1f01d-c1b4-4252-8662-746626dec2eb", "ЗК3", "ЗК3", "ЗК3" },
                    { 4, "30a1f01d-c1b4-4252-8662-746626dec2eb", "ЗК4", "ЗК4", "ЗК4" },
                    { 5, "30a1f01d-c1b4-4252-8662-746626dec2eb", "ЗК5", "ЗК5", "ЗК5" }
                });

            migrationBuilder.InsertData(
                table: "ProgramLearningOutcomes",
                columns: new[] { "Id", "AppUserId", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "30a1f01d-c1b4-4252-8662-746626dec2eb", "ПРН1", "ПРН1", "ПРН1" },
                    { 2, "30a1f01d-c1b4-4252-8662-746626dec2eb", "ПРН2", "ПРН2", "ПРН2" },
                    { 3, "30a1f01d-c1b4-4252-8662-746626dec2eb", "ПРН3", "ПРН3", "ПРН3" },
                    { 4, "30a1f01d-c1b4-4252-8662-746626dec2eb", "ПРН4", "ПРН4", "ПРН4" },
                    { 5, "30a1f01d-c1b4-4252-8662-746626dec2eb", "ПРН5", "ПРН5", "ПРН5" }
                });

            migrationBuilder.InsertData(
                table: "StandartEducationalPrograms",
                columns: new[] { "Id", "Name", "SpecialtyId", "Year" },
                values: new object[,]
                {
                    { 1, "1", 1, 1 },
                    { 2, "2", 2, 2 },
                    { 3, "3", 3, 3 },
                    { 4, "4", 4, 4 },
                    { 5, "5", 5, 5 }
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
