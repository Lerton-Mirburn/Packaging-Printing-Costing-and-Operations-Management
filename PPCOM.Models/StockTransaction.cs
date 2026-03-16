using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class StockTransaction
    {
        public int transaction_id { get; set; }
        public int material_id { get; set; }
        public string transaction_type { get; set; }
        public int quantity { get; set; }
        public DateTime transaction_date { get; set; }
    }
}
