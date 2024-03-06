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
                    Code = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalComponents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandartEducationalPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    SpecialtyName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandartEducationalPrograms", x => x.Id);
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
                name: "EducationalPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
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
                    { "519b69d8-a6d9-4c3a-9070-b9d48dc9082d", null, "University", "UNIVERSITY" },
                    { "b918b576-2192-456d-bfdf-6849318b3ec9", null, "Ministry", "MINISTRY" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "74590127-f688-4264-90da-b07466a3f2ca", 0, "de52d9fd-e7ff-421b-8ef9-7c1693382260", "AppUser", "ministry@email.com", true, false, null, "MINISTRY@EMAIL.COM", "MINISTRY@EMAIL.COM", "AQAAAAIAAYagAAAAEBB6X2VfUACQOHE7XF4j6HGY452xUn6C6GXjlbAWd0gAzSGt9K7YHlqbi25c/sIRFA==", "+xx(xxx)xxx-xx-xx", true, "ef2f9734-f69b-434a-8257-9928aa7f4ebd", false, "ministry@email.com" },
                    { "99f61281-6493-4ccd-a1db-636b1b479098", 0, "ca395dc9-1394-4f17-a8fb-0caf525c7f21", "AppUser", "university@email.com", true, false, null, "UNIVERSITY@EMAIL.COM", "UNIVERSITY@EMAIL.COM", "AQAAAAIAAYagAAAAEKiTL/+1tNXo6jouJ5Ky3b2E4gSPjycgqyLpZMNzKq6qq3/tTr3uKtEOAzvoSwGrNg==", "+xx(xxx)xxx-xx-xx", true, "787aad28-b456-4f5d-b018-106ca1216448", false, "university@email.com" }
                });

            migrationBuilder.InsertData(
                table: "StandartEducationalPrograms",
                columns: new[] { "Id", "Name", "Specialty", "SpecialtyName", "Year" },
                values: new object[,]
                {
                    { 1, "1", "121", "Інженерія програмного забезпечення", 1 },
                    { 2, "2", "122", "Комп’ютерні науки", 2 },
                    { 3, "3", "123", "Комп’ютерна інженерія", 3 },
                    { 4, "4", "124", "Системний аналіз", 4 },
                    { 5, "5", "125", "Кібербезпека", 5 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b918b576-2192-456d-bfdf-6849318b3ec9", "74590127-f688-4264-90da-b07466a3f2ca" },
                    { "519b69d8-a6d9-4c3a-9070-b9d48dc9082d", "99f61281-6493-4ccd-a1db-636b1b479098" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "AppUserId", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "74590127-f688-4264-90da-b07466a3f2ca", "ЗК1", "ЗК1", "ЗК1" },
                    { 2, "74590127-f688-4264-90da-b07466a3f2ca", "ЗК2", "ЗК2", "ЗК2" },
                    { 3, "74590127-f688-4264-90da-b07466a3f2ca", "ЗК3", "ЗК3", "ЗК3" },
                    { 4, "74590127-f688-4264-90da-b07466a3f2ca", "ЗК4", "ЗК4", "ЗК4" },
                    { 5, "74590127-f688-4264-90da-b07466a3f2ca", "ЗК5", "ЗК5", "ЗК5" }
                });

            migrationBuilder.InsertData(
                table: "ProgramLearningOutcomes",
                columns: new[] { "Id", "AppUserId", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "74590127-f688-4264-90da-b07466a3f2ca", "ПРН1", "ПРН1", "ПРН1" },
                    { 2, "74590127-f688-4264-90da-b07466a3f2ca", "ПРН2", "ПРН2", "ПРН2" },
                    { 3, "74590127-f688-4264-90da-b07466a3f2ca", "ПРН3", "ПРН3", "ПРН3" },
                    { 4, "74590127-f688-4264-90da-b07466a3f2ca", "ПРН4", "ПРН4", "ПРН4" },
                    { 5, "74590127-f688-4264-90da-b07466a3f2ca", "ПРН5", "ПРН5", "ПРН5" }
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
        }
    }
}
