using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class LoansManagement
    {
        public int id { get; set; }
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string JobTitle { get; set; }
        public string Notes { get; set; }
        public decimal LoansAmount { get; set; }
        public int NoOfinstallments { get; set; }
        public decimal DeductFromSalary { get; set; }
        public string LoanType { get; set; }
        public DateTime LoanHistory { get; set; }
    }
}
