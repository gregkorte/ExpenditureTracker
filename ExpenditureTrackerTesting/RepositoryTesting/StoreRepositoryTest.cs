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
    public class StoreRepositoryTest
    {
        private static StoreRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new StoreRepository();
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
            repo.Add(new Store(1, "Publix"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestAllMethod()
        {
            repo.Add(new Store(1, "Publix"));
            repo.Add(new Store(2, "Mapco"));
            Assert.AreEqual(2, repo.GetCount());
        }

        [TestMethod]
        public void TestGetCount()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Store(1, "Publix"));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestClear()
        {
            repo.Add(new Store(1, "Publix"));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StoresAreUnique(){
            repo.Clear();
            repo.Add(new Store(1, "Publix"));
            repo.Add(new Store(1, "Publix"));
        }
    }
}