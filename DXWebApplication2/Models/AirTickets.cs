using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class AirTickets
    {
        //EmployeeDetails

        public int id { get; set; }
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string jobTitle { get; set; }
        public string Branch { get; set; }
        public string Nationality { get; set; }

        //AirTicketDetails
        public DateTime Year { get; set; }
        public string FlightDetails { get; set; }
        public string Payment { get; set; }

        //No-of-Passengers
        public int Adults { get; set; }
        public int Children { get; set; }
        public int Infants { get; set; }
        public float ValuePrice { get; set; }

        //installment
        public int NoOfinstallment { get; set; }
        public DateTime Dateinstallment { get; set; }
        public float installmentAmount { get; set; }

        //Health Insurance
        public string InsuranceCompany { get; set; }
        public int PolicyNo { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string InsuredMemberName { get; set; }
        public int CardNo { get; set; }
        public string Class { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public float BasicPremium { get; set; }
        public float InsuranceAmount { get; set; }

        //Excusing Properity:
        //LeaveDetails : 
        public string ExcuseFrom { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int NoOfDays { get; set; }
        public int NoOfHours { get; set; }
        public string LeaveReason { get; set; }

    }
}
