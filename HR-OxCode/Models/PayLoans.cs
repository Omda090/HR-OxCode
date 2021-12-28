using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_OxCode.Models
{
    public class PayLoans
    {
        public int id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime Date { get; set; }
        public int installmentNo { get; set; }
        public decimal installmentAmount { get; set; }
    }
}
