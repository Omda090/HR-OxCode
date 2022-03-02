using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class HRPanelVacationRequest
    {
        //Vacation Request :
        public int id { get; set; }
        public string LeaveType { get; set; }
        public DateTime LeaveFrom { get; set; }
        public DateTime LeaveTo { get; set; }
        public int NoOfDays { get; set; }
        public string LeaveReason { get; set; }
        public string ContactDetails { get; set; }
        public string SavedBy { get; set; }

    }
}
