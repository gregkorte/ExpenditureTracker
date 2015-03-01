using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace ExpenditureTrackerTesting
{
    [TestClass]
    public class ZeroState
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;
        private static Button receipt_button;
        private static Button report_button;

        [ClassInitialize]
        public static void InitialState(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\ExpenditureTracker\\bin\\Debug\\ExpenditureTracker");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
            receipt_button = window.Get<Button>("StartMenuButtonReceiptForm");
            report_button = window.Get<Button>("StartMenuButtonReportForm");
        }

        [TestMethod]
        public void TestZeroState()
        {
            Button addReceipt_button = window.Get<Button>("StartMenuButtonReceiptForm");
            Button addReport_button = window.Get<Button>("StartMenuButtonReportForm");
            Assert.IsTrue(addReceipt_button.Enabled);
            Assert.IsTrue(addReport_button.Enabled);
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            window.Close();
            application.Close();
        }
    }
}