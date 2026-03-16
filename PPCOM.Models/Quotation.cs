using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class Quotation
    {
        public int quotation_id { get; set; }
        public int customer_id { get; set; }
        public DateTime quotation_date { get; set; }
        public decimal total_price { get; set; }

    }
}
