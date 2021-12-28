using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_OxCode.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "overtimes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNo = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicSalary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranportAllowance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Month = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoOfHours = table.Column<int>(type: "int", nullable: false),
                    NoOfDayes = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_overtimes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Payrolles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpNo = table.Column<int>(type: "int", nullable: false),
                    AccessCardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullNameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullNameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabourStaffCardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayDateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayDateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DaysInPeriod = table.Column<int>(type: "int", nullable: false),
                    SalaryBS = table.Column<float>(type: "real", nullable: false),
                    SalaryHA = table.Column<float>(type: "real", nullable: false),
                    SalaryTele = table.Column<float>(type: "real", nullable: false),
                    SalaryFuel = table.Column<float>(type: "real", nullable: false),
                    SalaryOthers = table.Column<float>(type: "real", nullable: false),
                    EndOfServiceBenefits = table.Column<float>(type: "real", nullable: false),
                    SalaryPassage = table.Column<float>(type: "real", nullable: false),
                    SalaryOvertime = table.Column<float>(type: "real", nullable: false),
                    SalaryBonus = table.Column<float>(type: "real", nullable: false),
                    SocailSecurity = table.Column<float>(type: "real", nullable: false),
                    SocialInsurance = table.Column<float>(type: "real", nullable: false),
                    Absence = table.Column<float>(type: "real", nullable: false),
                    NoOfDays = table.Column<int>(type: "int", nullable: false),
                    Delay = table.Column<float>(type: "real", nullable: false),
                    OthersDeductions = table.Column<float>(type: "real", nullable: false),
                    Loans = table.Column<float>(type: "real", nullable: false),
                    WorkDays = table.Column<float>(type: "real", nullable: false),
                    SalaryRetroactiveIncome = table.Column<float>(type: "real", nullable: false),
                    SalaryAirTickits = table.Column<float>(type: "real", nullable: false),
                    VacationEntitlement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VacationDays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payrolles", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "overtimes");

            migrationBuilder.DropTable(
                name: "Payrolles");
        }
    }
}
