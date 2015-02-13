using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker.Model;

namespace ExpenditureTrackerTesting.UnitTesting
{
    [TestClass]
    public class StoreModelTest
    {
        [TestMethod]
        public void CreatingAReceiptStoresStoreProperties()
        {
            Store store = new Store(1, "Publix");
            Assert.AreEqual(1, store.StoreId);
            Assert.AreEqual("Publix", store.StoreName);
        }
    }
}
