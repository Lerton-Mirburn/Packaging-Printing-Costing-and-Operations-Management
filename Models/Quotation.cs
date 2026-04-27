using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class Quotation
    {
        public int quotationId { get; set; }
        public int customerId { get; set; }

        public DateTime quotationDate { get; set; }

        public decimal totalPrice { get; set; }

        public string customerName { get; set; }
        public string addresses { get; set; }
        public string productName { get; set; }

        public string expiry { get; set; }
        public string deliveryTime { get; set; }

        public double profit { get; set; }
    }
}
