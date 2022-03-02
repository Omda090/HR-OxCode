using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class jobOffer
    {
        //EmployeeDetails
        public int id { get; set; }
        public string EmpName { get; set; }
        public string  PlaceOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string MarsialStatus { get; set; }
        public int IDNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpireDate { get; set; }

        //JobDetails
        public string Branch { get; set; }
        public string JobTitle { get; set; }
        public float BasicSalary { get; set; }
        public float TransAllownse { get; set; }
        public float HouseAllownse { get; set; }
        public float MobileAllownse { get; set; }
        public float Total { get; set; }
        public float Commission { get; set; }
        public string ContractPeriod { get; set; }
        public string ProbationPeriod { get; set; } 
        public string VacationDays { get; set; }
        public string OtherBenefits { get; set; }

    }
}
