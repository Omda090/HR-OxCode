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
    }
}
