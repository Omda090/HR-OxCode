using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class EndOfService
    {
        public int id { get; set; }
        public int EmpID { get; set; }
        public string FullName { get; set; }
        public string jobtitle { get; set; }
        public DateTime HireDate { get; set; }
        public string Branch { get; set; }
        //SalaryDetails :
        public float BasicSalary { get; set; }
        public float HouseingAllownse { get; set; }
        public float TransAllownse { get; set; }
        public float TotalSalary { get; set; }
        //EndOf ServiceDetails
        public string TypeOfEnd { get; set; }
        public DateTime EndOfServiceDate { get; set; }
        //Benefits
        public float Benefits { get; set; }
        public string PeriodHiredYM { get; set; }
        public string Comments { get; set; }


    }
}
