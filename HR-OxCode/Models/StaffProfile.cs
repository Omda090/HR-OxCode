using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class StaffProfile
    {
      
        public int StaffID { get; set; }
        public string FullNameEn { get; set; }
        public string FullNameAr { get; set; }
        public int AttendenceNo { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string Gender { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public DateTime DateOfTime { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
       // internal static string message;



    }
}
