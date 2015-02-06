using System;
using System.Collections.Generic;
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

namespace ExpenditureTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickToReceiptForm(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("You're one step closer to knowing where your fucking money is...");
        }

        private void ClickToReportForm(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
