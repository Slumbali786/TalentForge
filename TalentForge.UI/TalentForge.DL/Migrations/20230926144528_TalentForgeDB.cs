using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TalentForge.DL.Migrations
{
    /// <inheritdoc />
    public partial class TalentForgeDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompUsers",
                columns: table => new
                {
                    CUID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompUsers", x => x.CUID);
                });

            migrationBuilder.CreateTable(
                name: "RegUsers",
                columns: table => new
                {
                    RUID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<bool>(type: "bit", nullable: false),
                    ContactNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegUsers", x => x.RUID);
                });

            migrationBuilder.CreateTable(
                name: "CVTemplates",
                columns: table => new
                {
                    CVTID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompUserCUID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CVTemplates", x => x.CVTID);
                    table.ForeignKey(
                        name: "FK_CVTemplates_CompUsers_CompUserCUID",
                        column: x => x.CompUserCUID,
                        principalTable: "CompUsers",
                        principalColumn: "CUID");
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompUserCUID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JID);
                    table.ForeignKey(
                        name: "FK_Jobs_CompUsers_CompUserCUID",
                        column: x => x.CompUserCUID,
                        principalTable: "CompUsers",
                        principalColumn: "CUID");
                });

            migrationBuilder.CreateTable(
                name: "CreatedCVs",
                columns: table => new
                {
                    CVID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileLoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegUserRUID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatedCVs", x => x.CVID);
                    table.ForeignKey(
                        name: "FK_CreatedCVs_RegUsers_RegUserRUID",
                        column: x => x.RegUserRUID,
                        principalTable: "RegUsers",
                        principalColumn: "RUID");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeHistories",
                columns: table => new
                {
                    EHID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegUserRUID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHistories", x => x.EHID);
                    table.ForeignKey(
                        name: "FK_EmployeeHistories_RegUsers_RegUserRUID",
                        column: x => x.RegUserRUID,
                        principalTable: "RegUsers",
                        principalColumn: "RUID");
                });

            migrationBuilder.CreateTable(
                name: "HigherEducations",
                columns: table => new
                {
                    HEID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollegeNameLoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FieldOfStudy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Complete = table.Column<bool>(type: "bit", nullable: false),
                    RegUserRUID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HigherEducations", x => x.HEID);
                    table.ForeignKey(
                        name: "FK_HigherEducations_RegUsers_RegUserRUID",
                        column: x => x.RegUserRUID,
                        principalTable: "RegUsers",
                        principalColumn: "RUID");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RUMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CUMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompUserCUID = table.Column<int>(type: "int", nullable: true),
                    RegUserRUID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MID);
                    table.ForeignKey(
                        name: "FK_Messages_CompUsers_CompUserCUID",
                        column: x => x.CompUserCUID,
                        principalTable: "CompUsers",
                        principalColumn: "CUID");
                    table.ForeignKey(
                        name: "FK_Messages_RegUsers_RegUserRUID",
                        column: x => x.RegUserRUID,
                        principalTable: "RegUsers",
                        principalColumn: "RUID");
                });

            migrationBuilder.CreateTable(
                name: "RSkills",
                columns: table => new
                {
                    SID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skill1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skill2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skill3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skill4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skill5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skill6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skill7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegUserRUID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSkills", x => x.SID);
                    table.ForeignKey(
                        name: "FK_RSkills_RegUsers_RegUserRUID",
                        column: x => x.RegUserRUID,
                        principalTable: "RegUsers",
                        principalColumn: "RUID");
                });

            migrationBuilder.CreateTable(
                name: "SchoolInfos",
                columns: table => new
                {
                    SIID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LSchoolAttended = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HGradePassed = table.Column<int>(type: "int", nullable: false),
                    FinalYear = table.Column<int>(type: "int", nullable: false),
                    SubMath = table.Column<bool>(type: "bit", nullable: false),
                    SubMathL = table.Column<bool>(type: "bit", nullable: false),
                    SubPhysics = table.Column<bool>(type: "bit", nullable: false),
                    SubLS = table.Column<bool>(type: "bit", nullable: false),
                    SubLO = table.Column<bool>(type: "bit", nullable: false),
                    SubEng = table.Column<bool>(type: "bit", nullable: false),
                    SubAfrik = table.Column<bool>(type: "bit", nullable: false),
                    SubZulu = table.Column<bool>(type: "bit", nullable: false),
                    SubIT = table.Column<bool>(type: "bit", nullable: false),
                    SubAccounting = table.Column<bool>(type: "bit", nullable: false),
                    SubBusiness = table.Column<bool>(type: "bit", nullable: false),
                    SubTourism = table.Column<bool>(type: "bit", nullable: false),
                    SubArt = table.Column<bool>(type: "bit", nullable: false),
                    SubDrama = table.Column<bool>(type: "bit", nullable: false),
                    RegUserRUID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolInfos", x => x.SIID);
                    table.ForeignKey(
                        name: "FK_SchoolInfos_RegUsers_RegUserRUID",
                        column: x => x.RegUserRUID,
                        principalTable: "RegUsers",
                        principalColumn: "RUID");
                });

            migrationBuilder.CreateTable(
                name: "JobsApplied",
                columns: table => new
                {
                    JAID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobsJID = table.Column<int>(type: "int", nullable: true),
                    RegUserRUID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobsApplied", x => x.JAID);
                    table.ForeignKey(
                        name: "FK_JobsApplied_Jobs_JobsJID",
                        column: x => x.JobsJID,
                        principalTable: "Jobs",
                        principalColumn: "JID");
                    table.ForeignKey(
                        name: "FK_JobsApplied_RegUsers_RegUserRUID",
                        column: x => x.RegUserRUID,
                        principalTable: "RegUsers",
                        principalColumn: "RUID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreatedCVs_RegUserRUID",
                table: "CreatedCVs",
                column: "RegUserRUID");

            migrationBuilder.CreateIndex(
                name: "IX_CVTemplates_CompUserCUID",
                table: "CVTemplates",
                column: "CompUserCUID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHistories_RegUserRUID",
                table: "EmployeeHistories",
                column: "RegUserRUID");

            migrationBuilder.CreateIndex(
                name: "IX_HigherEducations_RegUserRUID",
                table: "HigherEducations",
                column: "RegUserRUID");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CompUserCUID",
                table: "Jobs",
                column: "CompUserCUID");

            migrationBuilder.CreateIndex(
                name: "IX_JobsApplied_JobsJID",
                table: "JobsApplied",
                column: "JobsJID");

            migrationBuilder.CreateIndex(
                name: "IX_JobsApplied_RegUserRUID",
                table: "JobsApplied",
                column: "RegUserRUID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CompUserCUID",
                table: "Messages",
                column: "CompUserCUID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_RegUserRUID",
                table: "Messages",
                column: "RegUserRUID");

            migrationBuilder.CreateIndex(
                name: "IX_RSkills_RegUserRUID",
                table: "RSkills",
                column: "RegUserRUID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolInfos_RegUserRUID",
                table: "SchoolInfos",
                column: "RegUserRUID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreatedCVs");

            migrationBuilder.DropTable(
                name: "CVTemplates");

            migrationBuilder.DropTable(
                name: "EmployeeHistories");

            migrationBuilder.DropTable(
                name: "HigherEducations");

            migrationBuilder.DropTable(
                name: "JobsApplied");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "RSkills");

            migrationBuilder.DropTable(
                name: "SchoolInfos");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "RegUsers");

            migrationBuilder.DropTable(
                name: "CompUsers");
        }
    }
}
