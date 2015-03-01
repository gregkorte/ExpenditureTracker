using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker;
using ExpenditureTracker.Model;

namespace ExpenditureTrackerTesting
{
    [TestClass]
    public class ReceiptTest : TestHelper
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

        //[TestMethod]
        //public void ThisIsStartMenuButtonClickTest()
        //{
        //    IClick();
        //    IShouldSeeAddReceiptForm();
        //}

        //[TestMethod]
        //public void ThisIsReceiptListButtonClickTest()
        //{
        //    IClick();
        //    IShouldSeeAddReceiptForm();
        //    GetReceiptDate(new DateTime(2015, 12, 25));
        //    GetReceiptStore("Publix");
        //    GetReceiptSalesTax(".09");
        //    GetReceiptSalesTotal("1.09");
        //    ReceiptListClick();
        //    IShouldSeeReceiptList();
        //}

        //[TestMethod]
        //public void ThisIsStartMenuReportButtonClickTest()
        //{
        //    ReportFormClick();
        //    IShouldSeeReportForm();
        //}

        //[TestMethod]
        //public void ThisIsReportListButtonClickTest()
        //{
        //    ReportFormClick();
        //    IShouldSeeReportForm();
        //    ReportClick();
        //    IShouldSeeReport();
        //}

        //[TestMethod]
        //public void ScenarioHappyPathEventCreation()
        //{
        //    GivenThereAreNoEvents();
        //    WhenIClick("+");
        //    ThenIShouldSeeTheEventForm();
        //    AndIShouldNotSeeTheHelperText();
        //    AndTheEventDateShouldBe30DaysFromNow();
        //    AndTheButtonShouldBeDisabled("+");
        //    WhenIFillInEventTitleWith("Valentine's");
        //    AndIChooseTheEventDate(new DateTime(2015, 02, 14));
        //    AndIClick("Add");
        //    ThenIShouldNotSeeTheEventForm();
        //    AndIShouldSeeXEvents(1);
        //    AndIShouldSeeACountdownFor("Valentine's", "02/14/15");
        //    AndIShouldNotSeeTheHelperText();
        //    AndTheButtonShouldBeEnabled("+");
        //}

        //[TestMethod]
        //public void ScenarioDataValidationForEventCreation()
        //{
        //    GivenThereAreNoEvents();
        //    WhenIClick("+");
        //    AndIClick("Add");
        //    ThenIShouldSeeTheEventForm();
        //    AndIShouldSeeAnErrorMessage("Event title must be filled in.");
        //    WhenIFillInEventTitleWith("Valentine's");
        //    AndIChooseTheEventDate(new DateTime(2015, 02, 14));
        //    AndIClick("Add");
        //    ThenIShouldNotSeeTheEventForm();
        //    AndIShouldSeeXEvents(1);
        //    AndIShouldSeeACountdownFor("Valentine's", "02/14/15");
        //}

        //[TestMethod]
        //public void ScenarioCancelingOutOfEventCreation()
        //{
        //    GivenThereAreNoEvents();
        //    WhenIClick("+");
        //    WhenIFillInEventTitleWith("Valentine's");
        //    AndIChooseTheEventDate(new DateTime(2015, 02, 14));
        //    AndIClick("Cancel");
        //    ThenIShouldNotSeeTheEventForm();
        //    AndIShouldSeeXEvents(0);
        //    AndIShouldSeeTheHelperText();
        //    AndTheButtonShouldBeEnabled("+");
        //    WhenIClick("+");
        //    ThenIShouldSeeTheEventForm();
        //    AndTheEventDateShouldBe30DaysFromNow();
        //    AndTheButtonShouldBeDisabled("+");
        //}
    }
}