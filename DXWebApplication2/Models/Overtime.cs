using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class Overtime
    {
        public int id { get; set; }
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Branch { get; set; }
        public string BasicSalary { get; set; }
        public string TranportAllowance { get; set; }
        public DateTime Month { get; set; }
        public int NoOfHours { get; set; }
        public int NoOfDayes { get; set; }
        public string Amount { get; set; }
        public string Notes { get; set; }


    }
}
