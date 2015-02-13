using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.BDDfy;

namespace ExpenditureTrackerTesting
{
    [TestClass]
    public class UserStories
    {
        //private static TestContext test_context;
        private static Window window;
        private static Application application;
        private static Button receipt_button;
        private static Button report_button;

        [ClassInitialize]
        public static void InitialState(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _context)
        {
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\ExpenditureTracker\\bin\\Debug\\ExpenditureTracker");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("Expenditure Tracker", InitializeOption.NoCache);
            receipt_button = window.Get<Button>("ButtonToReceiptForm");
            report_button = window.Get<Button>("ButtonToReportForm");
        }

        //As a User
        void WhenTheReceiptButtonIsClicked()
        {
            receipt_button.Click();
        }

        void GivenTheMainWindowIsOpen()
        {
            Assert.IsTrue(window.IsFocussed);
        }

        void ThenOpenAddReceiptWindow()
        {
            Assert.IsFalse(window.IsFocussed);
        }

        [TestMethod]
        public void ExecuteUserStories()
        {
            this.BDDfy();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            window.Close();
            application.Close();
        }
    }
}
