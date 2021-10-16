using Microsoft.EntityFrameworkCore.Migrations;

namespace Home2Med.Server.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speciality = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NurseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NurseDocumentType = table.Column<int>(type: "int", nullable: false),
                    NurseDocument = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NurseGender = table.Column<int>(type: "int", nullable: false),
                    NursePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NurseSpeciality = table.Column<int>(type: "int", nullable: false),
                    NursePhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NurseStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientDocumentType = table.Column<int>(type: "int", nullable: false),
                    PatientDocument = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientGender = table.Column<int>(type: "int", nullable: false),
                    PatientPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientEPS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientGeorreferentiation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientDiagnosis = table.Column<int>(type: "int", nullable: false),
                    PatientDoctor = table.Column<int>(type: "int", nullable: false),
                    PatientPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientStatus = table.Column<bool>(type: "bit", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    NurseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Nurses_NurseId",
                        column: x => x.NurseId,
                        principalTable: "Nurses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Relatives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelativeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelativeDocumentType = table.Column<int>(type: "int", nullable: false),
                    RelativeDocument = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelativeGender = table.Column<int>(type: "int", nullable: false),
                    RelativePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelativeRelationship = table.Column<int>(type: "int", nullable: false),
                    RelativeEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelativePatientDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelativePhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelativeStatus = table.Column<bool>(type: "bit", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relatives_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_NurseId",
                table: "Patients",
                column: "NurseId");

            migrationBuilder.CreateIndex(
                name: "IX_Relatives_PatientId",
                table: "Relatives",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relatives");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Nurses");
        }
    }
}
