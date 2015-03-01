﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker.Model;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using System.Reflection;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;
using ExpenditureTracker.Repository;
using ExpenditureTracker;
using System.Windows.Automation;
using TestStack.White.UIItems;

namespace ExpenditureTrackerTesting
{
    public class TestHelper
    {
        private static TestContext test_context;
        protected static Window window;
        private static Application application;
        private static ReceiptRepository repo = new ReceiptRepository();
        private static ReceiptContext context;
        private static String applicationPath;

        public static void SetupClass(TestContext _context)
        {
            var applicationDir = _context.DeploymentDirectory;
            applicationPath = Path.Combine(applicationDir, "..\\..\\..\\ExpenditureTracker\\bin\\Debug\\ExpenditureTracker");
        }

        public static void TestPrep()
        {
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
            context = repo.Context();
        }

        //BEGIN >> StartMenu//
        public void WhenIClickAddReceiptButton()
        {
            Button button = window.Get<Button>(SearchCriteria.ByAutomationId("StartMenuButtonReceiptForm"));
            button.Click();
        }

        public void ThenIShouldSeeAddReceiptForm()
        {
            DateTimePicker date = window.Get<DateTimePicker>(SearchCriteria.ByAutomationId("AddReceiptInputDate"));
            TextBox store = window.Get<TextBox>("AddReceiptInputStoreName");
            TextBox purchaseType = window.Get<TextBox>("AddReceiptInputPurchaseType");
            TextBox salesTax = window.Get<TextBox>("AddReceiptInputSalesTax");
            TextBox salesTotal = window.Get<TextBox>("AddReceiptInputSalesTotal");
            TextBox tenderType = window.Get<TextBox>("AddReceiptInputTenderType");
            Assert.IsTrue(date.Visible);
            Assert.IsTrue(store.Visible);
            Assert.IsTrue(purchaseType.Visible);
            Assert.IsTrue(salesTax.Visible);
            Assert.IsTrue(salesTotal.Visible);
            Assert.IsTrue(tenderType.Visible);
        }

        public void WhenIClickAddReportButton()
        {
            Button button = window.Get<Button>(SearchCriteria.ByAutomationId("StartMenuButtonReportForm"));
            button.Click();
        }

        public void ThenIShouldSeeAddReportForm()
        {
            Label test2 = window.Get<Label>("test2");
            Assert.IsTrue(test2.Visible);
        }
        //END >> StartMenu//

        //BEGIN >> AddReceipt//
        public void WhenIClickAddReceiptBackButton()
        {
            Button button = window.Get<Button>(SearchCriteria.ByAutomationId("AddReceiptBackButton"));
            button.Click();
        }

        public void ThenIShouldSeeStartMenu()
        {
            Button addReceipt_button = window.Get<Button>("StartMenuButtonReceiptForm");
            Button addReport_button = window.Get<Button>("StartMenuButtonReportForm");
            Assert.IsTrue(addReceipt_button.Enabled);
            Assert.IsTrue(addReport_button.Enabled);
        }

        public void WhenISelectADate(DateTime newDate)
        {
            DateTimePicker picker = window.Get<DateTimePicker>(SearchCriteria.ByAutomationId("AddReceiptInputDate"));
            picker.SetValue(newDate);
        }

        public void AndIInputAStoreName(string value)
        {
            var textBox = window.Get<TextBox>("AddReceiptInputStoreName");
            textBox.SetValue(value);
        }

        public void AndIInputAPurchaseType(string value)
        {
            var textBox = window.Get<TextBox>("AddReceiptInputPurchaseType");
            textBox.SetValue(value);
        }

        public void AndIInputSalesTax(double value)
        {
            var textBox = window.Get<TextBox>("AddReceiptInputSalesTax");
            textBox.SetValue(value);
        }

        public void AndIInputSalesTotal(double value)
        {
            var textBox = window.Get<TextBox>("AddReceiptInputSalesTotal");
            textBox.SetValue(value);
        }

        public void AndIInputATenderType(string value)
        {
            var textBox = window.Get<TextBox>("AddReceiptInputTenderType");
            textBox.SetValue(value);
        }

        public void AndIClickAddReceiptSubmitButton()
        {
            Button button = window.Get<Button>(SearchCriteria.ByAutomationId("AddReceiptSubmitButton"));
            button.Click();
        }

        public void ThenIShouldSeeViewReceiptList()
        {
            ListBox listbox = window.Get<ListBox>(SearchCriteria.ByAutomationId("ListOfReceipts"));
            Assert.IsTrue(listbox.Visible);
        }
        //END >> AddReceipt//

        //BEGIN >> ReceiptList//
        public void WhenIClickViewReceiptListBackButton()
        {
            Button button = window.Get<Button>(SearchCriteria.ByAutomationId("ViewReceiptListBackButton"));
            button.Click();
        }

        //END >> ReceiptList//

        //BEGIN >> AddReport//
        public void WhenIClickAddReportBackButton()
        {
            Button button = window.Get<Button>(SearchCriteria.ByAutomationId("AddReportBackButton"));
            button.Click();
        }

        public void WhenIClickAddReportSubmitButton()
        {
            Button button = window.Get<Button>(SearchCriteria.ByAutomationId("AddReportSubmitButton"));
            button.Click();
        }

        public void ThenIShouldSeeViewReport()
        {
            Label test3 = window.Get<Label>("test3");
            Assert.IsTrue(test3.Visible);
        }

        //END >> AddReport//

        //BEGIN >> ViewReport//
        public void WhenIClickViewReportBackButton()
        {
            Button button = window.Get<Button>(SearchCriteria.ByAutomationId("ViewReportBackButton"));
            button.Click();
        }

        

