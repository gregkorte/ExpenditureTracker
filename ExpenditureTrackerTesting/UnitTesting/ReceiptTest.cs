using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker;
using ExpenditureTracker.Model;

namespace ExpenditureTrackerTesting
{
    [TestClass]
    public class ReceiptTest
    {

        [TestMethod]
        public void CreatingAReceiptStoresItsProperties()
        {
            Receipt receipt = new Receipt("02/14/14", "Publix", "Groceries", .09, 1.09, "Cash");
            Assert.AreEqual("02/14/14", receipt.Date);
            Assert.AreEqual("Publix", receipt.StoreName);
            Assert.AreEqual("Groceries", receipt.PurchaseType);
            Assert.AreEqual(.09, receipt.SalesTax);
            Assert.AreEqual(1.09, receipt.SalesTotal);
            Assert.AreEqual("Cash", receipt.TenderType);
        }
    }
}