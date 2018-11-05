using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessObjects;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MailingList store = new MailingList();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            /* try

             {
                 //if(textBox1.Text == string.Empty || textBox2.Text == string.Empty) VALIDATION
             }

             catch
             {

             }
             Customer aCustomer = new Customer();
             
             aCustomer.ID = Convert.ToInt32(txtBoxID.Text);
             aCustomer.FirstName = txtBoxFirstName.Text;
             aCustomer.Surname = txtBoxSurname.Text;
             aCustomer.Address = txtBoxAddress.Text;
             aCustomer.

             store.add(aCustomer);            */
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtBoxID_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= txtBoxID_GotFocus;
        }

        private void txtBoxFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= txtBoxFirstName_GotFocus;
        }

        private void txtBoxSurname_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= txtBoxSurname_GotFocus;
        }

        private void txtBoxEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= txtBoxEmail_GotFocus;
        }

        private void txtBoxSkypeID_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= txtBoxSkypeID_GotFocus;
        }

        private void txtBoxTelephone_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= txtBoxTelephone_GotFocus;
        }

        private void txtBoxPreferredContact_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= txtBoxPreferredContact_GotFocus;
        }

       
    }
}
