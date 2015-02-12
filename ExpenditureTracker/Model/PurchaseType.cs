using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenditureTracker.Model
{
    class PurchaseType
    {
        public int ReceiptId { get; set; }
        public int PurchaseTypeId { get; set; }
        public string PurchaseType { get; set; }

        public PurchaseType(int PurchaseTypeId, string PurchaseType)
        {
            this.PurchaseTypeId = PurchaseTypeId;
            this.PurchaseType = PurchaseType;
        }
    }
}
