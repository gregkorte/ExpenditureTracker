﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenditureTracker;
using ExpenditureTracker.Model;

namespace ExpenditureTrackerTesting
{
    [TestClass]
    public class AddReceiptTest : TestHelper
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
        public void AddReceiptBackButtonClickTest()
        {
            WhenIClickAddReceiptButton();
            ThenIShouldSeeAddReceiptForm();
            WhenIClickAddReceiptBackButton();
            ThenIShouldSeeStartMenu();
        }

        [TestMethod]
        public void AddReceiptSubmitButtonClickTest()
        {
            WhenIClickAddReceiptButton();
            ThenIShouldSeeAddReceiptForm();
            WhenISelectADate(new DateTime(2015, 02, 14));
            AndIInputAStoreName("Publix");
            AndIInputAPurchaseType("Groceries");
            AndIInputSalesTax(.45);
            AndIInputSalesTotal(5.45);
            AndIInputATenderType("Cash");
            AndIClickAddReceiptSubmitButton();
            ThenIShouldSeeViewReceiptList();
        }
        //END >> Button click Testing//
    }
}