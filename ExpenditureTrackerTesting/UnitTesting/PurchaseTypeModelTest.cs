using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker.Model;

namespace ExpenditureTrackerTesting
{
    [TestClass]
    public class PurchaseTypeModelTest
    {
        [TestMethod]
        public void CreatingAReceiptStoresPurchaseTypeProperties()
        {
            PurchaseType purchaseType = new PurchaseType(1, "Groceries");
            Assert.AreEqual(1, purchaseType.PurchaseTypeId);
            Assert.AreEqual("Groceries", purchaseType.PurchaseTypeName);
        }
    }
}
