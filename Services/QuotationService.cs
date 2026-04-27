using PPCOM.Data;
using PPCOM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Services
{
    public class QuotationService
    {
        private QuotationRepository repo = new QuotationRepository();

        public int AddQuotation(DateTime createDate,
            string customerName,
            string address,
            string productName,
            string expiry,
            string deliveryTime,
            int profit)
        {
            Quotation quo = new Quotation
            {
                customerId = 1, // later replace with real customer selection
                quotationDate = createDate,
                customerName = customerName,
                addresses = address,
                productName = productName,
                expiry = expiry,
                deliveryTime = deliveryTime,
                profit = profit
            };

            return repo.AddQuotation(quo);
        }

        public void AddQuotationDetail(int quotationId,
            double prodX,
            double prodY,
            double prodZ,
            int productAmount,
            int colorAmount,
            int unitsPerSheet,
            double printLength,
            double printWidth,
            int wasteSheet,
            bool bigPrinter,
            int paperTypeId,
            decimal uvFrameCost,
            decimal dieCutFrameCost,
            decimal deliveryAndProof)
        {
            QuotationDetail detail = new QuotationDetail
            {
                quotationId = quotationId,

                prodX = prodX,
                prodY = prodY,
                prodZ = prodZ,

                productAmount = productAmount,
                colorAmount = colorAmount,
                unitsPerSheet = unitsPerSheet,

                printLength = printLength,
                printWidth = printWidth,
                wasteSheet = wasteSheet,

                bigPrinter = bigPrinter,

                paperTypeId = paperTypeId,

                uvFrameCost = uvFrameCost,
                dieCutFrameCost = dieCutFrameCost,
                deliveryAndProof = deliveryAndProof
            };

            repo.AddQuotationDetail(detail);
        }

        public List<paperType> GetPaperTypes()
        {
            return repo.GetPaperTypes();
        }
    }
}
