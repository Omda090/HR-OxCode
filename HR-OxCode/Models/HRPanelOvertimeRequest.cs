using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class HRPanelOvertimeRequest
    {
        //Overtime Request : 
        public int id { get; set; }
        public DateTime DateMonth { get; set; }
        public int NoOfHourse { get; set; }
        public float Amount { get; set; }
        public string OverNotes { get; set; }
        public string CreatedBy { get; set; }
        public string TotalOvertime { get; set; }
        public string Totalpaid { get; set; }
        public string TotalOVPending { get; set; }
    }
}
