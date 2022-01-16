using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class StaffProfile
    {

        public int id { get; set; }
        public int StaffID { get; set; }
        public string FullNameEn { get; set; }
        public string FullNameAr { get; set; }
        public int AttendenceNo { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string Gender { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }
        public DateTime DateOfTime { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        // internal static string message;


        //frmAttendence :
        public string EmpName { get; set; }
        public string Branch { get; set; }
        public string AttendState { get; set; }
        public DateTime Date { get; set; }

        //StaffAbsence :
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public string jobtitle { get; set; }
        public DateTime AbsenceFrom { get; set; }
        public DateTime AbsenceTo { get; set; }
        public int NoOfDays { get; set; }
        public string AbsenceType { get; set; }
        public string AbsenceDetails { get; set; }

    }
}
