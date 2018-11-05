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
    /// Customer management system
    /// </summary>
    /// 

    /*
     *Suvi Helin (40325472)
     * Main Window
     * Includes event handlers for buttons: generate id, add customer,
     * find, delete, list all.
     * Has validation for textboxes
     * Has a function for clearing the form
     * Notices if selection is changed in combobox or in listbox
     * 31.10.2018
     */


    public partial class MainWindow : Window
    {
        private int id = 0;

        private int count = 10001;

        private string pref = "";
        
        private MailingList store = new MailingList();

        public MainWindow()
        {

           
            InitializeComponent();

            //combobox items
            ComboboxPrefContact.Items.Add("email");
            ComboboxPrefContact.Items.Add("skype");
            ComboboxPrefContact.Items.Add("tel");
            


        }

        //if selection in combobox is changed

        private void ComboboxPrefContact_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int test = ComboboxPrefContact.SelectedIndex;

            if (test == 0)
            {
                pref = "email";
            }

            if (test == 1)
            {
                pref = "skype";
            }

            if (test == 2)
            {
                pref = "tel";
            }
        }


        //this button generates an id
        private void btnGenerateAnID_Click(object sender, RoutedEventArgs e)
        {

            //checks if the id number already exists in the list, if it does adds one to the count
            Customer c = store.find(count);

            
            if (c == null)
            {
                txtBoxID.Text = Convert.ToString(count);
                
            }

            else
            {
                count++;
                txtBoxID.Text = Convert.ToString(count);
            }
        }

        //add button adds a customer to the store list after validating the information written into the textboxes
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            //Convert id to numberic

            try
            {
                id = Convert.ToInt32(txtBoxID.Text);
            }
            catch
            {
                MessageBox.Show("ID must be a number");
                id = 0;
                return;
                
            }




            try

             {
                //VALIDATION
                string a = "@";

                //a First Name textbox cannot be blank
                if (txtBoxFirstName.Text == "" || txtBoxFirstName.Text == "First name")
                {
                    throw new System.ArgumentException("Field cannot be blank", "FirstName");
                }

                //a SurName textbox cannot be blank
                if (txtBoxSurname.Text == "" || txtBoxSurname.Text == "Surname")
                {
                    throw new System.ArgumentException("Field cannot be blank", "SurName");
                }

                //an ID has to be between 10001 and 50000
                if ((id <10001) || (id > 50000))
                {
                    throw new System.ArgumentException("ID number must be in the range 10001 to 50000", "ID");
                    
                }

                //an Email has to contain @ sign
                if (!txtBoxEmail.Text.Contains(a))
                {
                    throw new System.ArgumentException("Email should contain @ ");
                }

                //a Telephone textbox cannot be blank
                if (txtBoxTelephone.Text == "" || txtBoxTelephone.Text == "Telephone")
                {
                    throw new System.ArgumentException("Field cannot be blank", "Telephone");
                }

                //a SkypeID textbox cannot be blank
                if (txtBoxSkypeID.Text == "" || txtBoxSkypeID.Text == "Skype ID")
                {
                    throw new System.ArgumentException("Field cannot be blank", "Skype ID");
                }

                //one of the items in the combobox has to be chosen
                if (pref == String.Empty)
                {
                    throw new System.ArgumentException("Please choose preferred contact");
                }


                //adding a new customer to the store list
                Customer aCustomer = new Customer();
                
             
                //count will increment only if "generate id" button has been used 
                if (Convert.ToInt32(txtBoxID.Text) == count)
                {
                    count++;
                }

                aCustomer.ID = Convert.ToInt32(txtBoxID.Text);
                aCustomer.FirstName = txtBoxFirstName.Text;
                aCustomer.SurName = txtBoxSurname.Text;
                aCustomer.Email = txtBoxEmail.Text;
                aCustomer.SkypeID = txtBoxSkypeID.Text;
                aCustomer.Telephone = txtBoxTelephone.Text;
                aCustomer.PreferredContact = pref;

                store.add(aCustomer);
                //MessageBox.Show("A new customer added! " + "\n" + txtBoxID.Text);

                //adding a customer into the listbox
                listBoxCustomers.Items.Add(aCustomer.ID.ToString() + "\t" + aCustomer.FirstName + " " + aCustomer.SurName);

                //clearing the form after adding the customer
                Clear();

             }

             catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

             
            
        }

         //find button takes an int and finds the customer with the equivalent int and their info from the store list

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {

            //Convert id to numberic

            int id;

            try
            {
                id = Convert.ToInt32(txtBoxID.Text);
            }
            catch
            {
                MessageBox.Show("ID must be a number");
                id = 0;
                return;

            }


            try
            {

                //an ID has to be between 10001 and 50000
                if ((id < 10001) || (id > 50000))
                {
                    throw new System.ArgumentException("ID number must be in the range 10001 to 50000", "ID");

                }

                
                Customer c = store.find(id);

                //if customer not found show a messagebox
                if (c == null)
                {
                    MessageBox.Show("ID not found");
                    return;
                }

                //showing the customer info in the form
                txtBoxFirstName.Text = c.FirstName;
                txtBoxSurname.Text = c.SurName;
                txtBoxEmail.Text = c.Email;
                txtBoxSkypeID.Text = c.SkypeID;
                txtBoxTelephone.Text = c.Telephone;
                ComboboxPrefContact.Text = c.PreferredContact;
                
                
         
              
                

            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }


            

        }

        //a button for deleting a customer from the store list
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Convert id to numberic

            int id;

            try
            {
                id = Convert.ToInt32(txtBoxID.Text);
            }
            catch
            {
                MessageBox.Show("ID must be a number");
                id = 0;
                return;

            }


            try
            {

                //an ID has to be between 10001 and 50000
                if ((id < 10001) || (id > 50000))
                {
                    throw new System.ArgumentException("ID number must be in the range 10001 to 50000", "ID");

                }


                store.delete(id);
                MessageBox.Show("Customer deleted");
                listBoxCustomers.Items.Remove(listBoxCustomers.SelectedItem);

                Clear();




            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        //clears the form
        public void Clear()
        {
            txtBoxID.Text = "ID";
            txtBoxFirstName.Text = "First Name";
            txtBoxSurname.Text = "Surname";
            txtBoxEmail.Text = "Email";
            txtBoxSkypeID.Text = "Skype ID";
            txtBoxTelephone.Text = "Telephone";
            pref = "";
            ComboboxPrefContact.Text = "";
        }


        //clears textboxes from the placeholder text when clicked
        private void txtBoxID_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
           
        }

        private void txtBoxFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
          
        }

        private void txtBoxSurname_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
           
        }

        private void txtBoxEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
          
        }

        private void txtBoxSkypeID_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            
        }

        private void txtBoxTelephone_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            
        }

        // Opens a new window when List all button is clicked
        private void btnListAll_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow newWin = new SecondWindow(store);
            newWin.Show();

        }

        //notices when a selection in the list box is changed and shows the customer info in the textboxes
        private void listBoxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            if (listBoxCustomers.SelectedItem == null)
            {
                return;
            }

            
            
                string listBoxInfo = listBoxCustomers.SelectedItem.ToString();

                int id = Convert.ToInt32(listBoxInfo.Substring(0,5));

                Customer a = store.find(id);

                txtBoxID.Text = a.ID.ToString();
                txtBoxFirstName.Text = a.FirstName;
                txtBoxSurname.Text = a.SurName;
                txtBoxEmail.Text = a.Email;
                txtBoxSkypeID.Text = a.SkypeID;
                txtBoxTelephone.Text = a.Telephone;
                ComboboxPrefContact.Text = a.PreferredContact;
            

        }
    }
}
