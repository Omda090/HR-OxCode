﻿// <auto-generated />
using System;
using HR_OxCode.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HR_OxCode.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211228101807_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HR_OxCode.Models.Overtime", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BasicSalary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpNo")
                        .HasColumnType("int");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Month")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfDayes")
                        .HasColumnType("int");

                    b.Property<int>("NoOfHours")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TranportAllowance")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("overtimes");
                });

            modelBuilder.Entity("HR_OxCode.Models.Payroll", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Absence")
                        .HasColumnType("real");

                    b.Property<string>("AccessCardNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApprovedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DaysInPeriod")
                        .HasColumnType("int");

                    b.Property<float>("Delay")
                        .HasColumnType("real");

                    b.Property<int>("EmpNo")
                        .HasColumnType("int");

                    b.Property<float>("EndOfServiceBenefits")
                        .HasColumnType("real");

                    b.Property<string>("FullNameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabourStaffCardNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Loans")
                        .HasColumnType("real");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfDays")
                        .HasColumnType("int");

                    b.Property<float>("OthersDeductions")
                        .HasColumnType("real");

                    b.Property<DateTime>("PayDateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PayDateStart")
                        .HasColumnType("datetime2");

                    b.Property<float>("SalaryAirTickits")
                        .HasColumnType("real");

                    b.Property<float>("SalaryBS")
                        .HasColumnType("real");

                    b.Property<float>("SalaryBonus")
                        .HasColumnType("real");

                    b.Property<float>("SalaryFuel")
                        .HasColumnType("real");

                    b.Property<float>("SalaryHA")
                        .HasColumnType("real");

                    b.Property<float>("SalaryOthers")
                        .HasColumnType("real");

                    b.Property<float>("SalaryOvertime")
                        .HasColumnType("real");

                    b.Property<float>("SalaryPassage")
                        .HasColumnType("real");

                    b.Property<float>("SalaryRetroactiveIncome")
                        .HasColumnType("real");

                    b.Property<float>("SalaryTele")
                        .HasColumnType("real");

                    b.Property<float>("SocailSecurity")
                        .HasColumnType("real");

                    b.Property<float>("SocialInsurance")
                        .HasColumnType("real");

                    b.Property<int>("StaffID")
                        .HasColumnType("int");

                    b.Property<string>("VacationDays")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VacationEntitlement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("WorkDays")
                        .HasColumnType("real");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Payrolles");
                });

            modelBuilder.Entity("HR_OxCode.Models.StaffProfile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AttendenceNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullNameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("StaffProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
