using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class Payroll
    {
        public int id { get; set; }
        public int StaffID { get; set; }
        public int year { get; set; }
        public int Month { get; set; }
        public string Branch { get; set; }
        public int EmpNo { get; set; }
        public string AccessCardNo { get; set; }
        public string FullNameEn { get; set; }
        public string FullNameAr { get; set; }
        public string Nationality { get; set; }
        public string LabourStaffCardNo { get; set; }
        public DateTime PayDateStart { get; set; }
        public DateTime PayDateEnd { get; set; }
        public int DaysInPeriod { get; set; }
        public float SalaryBS { get; set; }
        public float SalaryHA { get; set; }
        public float SalaryTele { get; set; }
        public float SalaryFuel { get; set; }
        public float SalaryOthers { get; set; }
        public float EndOfServiceBenefits { get; set; }
        public float SalaryPassage { get; set; }
        public float SalaryOvertime { get; set; }
        public float SalaryBonus { get; set; }
        public float SocailSecurity { get; set; }
        public float SocialInsurance { get; set; }
        public float Absence { get; set; }
        public int NoOfDays { get; set; }
        public float Delay { get; set; }
        public float OthersDeductions { get; set; }
        public float Loans { get; set; }
        public float WorkDays { get; set; }
        public float SalaryRetroactiveIncome { get; set; }
        public float SalaryAirTickits { get; set; }
        public string VacationEntitlement { get; set; }
        public string VacationDays { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedOn { get; set; }



    }
}
