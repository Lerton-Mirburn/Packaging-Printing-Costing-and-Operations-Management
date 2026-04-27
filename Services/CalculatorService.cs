using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Services
{
    public class CalculatorService
    {
        public double RamCost(double length, double width, double gsm, double PaperPricePerTon)
        {
            return (length / 100 * width / 100) * (gsm / 1000)
                 * (PaperPricePerTon / 1000) * 500;
        }

        public double RequiredSheets(int productAmount, int unitsPerSheet, int wasteSheets)
        {
            return (productAmount / unitsPerSheet) + wasteSheets;
        }

        public double SheetCost(double ram, double ramCost)
        {
            return ram * ramCost;
        }


        public double PlateCost(bool isBig, int colorAmount)
        {
            double giaKem = isBig ? 100000 : 60000;
            return colorAmount * giaKem;
        }

        public double PrintingCost(int colorAmount, int productAmount)
        {
            if (productAmount < 5000)
            {
                return colorAmount * 300000;
            }
            else
            {
                return colorAmount * 70 * productAmount;
            }
        }

        public double UvCost(double length, double width)
        {
            return (length / 100 * width / 100) * 1400 * 1000;
        }
        public double MatteLaminationCost(double length, double width, int unitsPerSheet, int productAmount)
        {
            return ((length / 100 * width / 100) * 2200 * 1) / unitsPerSheet * productAmount;
        }
        public double DieCuttingCost(double unitsPerSheet, double productAmount)
        {
            return unitsPerSheet * 150 * productAmount;
        }
        public double GluingCost(int productAmount)
        {
            if (productAmount <= 5000)
            {
                return 300000;
            }

            int increase = (productAmount - 5000) / 1000;
            return 300000 + increase * 100000;
        }
        public double BoxCost(int productAmount)
        {
            return productAmount / 500 * 20000;
        }
        public double Total(double sheetCost, double plateCost, 
                            double printingCost, double uvCost,
                            double uvFrameCost, double matteLaminationCost,
                            double dieCuttingCost, double dieCuttingFrameCost,
                            double gluingCost, double boxCost,
                            double deliveryCost, double proffPrintingCost)
        {
            return sheetCost + plateCost + printingCost + uvCost + uvFrameCost 
                + matteLaminationCost + dieCuttingCost + dieCuttingFrameCost
                + gluingCost + boxCost + deliveryCost + proffPrintingCost;
        }
    }
}
