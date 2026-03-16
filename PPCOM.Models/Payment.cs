using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class Payment
    {
        public int payment_id { get; set; }
        public int debt_id { get; set; }
        public decimal payment_amount { get; set; }
        public DateTime payment_date { get; set; }
    }
}
