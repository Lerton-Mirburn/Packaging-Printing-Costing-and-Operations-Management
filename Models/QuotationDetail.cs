using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class QuotationDetail
    {
        public int detailId { get; set; }
        public int quotationId { get; set; }

        public double prodX { get; set; }
        public double prodY { get; set; }
        public double prodZ { get; set; }

        public int productAmount { get; set; }
        public int colorAmount { get; set; }
        public int unitsPerSheet { get; set; }

        public double printLength { get; set; }
        public double printWidth { get; set; }
        public int wasteSheet { get; set; }

        public bool bigPrinter { get; set; }

        public int paperTypeId { get; set; }

        public decimal uvFrameCost { get; set; }
        public decimal dieCutFrameCost { get; set; }
        public decimal deliveryAndProof { get; set; }
    }
}