        //END >> ViewReport//


        public void GetReceiptDate(DateTime newDate)
        {
            var date = window.Get<DateTimePicker>("AddReceiptInputDate");
            date.Date = newDate;
            Assert.AreEqual(newDate, date.Date);
        }

        public void GetReceiptStoreName(string storeName)
        {
            var store = window.Get<TextBox>("AddReceiptInputStoreName");
            store.Text = storeName;
            Assert.AreEqual(storeName, store.Text);
        }

        public void GetReceiptPurchaseType(string purchaseType)
        {
            var purchasetype = window.Get<TextBox>("AddReceiptInputPurchaseType");
            purchasetype.Text = purchaseType;
            Assert.AreEqual(purchaseType, purchasetype.Text);
        }

        public void GetReceiptSalesTax(string salesTax)
        {
            var tax = window.Get<TextBox>("AddReceiptInputSalesTax");
            tax.Text = salesTax;
            Assert.AreEqual(salesTax, tax.Text);
        }

        public void GetReceiptSalesTotal(string salesTotal)
        {
            var total = window.Get<TextBox>("AddReceiptInputSalesTotal");
            total.Text = salesTotal;
            Assert.AreEqual(salesTotal, total.Text);
        }

        public void GetReceiptTenderType(string tenderType)
        {
            var tendertype = window.Get<TextBox>("AddReceiptInputTenderType");
            tendertype.Text = tenderType;
            Assert.AreEqual(tenderType, tendertype.Text);
        }

        

        //public void AndIShouldSeeTheHelperText()
        //{
        //    var text = window.Get(SearchCriteria.ByAutomationId("GettingStartedText"));
        //    Assert.IsTrue(text.Visible);
        //}

        //public void ThenIShouldSeeXReceipts(int expected)
        //{
        //    Assert.IsNotNull(window);
        //    SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("CountdownList").AndIndex(0);
        //    ListBox list_box = (ListBox)window.Get(searchCriteria);
        //    Assert.AreEqual(expected, list_box.Items.Count);
        //}

        //public void AndIShouldSeeXReceipts(int x)
        //{
        //    ThenIShouldSeeXReceipts(x);
        //}

        //public void AndTheButtonShouldBeEnabled(string buttonContent)
        //{
        //    Button button = window.Get<Button>(SearchCriteria.ByText(buttonContent));
        //    Assert.IsTrue(button.Enabled);
        //}

        //public void AndTheButtonShouldBeDisabled(string buttonContent)
        //{
        //    Button button = window.Get<Button>(SearchCriteria.ByText(buttonContent));
        //    Assert.IsFalse(button.Enabled);
        //}

        //public void AndIShouldSeeACountdownFor(string p1, string p2)
        //{
        //    //var e = repo.GetByDate(p2);
        //    Assert.IsNotNull(window);
        //    SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("CountdownList").AndIndex(0);
        //    ListBox list_box = (ListBox)window.Get(searchCriteria);
        //    var item = list_box.Items.Find(i => i.Text == p1);
        //    Assert.AreEqual(p1, item.Text);

        //}

        //public void ThenIShouldNotSeeTheReceiptForm()
        //{
        //    Button button = window.Get<Button>(SearchCriteria.ByAutomationId("AddReceipt"));
        //    Assert.IsFalse(button.Visible);
        //}

        //public void AndIClick(string buttonContent)
        //{
        //    AndIClick(buttonContent);
        //}

        //public void AndIChooseTheReceiptDate(DateTime newDate)
        //{
        //    DateTimePicker picker = window.Get<DateTimePicker>(SearchCriteria.ByAutomationId("ReceiptDate"));
        //    picker.SetValue(newDate);
        //}

        //public void WhenIFillInReceiptTitleWith(string value)
        //{
        //    var textBox = window.Get<TextBox>("ReceiptTitle");
        //    textBox.SetValue(value);
        //}

        //public void AndTheReceiptDateShouldBe30DaysFromNow()
        //{
        //    DateTimePicker picker = window.Get<DateTimePicker>(SearchCriteria.ByAutomationId("ReceiptDate"));
        //    DateTime? actual = picker.Date;
        //    DateTime expected = DateTime.Today.AddDays(30);
        //    Assert.AreEqual(expected, actual);
        //}

        //public void AndIShouldNotSeeTheHelperText()
        //{
        //    var text = window.Get(SearchCriteria.ByAutomationId("GettingStartedText"));
        //    Assert.IsFalse(text.Visible);
        //}

        //public void ThenIShouldSeeTheReceiptForm()
        //{
        //    Button button = window.Get<Button>(SearchCriteria.ByAutomationId("AddReceipt"));
        //    Assert.IsTrue(button.Visible);
        //}

        //public void WhenIClick(string buttonContent)
        //{
        //    Button button = window.Get<Button>(SearchCriteria.ByText(buttonContent));
        //    button.Click();
        //}

        //public void ThenIShouldSeeACountdownFor(string p1, string p2)
        //{
        //    throw new NotImplementedException();
        //}

        //public void GivenThereAreNoReceipts()
        //{
        //    Assert.AreEqual(0, repo.GetCount());
        //}

        public static void GivenTheseReceipts(params Receipt[] Receipts)
        {
            foreach (Receipt evnt in Receipts)
            {
                // Add Receipt to Receipts here.
                repo.Add(evnt);
            }

            //context.SaveChanges();
            Assert.AreEqual(Receipts.Length, repo.GetCount());
        }

        public static void CleanThisUp()
        {
            window.Close();
            application.Close();
            repo.Clear();
        }
    }
}