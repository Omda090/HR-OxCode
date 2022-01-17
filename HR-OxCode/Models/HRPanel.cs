using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class HRPanel
    {
        //PersonalInformation : 
        public int id { get; set; }
        public int EmpID { get; set; }
        public int AccessCardNo { get; set; }
        public string FullName { get; set; }
        public string MartialStatus { get; set; }
        public string Nationality { get; set; }
        public string Relegion { get; set; }
        public string Address { get; set; }
        public int Mobile { get; set; }
        //Passports : 
        public int PassNo { get; set; }
        public string IssuePlace { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        //jobDetail :
        public string jobtitle { get; set; }
        public DateTime HireDate { get; set; }
        public string Branch { get; set; }
        public string Department { get; set; }
        //Emergencycontacts :
        public string Name { get; set; }
        public string Relation { get; set; }
        public int Phone { get; set; }
        //Salary Details
        public float BasicSalary { get; set; }
        public float HousingAllownce { get; set; }
        public float TransAllownce { get; set; }
        public float OtherAllownce { get; set; }
        public float TotalSalary { get; set; }
        //--------------------------------------------------------------------------------
        //Loans Request :
        public string Notes { get; set; }
        public float LoanAmount { get; set; }
        public int NoOfinstallment { get; set; }
        public DateTime installmentStarts { get; set; }
        public DateTime TotalLoans { get; set; }
        public DateTime TotalPaid { get; set; }
        public DateTime TotalPending { get; set; }
        //Overtime Request : 
        public DateTime DateMonth { get; set; }
        public int NoOfHourse { get; set; }
        public float Amount { get; set; }
        public string OverNotes { get; set; }
        public string CreatedBy { get; set; }
        public string TotalOvertime { get; set; }
        public string Totalpaid { get; set; }
        public string TotalOVPending { get; set; }
        //Vacation Request :
        public string LeaveType { get; set; }
        public DateTime LeaveFrom { get; set; }
        public DateTime LeaveTo { get; set; }
        public int NoOfDays { get; set; }
        public string LeaveReason { get; set; }
        public string ContactDetails { get; set; }
        public string SavedBy { get; set; }




    }
}
