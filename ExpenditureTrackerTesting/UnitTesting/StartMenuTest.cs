using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker;
using ExpenditureTracker.Model;

namespace ExpenditureTrackerTesting
{
    [TestClass]
    public class StartMenuTest : TestHelper
    {

        [ClassInitialize]
        public static void SetupTests(TestContext _context)
        {
            TestHelper.SetupClass(_context);
        }

        [TestInitialize]
        public void SetupTests()
        {
            TestHelper.TestPrep();
        }

        [TestCleanup]
        public void CleanUp()
        {
            TestHelper.CleanThisUp();
        }

        //BEGIN >> Button click Testing//
        [TestMethod]
        public void StartMenuAddReceiptButtonClickTest()
        {
            WhenIClickAddReceiptButton();
            ThenIShouldSeeAddReceiptForm();
        }

        [TestMethod]
        public void StartMenuReportButtonClickTest()
        {
            WhenIClickAddReportButton();
            ThenIShouldSeeReportForm();
        }
        //END >> Button click Testing//
    }
}