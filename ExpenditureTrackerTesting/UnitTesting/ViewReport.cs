using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker;
using ExpenditureTracker.Model;

namespace ExpenditureTrackerTesting
{
    [TestClass]
    public class ViewReportTest : TestHelper
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
        public void AddReportBackButtonClickTest()
        {
            WhenIClickAddReportButton();
            ThenIShouldSeeAddReportForm();
            WhenIClickAddReportSubmitButton();
            ThenIShouldSeeViewReport();
            WhenIClickViewReportBackButton();
            ThenIShouldSeeAddReportForm();
        }

        //END >> Button click Testing//
    }
}