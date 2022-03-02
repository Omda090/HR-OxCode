using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class HRPanelLoansRequest
    {
        //Loans Request :
        public int id { get; set; }
        public string Notes { get; set; }
        public float LoanAmount { get; set; }
        public int NoOfinstallment { get; set; }
        public DateTime installmentStarts { get; set; }
        public DateTime TotalLoans { get; set; }
        public DateTime TotalPaid { get; set; }
        public DateTime TotalPending { get; set; }
    }
}
