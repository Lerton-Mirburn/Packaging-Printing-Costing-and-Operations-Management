using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class PurchaseOrder
    {
        public int po_id { get; set; }
        public int supplier_id { get; set; }
        public DateTime order_date { get; set; }
    }
}
