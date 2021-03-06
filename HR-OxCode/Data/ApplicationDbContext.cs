using HR_OxCode.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<StaffProfile> StaffProfiles { get; set; }
        public DbSet<Payroll> Payrolles { get; set; }
        public DbSet<Overtime> overtimes { get; set; }
        public DbSet<LoansManagement> loansManagements { get; set; }
        public DbSet<PayLoans> payLoans { get; set; }
        public DbSet<Deductibles> deductibles { get; set; }
        public DbSet<HR_OxCode.Models.Letters> Letters { get; set; }
        public DbSet<HR_OxCode.Models.Contracts> Contracts { get; set; }
        public DbSet<HR_OxCode.Models.Appraisal> Appraisal { get; set; }
        public DbSet<HR_OxCode.Models.AirTickets> AirTickets { get; set; }
        public DbSet<HR_OxCode.Models.Custody> Custody { get; set; }
        public DbSet<HR_OxCode.Models.EndOfService> EndOfService { get; set; }
        public DbSet<HR_OxCode.Models.Excuseing> Excuseing { get; set; }
        public DbSet<HR_OxCode.Models.HRPanel> HRPanel { get; set; }
        public DbSet<HR_OxCode.Models.HRPanelLoansRequest> HRPanelLoansRequest { get; set; }
        public DbSet<HR_OxCode.Models.HRPanelOvertimeRequest> HRPanelOvertimeRequest { get; set; }
        public DbSet<HR_OxCode.Models.HRPanelVacationRequest> HRPanelVacationRequest { get; set; }
        public DbSet<HR_OxCode.Models.Settings> Settings { get; set; }
    }
}
