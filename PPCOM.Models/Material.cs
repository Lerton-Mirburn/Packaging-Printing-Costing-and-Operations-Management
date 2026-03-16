using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class Material
    {
        public int material_id { get; set; }
        public string material_name { get; set; }
        public string unit { get; set; }
        public decimal price { get; set; }
    }
}
