using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenditureTracker.Model
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public string Date { get; set; }
        public double SalesTax { get; set; }
        public double SalesTotal { get; set; }

        public Receipt(string Date, double SalesTax, double TotalSales)
        {
            this.Date = Date;
            this.SalesTax = SalesTax;
            this.SalesTotal = SalesTotal;
        }
    }
}
