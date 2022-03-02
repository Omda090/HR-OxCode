using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class Excuseing
    {
        public int id { get; set; }
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public DateTime ExcuseFrom { get; set; }
        public DateTime ExcuseTo { get; set; }
        public int NoOfHourse { get; set; }
        public int NoOfDays { get; set; }
        public string LeaveReason { get; set; }

    }
}
