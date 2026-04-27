using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class PurchaseOrderDetail
    {
        public int po_detail_id { get; set; }
        public int po_id { get; set; }
        public int material_id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
    }
}
