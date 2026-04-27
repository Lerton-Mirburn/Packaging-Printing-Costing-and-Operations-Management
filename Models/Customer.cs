using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class Customer
    {
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
    }
}
