using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartH2RCore.Core.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Master");

            migrationBuilder.EnsureSchema(
                name: "Employee");

            migrationBuilder.EnsureSchema(
                name: "Company");

            migrationBuilder.CreateTable(
                name: "AccountType",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
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
                name: "Bank",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TDS = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentType",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailSetting",
                schema: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SmtpHost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpPort = table.Column<int>(type: "int", nullable: false),
                    SmtpSecurity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpAuthenticationDomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeStatus",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffType",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flag = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                name: "Company",
                schema: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstablishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PanNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TdsCircle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PfTrust = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorporateAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorporateAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorporateCityId = table.Column<int>(type: "int", nullable: false),
                    CorporateStateId = table.Column<int>(type: "int", nullable: false),
                    CorporateCountryId = table.Column<int>(type: "int", nullable: false),
                    CorporateZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorporatePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrespondanceAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrespondanceAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrespondanceCityId = table.Column<int>(type: "int", nullable: false),
                    CorrespondanceStateId = table.Column<int>(type: "int", nullable: false),
                    CorrespondanceCountryId = table.Column<int>(type: "int", nullable: false),
                    CorrespondanceZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrespondancePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyEngaged = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpfNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpfDbfFileCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpfDbfExt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EsiNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EsiLocalNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsiblePerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureOfBusiness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPFEmployerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubEPFEmployerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESIEmployerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubESIEmployerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    ISO31663CCodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalSchema: "Master",
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_DepartmentType_DepartmentTypeId",
                        column: x => x.DepartmentTypeId,
                        principalSchema: "Master",
                        principalTable: "DepartmentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSubType",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSubType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSubType_EmployeeType_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalSchema: "Master",
                        principalTable: "EmployeeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApproverInformation",
                schema: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    LineManagerId = table.Column<int>(type: "int", nullable: true),
                    DottedLineManagerId = table.Column<int>(type: "int", nullable: true),
                    BusinessHeadId = table.Column<int>(type: "int", nullable: true),
                    FinanceManagerId = table.Column<int>(type: "int", nullable: true),
                    NetworkAdministrationClearanceId = table.Column<int>(type: "int", nullable: true),
                    VirtualHeadId = table.Column<int>(type: "int", nullable: true),
                    AdminId = table.Column<int>(type: "int", nullable: true),
                    HRTAId = table.Column<int>(type: "int", nullable: true),
                    HRCBId = table.Column<int>(type: "int", nullable: true),
                    HRBPId = table.Column<int>(type: "int", nullable: true),
                    ManagementMdId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApproverInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApproverInformation_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApproverInformation_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                schema: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ESICodeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESIWorkLocationOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESIContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PTCircle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<int>(type: "int", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    EPFCodeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPFWorkLocationOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPFContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TDSCircle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branch_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChildrenDetails",
                schema: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildrenDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChildrenDetails_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildrenDetails_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                schema: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressOrLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalExperience = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    YearFrom = table.Column<int>(type: "int", nullable: true),
                    YearTo = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Company_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactList",
                schema: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PresentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeofTransport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickUpPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactList_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactList_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DocumentCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentDetails_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentDetails_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationalQualification",
                schema: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EducationId = table.Column<int>(type: "int", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolOrInstituteOrUniversityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearFrom = table.Column<int>(type: "int", nullable: true),
                    YearTo = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalQualification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalQualification_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationalQualification_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContactDetails",
                schema: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relation = table.Column<int>(type: "int", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandLineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencyContactDetails_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmergencyContactDetails_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                schema: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankNameforSalary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankBranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandLineNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodGroup = table.Column<int>(type: "int", nullable: true),
                    AccountNoforSalary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IfscCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrivingLicenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportIssuedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FatherOrHusbandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    SpouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofAnniversary = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalDetails_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDetails_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalQualification",
                schema: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstituteOrUniversityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearFrom = table.Column<int>(type: "int", nullable: true),
                    YearTo = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalQualification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionalQualification_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalQualification_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingDetails",
                schema: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TrainingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConductedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingDetails_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingDetails_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Master",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchAccountType",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    AccountTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchAccountType", x => new { x.BranchId, x.AccountTypeId });
                    table.ForeignKey(
                        name: "FK_BranchAccountType_AccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalSchema: "Master",
                        principalTable: "AccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchAccountType_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchBank",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchBank", x => new { x.BranchId, x.BankId });
                    table.ForeignKey(
                        name: "FK_BranchBank_Bank_BankId",
                        column: x => x.BankId,
                        principalSchema: "Master",
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchBank_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchCountry",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchCountry", x => new { x.BranchId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_BranchCountry_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchCountry_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Master",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchCurrencyCode",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchCurrencyCode", x => new { x.BranchId, x.CurrencyId });
                    table.ForeignKey(
                        name: "FK_BranchCurrencyCode_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchCurrencyCode_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalSchema: "Master",
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchDepartment",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchDepartment", x => new { x.BranchId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_BranchDepartment_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchDepartment_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "Master",
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchDepartmentType",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DepartmentTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchDepartmentType", x => new { x.BranchId, x.DepartmentTypeId });
                    table.ForeignKey(
                        name: "FK_BranchDepartmentType_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchDepartmentType_DepartmentType_DepartmentTypeId",
                        column: x => x.DepartmentTypeId,
                        principalSchema: "Master",
                        principalTable: "DepartmentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchDesignation",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchDesignation", x => new { x.BranchId, x.DesignationId });
                    table.ForeignKey(
                        name: "FK_BranchDesignation_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchDesignation_Designation_DesignationId",
                        column: x => x.DesignationId,
                        principalSchema: "Master",
                        principalTable: "Designation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchEmployeeStatus",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    EmployeeStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchEmployeeStatus", x => new { x.BranchId, x.EmployeeStatusId });
                    table.ForeignKey(
                        name: "FK_BranchEmployeeStatus_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchEmployeeStatus_EmployeeStatus_EmployeeStatusId",
                        column: x => x.EmployeeStatusId,
                        principalSchema: "Master",
                        principalTable: "EmployeeStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchEmployeeSubType",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    EmployeeSubTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchEmployeeSubType", x => new { x.BranchId, x.EmployeeSubTypeId });
                    table.ForeignKey(
                        name: "FK_BranchEmployeeSubType_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchEmployeeSubType_EmployeeSubType_EmployeeSubTypeId",
                        column: x => x.EmployeeSubTypeId,
                        principalSchema: "Master",
                        principalTable: "EmployeeSubType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchEmployeeType",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchEmployeeType", x => new { x.BranchId, x.EmployeeTypeId });
                    table.ForeignKey(
                        name: "FK_BranchEmployeeType_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchEmployeeType_EmployeeType_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalSchema: "Master",
                        principalTable: "EmployeeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchGrade",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchGrade", x => new { x.BranchId, x.GradeId });
                    table.ForeignKey(
                        name: "FK_BranchGrade_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchGrade_Grade_GradeId",
                        column: x => x.GradeId,
                        principalSchema: "Master",
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchRole",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchRole", x => new { x.BranchId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_BranchRole_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchRole_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchStaffType",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    StaffTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchStaffType", x => new { x.BranchId, x.StaffTypeId });
                    table.ForeignKey(
                        name: "FK_BranchStaffType_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchStaffType_StaffType_StaffTypeId",
                        column: x => x.StaffTypeId,
                        principalSchema: "Master",
                        principalTable: "StaffType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobDetails",
                schema: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DepartmentTypeId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    EmployeeStatusId = table.Column<int>(type: "int", nullable: false),
                    DateofJoining = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OfficialMobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficialEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeSubTypeId = table.Column<int>(type: "int", nullable: false),
                    ExtNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticePeriod = table.Column<int>(type: "int", nullable: true),
                    CTCPerAnnum = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false),
                    PFNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UanNumber = table.Column<long>(type: "bigint", nullable: false),
                    EsiDispensary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PfrEgionOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EsiNumber = table.Column<long>(type: "bigint", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobDetails_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobDetails_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobDetails_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Company",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BranchState",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchState", x => new { x.BranchId, x.StateId });
                    table.ForeignKey(
                        name: "FK_BranchState_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchState_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "Master",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DateTime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "Master",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchCity",
                schema: "Company",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchCity", x => new { x.BranchId, x.CityId });
                    table.ForeignKey(
                        name: "FK_BranchCity_Branch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "Company",
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchCity_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "Master",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApproverInformation_CompanyId",
                schema: "Employee",
                table: "ApproverInformation",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ApproverInformation_EmployeeId",
                schema: "Employee",
                table: "ApproverInformation",
                column: "EmployeeId");

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
                name: "IX_Branch_CompanyId",
                schema: "Company",
                table: "Branch",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchAccountType_AccountTypeId",
                schema: "Company",
                table: "BranchAccountType",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchBank_BankId",
                schema: "Company",
                table: "BranchBank",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchCity_CityId",
                schema: "Company",
                table: "BranchCity",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchCountry_CountryId",
                schema: "Company",
                table: "BranchCountry",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchCurrencyCode_CurrencyId",
                schema: "Company",
                table: "BranchCurrencyCode",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchDepartment_DepartmentId",
                schema: "Company",
                table: "BranchDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchDepartmentType_DepartmentTypeId",
                schema: "Company",
                table: "BranchDepartmentType",
                column: "DepartmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchDesignation_DesignationId",
                schema: "Company",
                table: "BranchDesignation",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchEmployeeStatus_EmployeeStatusId",
                schema: "Company",
                table: "BranchEmployeeStatus",
                column: "EmployeeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchEmployeeSubType_EmployeeSubTypeId",
                schema: "Company",
                table: "BranchEmployeeSubType",
                column: "EmployeeSubTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchEmployeeType_EmployeeTypeId",
                schema: "Company",
                table: "BranchEmployeeType",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchGrade_GradeId",
                schema: "Company",
                table: "BranchGrade",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchRole_RoleId",
                schema: "Company",
                table: "BranchRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchStaffType_StaffTypeId",
                schema: "Company",
                table: "BranchStaffType",
                column: "StaffTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchState_StateId",
                schema: "Company",
                table: "BranchState",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ChildrenDetails_CompanyId",
                schema: "Employee",
                table: "ChildrenDetails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ChildrenDetails_EmployeeId",
                schema: "Employee",
                table: "ChildrenDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                schema: "Master",
                table: "City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_UserId",
                schema: "Company",
                table: "Company",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_CompanyId",
                schema: "Employee",
                table: "Company",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_EmployeeId",
                schema: "Employee",
                table: "Company",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactList_CompanyId",
                schema: "Employee",
                table: "ContactList",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactList_EmployeeId",
                schema: "Employee",
                table: "ContactList",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_CurrencyId",
                schema: "Master",
                table: "Country",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_DepartmentTypeId",
                schema: "Master",
                table: "Department",
                column: "DepartmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentDetails_CompanyId",
                table: "DocumentDetails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentDetails_EmployeeId",
                table: "DocumentDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalQualification_CompanyId",
                schema: "Employee",
                table: "EducationalQualification",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalQualification_EmployeeId",
                schema: "Employee",
                table: "EducationalQualification",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContactDetails_CompanyId",
                schema: "Employee",
                table: "EmergencyContactDetails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContactDetails_EmployeeId",
                schema: "Employee",
                table: "EmergencyContactDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSubType_EmployeeTypeId",
                schema: "Master",
                table: "EmployeeSubType",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDetails_BranchId",
                schema: "Employee",
                table: "JobDetails",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDetails_CompanyId",
                schema: "Employee",
                table: "JobDetails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDetails_EmployeeId",
                schema: "Employee",
                table: "JobDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetails_CompanyId",
                schema: "Employee",
                table: "PersonalDetails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetails_EmployeeId",
                schema: "Employee",
                table: "PersonalDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualification_CompanyId",
                schema: "Company",
                table: "ProfessionalQualification",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalQualification_EmployeeId",
                schema: "Company",
                table: "ProfessionalQualification",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                schema: "Master",
                table: "State",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingDetails_CompanyId",
                schema: "Company",
                table: "TrainingDetails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingDetails_EmployeeId",
                schema: "Company",
                table: "TrainingDetails",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApproverInformation",
                schema: "Employee");

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
                name: "BranchAccountType",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchBank",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchCity",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchCountry",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchCurrencyCode",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchDepartment",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchDepartmentType",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchDesignation",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchEmployeeStatus",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchEmployeeSubType",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchEmployeeType",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchGrade",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchRole",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchStaffType",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "BranchState",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "ChildrenDetails",
                schema: "Employee");

            migrationBuilder.DropTable(
                name: "Company",
                schema: "Employee");

            migrationBuilder.DropTable(
                name: "ContactList",
                schema: "Employee");

            migrationBuilder.DropTable(
                name: "DocumentDetails");

            migrationBuilder.DropTable(
                name: "EducationalQualification",
                schema: "Employee");

            migrationBuilder.DropTable(
                name: "EmailSetting",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "EmergencyContactDetails",
                schema: "Employee");

            migrationBuilder.DropTable(
                name: "JobDetails",
                schema: "Employee");

            migrationBuilder.DropTable(
                name: "PersonalDetails",
                schema: "Employee");

            migrationBuilder.DropTable(
                name: "ProfessionalQualification",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "TrainingDetails",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "AccountType",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Bank",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "City",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Designation",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "EmployeeStatus",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "EmployeeSubType",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Grade",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "StaffType",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Branch",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "State",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "DepartmentType",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "EmployeeType",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Company",
                schema: "Company");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Currency",
                schema: "Master");
        }
    }
}
