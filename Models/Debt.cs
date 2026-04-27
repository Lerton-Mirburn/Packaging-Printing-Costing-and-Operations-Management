using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class Debt
    {
        public int debt_id { get; set; }
        public int supplier_id { get; set; }
        public decimal amount { get; set; }
        public DateTime debt_date { get; set; }
    }
}
