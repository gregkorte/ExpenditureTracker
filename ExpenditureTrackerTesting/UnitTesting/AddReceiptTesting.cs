using System;
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
            WhenIClickAddReceiptBackButton();
            ThenIShouldSeeStartMenu();
        }

        [TestMethod]
        public void AddReceiptSubmitButtonClickTest()
        {
            WhenIClickAddReceiptSubmitButton();
            ThenIShouldSeeViewReceiptList();
        }

        //[TestMethod]
        //public void AddNewStore()
        //{
        //    WhenIClickAddNewStoreButton();
        //    ThenIShouldSeeAddNewStoreInputTextBox();
        //    AndIShouldSeeAddNewStoreSubmitButton();
        //    WhenIFillInTheNewStoreName();
        //    AndIClickAddNewStoreSubmitButton();
        //    ThenIShouldNotSeeAddNewStoreInputTextBox();
        //    AndIShouldNotSeeAddNewStoreSubmitButton();
        //    AndNewStoreShouldShowInComboBox();
        //}

        //[TestMethod]
        //public void AddNewPurchaseType()
        //{
        //    WhenIClickAddNewPurchaseTypeButton();
        //    ThenIShouldSeeAddNewPurchaseTypeInputTextBox();
        //    AndIShouldSeeAddNewPurchaseTypeSubmitButton();
        //    WhenIFillInTheNewPurchaseTypeName();
        //    AndIClickAddNewPurchaseTypeSubmitButton();
        //    ThenIShouldNotSeeAddNewPurchaseTypeInputTextBox();
        //    AndIShouldNotSeeAddNewPurchaseTypeSubmitButton();
        //    AndNewPurchaseTypeShouldShowInComboBox();
        //}

        //[TestMethod]
        //public void AddNewTenderType()
        //{
        //    WhenIClickAddNewTenderTypeButton();
        //    ThenIShouldSeeAddNewTenderTypeInputTextBox();
        //    AndIShouldSeeAddNewTenderTypeSubmitButton();
        //    WhenIFillInTheNewTenderTypeName();
        //    AndIClickAddNewTenderTypeSubmitButton();
        //    ThenIShouldNotSeeAddNewTenderTypeInputTextBox();
        //    AndIShouldNotSeeAddNewTenderTypeSubmitButton();
        //    AndNewTenderTypeShouldShowInComboBox();
        //}
        //END >> Button click Testing//
    }
}