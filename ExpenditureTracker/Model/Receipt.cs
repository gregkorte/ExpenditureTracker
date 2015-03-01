using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenditureTracker.Model
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public string Date { get; set; }
        public string StoreName { get; set; }
        public string PurchaseType { get; set; }
        public double SalesTax { get; set; }
        public double SalesTotal { get; set; }
        public string TenderType { get; set; }

        public Receipt()
        {

        }

        public Receipt(string Date, string StoreName, string PurchaseType, double SalesTax, double SalesTotal, string TenderType)
        {
            this.Date = Date;
            this.StoreName = StoreName;
            this.PurchaseType = PurchaseType;
            this.SalesTax = SalesTax;
            this.SalesTotal = SalesTotal;
            this.TenderType = TenderType;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
