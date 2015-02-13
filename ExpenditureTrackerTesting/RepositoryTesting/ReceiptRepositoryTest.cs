using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker.Repository;
using ExpenditureTracker;
using ExpenditureTracker.Model;
using ExpenditureTrackerTesting;

namespace ExpenditureTrackerTesting.RepositoryTesting
{
    [TestClass]
    public class ReceiptRepositoryTest
    {
        private static ReceiptRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new ReceiptRepository();
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
        public void TestAddReceiptToDatabase()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Receipt("12/31/2015", .09, 1.09));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestAllReceiptMethod()
        {
            repo.Add(new Receipt("12/31/2015", .09, 1.09));
            repo.Add(new Receipt("01/08/2015", .18, 2.18));
            Assert.AreEqual(2, repo.GetCount());
        }

        [TestMethod]
        public void TestReceiptGetCount()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Receipt("12/31/2015", .09, 1.09));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestClear()
        {
            repo.Add(new Receipt("12/31/2015", .09, 1.09));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReceiptsAreUnique()
        {
            repo.Clear();
            repo.Add(new Receipt("12/31/2015", .09, 1.09));
            repo.Add(new Receipt("12/31/2015", .09, 1.09));
        }
    }
}