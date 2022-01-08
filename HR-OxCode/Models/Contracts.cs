using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class Contracts
    {
        public int id { get; set; }
        public int StaffID { get; set; }
        public string Name { get; set; }
        //Contracts Details : 

        public DateTime DateForm { get; set; }
        public DateTime DateTo { get; set; }
        public string Notes { get; set; }

    }
}
