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
    public class PurchaseTypeRepositoryTest
    {
        private static PurchaseTypeRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new PurchaseTypeRepository();
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
        public void TestAddToDatabase()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new PurchaseType(1, "Groceries"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestAllMethod()
        {
            repo.Add(new PurchaseType(1, "Groceries"));
            repo.Add(new PurchaseType(2, "Fuel"));
            Assert.AreEqual(2, repo.GetCount());
        }

        [TestMethod]
        public void TestGetCount()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new PurchaseType(1, "Groceries"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestClear()
        {
            repo.Add(new PurchaseType(1, "Groceries"));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReceiptsAreUnique(){
            repo.Clear();
            repo.Add(new PurchaseType(1, "Groceries"));
            repo.Add(new PurchaseType(1, "Groceries"));
        }
    }
}