using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker.Repository;
using ExpenditureTracker;
using ExpenditureTracker.Model;
using ExpenditureTrackerTesting;

namespace ReceiptRepositoryTest.RepositoryTesting
{
[TestClass]
    public class TenderRepositoryTest
    {
        private static TenderRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new TenderRepository();
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
        }

        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }

        [TestMethod]
        public void TestAddTenderToDatabase()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Tender(1, "Cash"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestAllTenderMethod()
        {
            repo.Add(new Tender(1, "Cash"));
            repo.Add(new Tender(2, "Visa 1"));
            Assert.AreEqual(2, repo.GetCount());
        }

        [TestMethod]
        public void TestTenderGetCount()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Tender(1, "Cash"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestClear()
        {
            repo.Add(new Tender(1, "Cash"));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TendersAreUnique()
        {
            repo.Clear();
            repo.Add(new Tender(1, "Cash"));
            repo.Add(new Tender(1, "Cash"));
        }
    }
}
