using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class QuotationDetail
    {
        public int detail_id { get; set; }
        public int quotation_id { get; set; }
        public string description { get; set; }
        public decimal cost { get; set; }
    }
}
