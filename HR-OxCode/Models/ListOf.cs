using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class Settings
    {
        public int id { get; set; }
        public string DepartmentAr { get; set; }
        public string DepartmentEn { get; set; }

        //List of JobTitle
        public string jobtitle { get; set; }

        //List of Nationality
        public string NationalityAr { get; set; }
        public string NationalityEn { get; set; }

        //List of Bank : 
        public string BankName { get; set; }

    }
}
