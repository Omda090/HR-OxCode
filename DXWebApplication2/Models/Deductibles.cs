using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class Deductibles
    {
        public int id { get; set; }
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public string jobTitle { get; set; }
        public int BasicSalary { get; set; }
        public int Month { get; set; }
        public int NoOfDayes { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public decimal DeductAmount { get; set; }
        public string Reasons { get; set; }
        public string Notes { get; set; }
        public DateTime DeductHistory { get; set; }
        //Last Additional
        public DateTime TotalDeduct { get; set; }
        public DateTime TotalPaid { get; set; }
        public DateTime TotalPending { get; set; }
    }
}
