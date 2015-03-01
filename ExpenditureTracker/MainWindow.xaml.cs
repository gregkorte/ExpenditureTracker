﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using ExpenditureTracker.Model;
using ExpenditureTracker.Repository;
using ExpenditureTracker;

namespace ExpenditureTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ReceiptRepository receiptRepo = new ReceiptRepository();

        public MainWindow()
        {
            InitializeComponent();
            ListOfReceipts.DataContext = receiptRepo.Context().Receipts.Local;
        }

        //BEGIN >> StartMenu events//
        private void StartMenuButtonReceiptForm_Click(object sender, RoutedEventArgs e)
        {
            AddReceipt.Visibility = Visibility.Visible;
            StartMenu.Visibility = Visibility.Hidden;
        }

        private void StartMenuButtonReportForm_Click(object sender, RoutedEventArgs e)
        {
            ReportForm.Visibility = Visibility.Visible;
            StartMenu.Visibility = Visibility.Hidden;
        }
        //END >> StartMenu events//

        //BEGIN >> AddReceipt events//
        private void AddReceiptBackButton_Click(object sender, RoutedEventArgs e)
        {
            StartMenu.Visibility = Visibility.Visible;
            AddReceipt.Visibility = Visibility.Hidden;
        }

        private void AddReceiptResetButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddReceiptSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            StartMenu.Visibility = Visibility.Hidden;
            AddReceipt.Visibility = Visibility.Hidden;
            ViewReceiptList.Visibility = Visibility.Visible;
            DateTime receiptdate = (DateTime)AddReceiptInputDate.SelectedDate;
            //ToShortDateString - puts into normal format
            var date = (string)receiptdate.ToShortDateString();
            //convert string to double for salestax and salestotal
            double salestax = Convert.ToDouble(AddReceiptInputSalesTax.Text);
            double salestotal = Convert.ToDouble(AddReceiptInputSalesTotal.Text);
            receiptRepo.Add(new Receipt(date, AddReceiptInputStoreName.Text, AddReceiptInputPurchaseType.Text, salestax, salestotal, AddReceiptInputTenderType.Text));
        }

        private void ReportFormSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            StartMenu.Visibility = Visibility.Hidden;
            ReportForm.Visibility = Visibility.Hidden;
            ViewReport.Visibility = Visibility.Visible;
        }
        //END >> AddReceipt events//
    }
}
