using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class Appraisal
    {
        public int id { get; set; }
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string jobTitle { get; set; }
        public string Department { get; set; }
        public string Qualification { get; set; }
        public string Branch { get; set; }
        public DateTime HireDate { get; set; }
        public string PerformanceAttribute { get; set; }
        public string Recommendation { get; set; }
        public string Comments { get; set; }


    }
}
