using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class Letters
    {
        public int id { get; set; }
        //joiningLetter
        public int EmpNo { get; set; }
        public string FullName { get; set; }
        public string jobTittle { get; set; }
        public DateTime LetterDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Signature { get; set; }

        //
        public DateTime WarningDate { get; set; }
        public string ViolationDamage { get; set; }
        public string Penelty { get; set; }
        public string WarningType { get; set; }

        //TerminationLetter
        // public string Signature { get; set; }


        //SalaryTransfer
        public string BankName { get; set; }
        public string Branch { get; set; }
        public long AccountNumber { get; set; }
        public DateTime SalaryDate { get; set; }

        //SalaryCertificate : 
        //LetterDate - BankName - Signature

        //EffectiveDateNotes :
        public DateTime StartingDateOn { get; set; }

        //CertificateofExperience : 
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }

    }
}
