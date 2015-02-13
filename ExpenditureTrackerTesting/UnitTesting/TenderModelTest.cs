using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker.Model;

namespace ExpenditureTrackerTesting.UnitTesting
{
    [TestClass]
    public class TenderModelTest
    {
        [TestMethod]
        public void CreatingAReceiptStoresTenderProperties()
        {
            Tender tender = new Tender(1, "Cash");
            Assert.AreEqual(1, tender.TenderId);
            Assert.AreEqual("Cash", tender.TenderName);
        }
    }
}
